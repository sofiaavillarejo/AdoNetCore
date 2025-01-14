using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task <List<Hospital>> GetHospitalsAsync()
        {
            string sql = " select * from HOSPITAL";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Hospital> hospitales = new List<Hospital>();
            while (await this.reader.ReadAsync())
            {
                int idHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                string nombre = this.reader["NOMBRE"].ToString();
                string direccion = this.reader["DIRECCION"].ToString();
                string telefono = this.reader["TELEFONO"].ToString();
                int camas = int.Parse(this.reader["NUM_CAMA"].ToString());
                Hospital hosp = new Hospital();
                hosp.IdHospital = idHospital;
                hosp.Nombre = nombre;
                hosp.Direccion = direccion;
                hosp.Telefono = telefono;
                hosp.Camas = camas;
                hospitales.Add(hosp);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task InsertHospiAsync (int idHospital, string nombre, string direccion, string telefono, int camas)
        {
            string sql = " insert into HOSPITAL values (@idhospital, @nombre, @direccion, @telefono, @camas)";
            this.com.Parameters.AddWithValue("@idhospital", idHospital);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@camas", camas);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task ModificarHospiAsync (int idHospital, string nombre, string direccion, string telefono, int camas)
        {
            string sql = "update hospital set HOSPITAL_COD=@idhospital, NOMBRE=@nombre, DIRECCION=@direccion, TELEFONO=@telefono, NUM_CAMA=@camas where HOSPITAL_COD=@idhospital";
            this.com.Parameters.AddWithValue("@idhospital", idHospital);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@camas", camas);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteDptoAsync(int idHospital)
        {
            string sql = " delete from HOSPITAL where HOSPITAL_COD=@idhospital";
            this.com.Parameters.AddWithValue("@idhospital", idHospital);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
