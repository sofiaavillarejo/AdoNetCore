using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AdoNetCore
{
    public partial class Form05UpdateSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form05UpdateSalas()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarSalas();
        }

        private async void CargarSalas()
        {
            string sql = "select * from SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstSalas.Items.Clear();
            
            while (await this.reader.ReadAsync())
            {
                string hospitalCod = this.reader["HOSPITAL_COD"].ToString();
                string salaCod = this.reader["SALA_COD"].ToString();
                string nombre = this.reader["NOMBRE"].ToString();
                string numCama = this.reader["NUM_CAMA"].ToString();
                this.lstSalas.Items.Add(hospitalCod + ", " + salaCod + ", " + nombre + ", " + numCama);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

        }
        private async void btnModificar_Click(object sender, EventArgs e)
        {
            string salaSeleccionada = this.lstSalas.SelectedItem.ToString().Split(',')[1].Trim();
            string nuevoNombre = this.txtNuevaSala.Text.ToString();
            string sql = "UPDATE SALA SET NOMBRE = @nuevoNombre WHERE SALA_COD = @idSala";
            SqlParameter pamNombre = new SqlParameter("@nuevoNombre", nuevoNombre);
            SqlParameter pamId = new SqlParameter("@idSala", salaSeleccionada);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamId);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            //intentar usar asincronia en las consultas tmb
            await this.cn.OpenAsync();
            int modificado = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            //eliminar los parametros siempre
            this.com.Parameters.Clear();
            MessageBox.Show("Sala modificada " + modificado);
            this.CargarSalas();
        }
    }
}
