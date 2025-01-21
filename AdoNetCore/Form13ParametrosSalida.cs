using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using AdoNetCore.Repositories;
using Microsoft.Data.SqlClient;



namespace AdoNetCore
{
    public partial class Form13ParametrosSalida : Form
    {
        private RepositoryParametrosOut repo;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosOut();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<string> departamentos =
                await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (string name in departamentos)
            {
                this.cmbDepartamentos.Items.Add(name);
            }
        }

        private async void btnMostrar_Click_1(object sender, EventArgs e)
        {
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            Empleado model =
                await this.repo.MostrarDatosAsync(nombre);
            this.lstEmpleados.Items.Clear();
            foreach (string ape in model.Apellidos)
            {
                this.lstEmpleados.Items.Add(ape);
            }
            this.txtSuma.Text = model.SumaSalarial.ToString();
            this.txtMedia.Text = model.MediaSalarial.ToString();
            this.txtPersonas.Text = model.Personas.ToString();
        }

        /////////////////////////////////
        //antes de llevar el codigo a repository y model
        //string sql = "SP_EMPLEADOS_DPTO_OUT";
        //string nombre = this.cmbDepartamentos.SelectedItem.ToString();
        ////PARA LOS PARAMETROS DE ENTRADA PODEMOS USAR addwithvalue, ADEMÁS ES IMPRESCINDIBLE USAR OBJETOS PARAMETER
        //this.com.Parameters.AddWithValue("@nombre", nombre);
        //SqlParameter pamSuma = new SqlParameter();
        //pamSuma.ParameterName = "@suma";
        //pamSuma.Value = 0;
        ////indicamos la direccion del parametros
        //pamSuma.Direction = ParameterDirection.Output; //de salida
        //SqlParameter pamMedia = new SqlParameter();
        //pamMedia.ParameterName = "@media";
        //pamMedia.Value = 0;
        //pamMedia.Direction = ParameterDirection.Output;
        //SqlParameter pamPersonas = new SqlParameter();
        //pamPersonas.ParameterName = "@personas";
        //pamPersonas.Value = 0;
        //pamPersonas.Direction = ParameterDirection.Output;

        //this.com.Parameters.Add(pamSuma);
        //this.com.Parameters.Add(pamMedia);
        //this.com.Parameters.Add(pamPersonas);

        //this.com.CommandType = CommandType.StoredProcedure;
        //this.com.CommandText = sql;
        //await this.cn.OpenAsync();
        //this.reader = await this.com.ExecuteReaderAsync();
        //this.lstEmpleados.Items.Clear();
        //while (await this.reader.ReadAsync())
        //{
        //    string apellido = this.reader["APELLIDO"].ToString();
        //    this.lstEmpleados.Items.Add(apellido);
        //}

        //await this.reader.CloseAsync();
        ////dibujamos los parametros -> a pesar de que los param tiene valor, no nos devuelven info
        ////es porqe la info de los param siempre se deben capturar de dos formas posibles
        //// 1. si la consulta del procedure es select -> se capturan los parametros después de cerrar el reader
        //// 2. si la consulta es de accion -> se capturan despues de cerrar la conexion
        //this.txtSuma.Text = pamSuma.Value.ToString();
        //this.txtMedia.Text = pamMedia.Value.ToString();
        //this.txtPersonas.Text = pamPersonas.Value.ToString();

        //await this.cn.CloseAsync();
        //this.com.Parameters.Clear();

        //}
    }
}
