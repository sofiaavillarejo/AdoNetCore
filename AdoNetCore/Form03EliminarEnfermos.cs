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
    public partial class Form03EliminarEnfermos : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form03EliminarEnfermos()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            string sql = "select * from ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string ape = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + ape);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //USO DE PARAMETROS VAMOS A MODIFCAR
            //DEBEMOS INDICAR EL TIPO DE DATOS A ENVIAR COMO PARAMETRO
            //INSCRIPCION ES UN INT, POR LO QUE DEBEMOS CASTEARLO
            int inscripcion = int.Parse(this.txtInscripcion.Text);
            //string sql = "delete from ENFERMO where INSCRIPCION=" + this.txtInscripcion.Text;
            string sql = "delete from ENFERMO where INSCRIPCION=@inscripcion";
            //CREAMOS EL PARÁMETRO PARA LA INSCRIPCION
            SqlParameter pamInscripcion = new SqlParameter("@inscripcion", inscripcion);
            this.com.Parameters.Add(pamInscripcion);

            //ESTO DE AQUI SOBRA SI LO METEMOS AL DECLARAR EL PAMINSCRIPCION
            ////pamInscripcion.ParameterName = "@inscripcion";
            ////Value debe ser el mismo tipo que el parametro (int)
            //pamInscripcion.Value = inscripcion;
            //pamInscripcion.DbType = DbType.Int32;
            ////Direction indica si el parametro es entrada o salida
            ////por defecto es Input
            //pamInscripcion.Direction = ParameterDirection.Input;
            ////añadimos el parametro al command
            //this.com.Parameters.Add(pamInscripcion);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            //eliminar los parametros siempre
            this.com.Parameters.Clear();
            MessageBox.Show("Enfermos eliminados " + eliminados);
            this.CargarEnfermos();
        }

        private void lstEnfermos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
