using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

#region STORED PROCEDURES
//create procedure SP_ALL_DEPARTAMENTOS
//as
// select * FROM DEPT
//go

    //create procedure SP_INSERT_DPTO (@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
    //as
	   // insert into DEPT values (@numero, @nombre, @localidad) 
    //go

    //no aceptar la localidad teruel
    //alter procedure SP_INSERT_DPTO (@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
    //as
    // if (@localidad = 'TERUEL')
    // begin
    //  print 'TERUEL NO EXISTE'
    // end
    // begin
    //  insert into DEPT values (@numero, @nombre, @localidad) 
    // end
    //go
#endregion

namespace AdoNetCore
{
    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

            //recuperamos el evento de mensajes de la conexion
            this.cn.InfoMessage += Cn_InfoMessage;
            this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensaje.Text = e.Message;
        }

        public async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                string num = this.reader["DEPT_NO"].ToString();
                this.lstDepartamentos.Items.Add(num + " - " + nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        //QUITAMOS EL ASYNC DE LOS METODOS PARA PODER VER EL MENSAJE DEL SERVIDOR
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //limpiar el label de mensajes del servidor
            this.lblMensaje.Text = "";
            int numero = int.Parse(this.txtNumero.Text.ToString());
            string nombre = this.txtNombre.Text.ToString();
            string localidad = this.txtLocalidad.Text.ToString();
            string sql = "SP_INSERT_DPTO";
            this.com.Parameters.AddWithValue("@numero", numero);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.cn.Open();
            int insertados =  this.com.ExecuteNonQuery();
             this.cn.Close();
            this.com.Parameters.Clear();
             //this.LoadDepartamentos();
            MessageBox.Show("Dptos insertados" + insertados);

        }
    }
}
