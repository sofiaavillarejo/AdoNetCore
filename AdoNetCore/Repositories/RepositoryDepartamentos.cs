using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentos()
            {
                string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
                this.cn = new SqlConnection(connectionString);
                this.com = new SqlCommand();
                this.com.Connection = this.cn;
            }

        //create, read, update y delete

        //devolver dptos
        public async Task <List<Departamento>> GetDepartamentosAsync()
        {
            string sql = "select * from DEPT";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Departamento> departamentos = new List<Departamento>();
            while (await this.reader.ReadAsync())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                Departamento dept = new Departamento();
                dept.Nombre = nombre;
                dept.Localidad = localidad;
                dept.IdDepartamento = id;
                departamentos.Add(dept);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task InsertDptosAsync (int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values (@id, @nombre, @localidad)";
            SqlParameter pamId = new SqlParameter("@id", id);
            this.com.Parameters.Add(pamId);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            this.com.Parameters.Add(pamNombre);
            SqlParameter pamLocalidad = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamLocalidad);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }

        public async Task UpdateDepartamentoAsync (int id, string nombre, string localidad)
        {
            string sql = "update dept set DNOMBRE= @nombre, LOC=@localidad where DEPT_NO=@id";
            //TENEMOS UN METODO PARA ALMACENAR PARAMETROS DIRECTAMENTE EN EL COMMAND SIN CREAR OBJETOS
            //ESTE METODO SOLO SE USA CUANDO LOS PARAMETROS SEAN TIPADOS PRIMITIVOS
            //no crea el objeto -> nos saltamos lo de sqlparameter ... new sqlparameter, lo hace internamente
            //si es un tipo no primitivo, lo tenfo que añadir de forma explicita
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteDptoAsync(int id)
        {
            string sql = "delete from DEPT where DEPT_NO=@id";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}

