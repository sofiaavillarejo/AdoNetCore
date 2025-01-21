using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;

#region STORED PROCEDURES
    //create procedure SP_ALL_DPTOS
    //as
    // select * from DEPT
    //go

    //create procedure SP_EMPLEADOS_DPTO_OUT (@nombre nvarchar(50), @suma int OUT, @media int OUT, @personas int OUT)
    //as
    // declare @id int
    // select @id = DEPT_NO from DEPT where DNOMBRE=@nombre
    // select * from EMP where DEPT_NO=@id
    // select @suma = SUM(SALARIO), @media = AVG(SALARIO), @PERSONAS = COUNT(EMP_NO) from EMP where DEPT_NO=@id
    //go
#endregion

namespace AdoNetCore.Repositories
{
    public class RepositoryParametrosOut
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
    public RepositoryParametrosOut ()
    {
        string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
        this.cn = new SqlConnection(connectionString);
        this.com = new SqlCommand();
        this.com.Connection = this.cn;
    }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }
        public async Task<Empleado> MostrarDatosAsync(string nombre)
        {
            string sql = "SP_EMPLEADOS_DPTO_OUT";
            //PARA LOS PARAMETROS DE ENTRADA PODEMOS UTILIZAR 
            //AddWithValue SIN PROBLEMAS
            //PARA LOS PARAMETROS DE ENTRADA ES IMPRESCINDIBLE 
            //UTILIZAR OBJETOS Parameter
            this.com.Parameters.AddWithValue("@nombre", nombre);
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            //INDICAMOS LA DIRECCION DEL PARAMETRO
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            Empleado model = new Empleado();
            List<string> apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                apellidos.Add(apellido);
            }
            await this.reader.CloseAsync();
            //GUARDAMOS LOS DATOS EN  NUESTRO MODEL
            model.Apellidos = apellidos;
            model.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            model.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            model.Personas = int.Parse(pamPersonas.Value.ToString());

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return model;

        }
    }


}
