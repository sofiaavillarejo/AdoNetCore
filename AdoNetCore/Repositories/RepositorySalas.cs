using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositorySalas
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositorySalas()
        {
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetNombresSalaAsync()
        {
            string sql = "select distinct NOMBRE from SALA";
            this.com.Connection = this.cn;
            //se pone asi con el system porque no esta importado el using y se añade aqui automaticamente asi
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            //NECESITAMOS CREAR EL OBJETO QUE VAYAMOS A DEVOLVER
            List<string> salas = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                salas.Add(nombre);
            }
            //liberar los recursos
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            //devolvemos las salas
            return salas;
        }

        public async Task UpdateNombreSalaAsync(string oldName, string newName)
        {
            string sql = "update SALA set NOMBRE=@nuevonombre " + "where NOMBRE=@antiguonombre";
            SqlParameter pamNewName = new SqlParameter("@nuevonombre", newName);
            //añadimos el parametro a la collecion del parametro
            this.com.Parameters.Add(pamNewName);
            SqlParameter pamOldName = new SqlParameter("@antiguonombre", oldName);
            this.com.Parameters.Add(pamOldName);
            //configuramos el comando
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            //ejecutamos la consulta
            await this.com.ExecuteNonQueryAsync();
            //cerrar la conexion
            await this.cn.CloseAsync();
            //IMPORTANTE! LIMPIAR LOS PARAMETROS DEL COMANDO
            this.com.Parameters.Clear();
        }
    }
}
