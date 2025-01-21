using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        //en este ejemplo no necesitamos un Model
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
    public RepositoryUpdateEmpleados()
        {
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
    public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            //abrimos la conexion
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficios = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficios;
        }

        //sacar los empleados por oficio
        public async Task<List<string>> GetEmpleadosOficioAsync(string oficio)
        {
            string sql = "select * from EMP where OFICIO=@oficio";
            //como es un string  no hace falta crearlo como objeto
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }
        //devolvemos el int del numero de empleados afectados por el incremeno salarial
        public async Task<int> UpdateEmpleadosOficio(string oldOficio, string newOficio, int incremento)
        {
            string sql = "update EMP set SALARIO=SALARIO+@incremento, OFICIO=@newOficio where OFICIO=@oldOficio";
            this.com.Parameters.AddWithValue("@oldOficio", oldOficio);
            this.com.Parameters.AddWithValue("@newOficio", newOficio);
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int afectados = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return afectados;
        }
        public async Task<DatosEmpleadosOficio> GetDatosEmpleadosOficioAsync(string oficio)
        {
            string sql = "select SUM(SALARIO) as SumaSalarios, AVG(SALARIO) as MediaSalario, MAX(SALARIO) as MaximoSalario from emp where oficio=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosEmpleadosOficio datos = new DatosEmpleadosOficio();
            if (await this.reader.ReadAsync())
            {
                //en cuanto devuelvo dos: crear Modelo
                datos.SumaSalarial = int.Parse(this.reader["SumaSalarios"].ToString());
                datos.Mediasalarial = int.Parse(this.reader["MediaSalario"].ToString());
                datos.MaximoSalarial = int.Parse(this.reader["MaximoSalario"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return datos;
        }
    }



    }
