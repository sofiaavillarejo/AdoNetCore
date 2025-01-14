using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetNombresDptosAsync()
        {
            string sql = "select DNOMBRE from DEPT";
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> dptos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombreDpto = this.reader["DNOMBRE"].ToString();
                dptos.Add(nombreDpto);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return dptos;
        }

        public async Task<List<string>> GetNombreEmpleadoAsync(string nombreDpto)
        {
            string sql = "select EMP.APELLIDO from EMP inner join DEPT on EMP.DEPT_NO = DEPT.DEPT_NO where DEPT.DNOMBRE=@nombreDpto";
            SqlParameter pamNomDpto = new SqlParameter("@nombreDpto", nombreDpto);
            this.com.Parameters.Add(pamNomDpto);
            this.com.Connection = this.cn;
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

        public async Task DeleteEmpleadoAsync(string apeEmp)
        {
            string sql = "delete from emp where APELLIDO=@apellidoEmp";
            SqlParameter pamApeEmp = new SqlParameter("@apellidoEmp", apeEmp);
            this.com.Parameters.Add(pamApeEmp);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

    }
}
