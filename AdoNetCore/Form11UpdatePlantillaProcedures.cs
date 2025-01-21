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
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region STORED PROCEDURES
//create procedure SP_ALL_HOSPITALES
//as
// select * from Hospital
//go

//create procedure SP_UPDATEPLANTILLA_HOSPITAL (@nombre nvarchar(50), @incremento int)
//as
// declare @hospitalcod int
// select @hospitalcod = HOSPITAL_COD from HOSPITAL where NOMBRE=@nombre
// update PLANTILLA set SALARIO=SALARIO + @incremento where HOSPITAL_COD=@hospitalcod
// select * from PLANTILLA where HOSPITAL_COD=@hospitalcod
//go


//create procedure SP_MOSTRAR_PLANTILLA (@hospital nvarchar(50)) 
//as
	// BEGIN
		//  DECLARE @COD INT;
//SELECT @COD = HOSPITAL_COD
		//  FROM HOSPITAL
		//  WHERE NOMBRE = @HOSPITAL;
//IF @COD IS NOT NULL
		//  BEGIN
			//   SELECT APELLIDO
			//   FROM PLANTILLA
			//   WHERE HOSPITAL_COD = @COD;
//END
//END
//go

//exec SP_MOSTRAR_PLANTILLA 'La Paz'




#endregion

namespace AdoNetCore
{
    public partial class Form11UpdatePlantillaProcedures : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form11UpdatePlantillaProcedures()
        {
            InitializeComponent();
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadHospitales();

        }
        public async void LoadHospitales()
        {
            string sql = "SP_ALL_HOSPITALES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbHospitales.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnIncrementar_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);
            string sql = "SP_UPDATEPLANTILLA_HOSPITAL";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int afectados = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            await this.LoadPlantilla(nombre);
            MessageBox.Show("Registros modificados" + afectados);

            //si ejecuto executenonquery -> devuelve el numero de registros modifcados
            //si ejecuto el execute reader -> los registros
            //while (await this.reader.ReadAsync())
            //{
            //    string apellido = this.reader["APELLIDO"].ToString();
            //    string salario = this.reader["SALARIO"].ToString();
            //    this.lstPlantilla.Items.Add(apellido + " - " + salario);
            //}
        }

        public async Task LoadPlantilla(string nombre)
        {
            //si lo voy a llamar con un await -> Task
            string sql = "SP_MOSTRAR_PLANTILLA";
            this.com.Parameters.AddWithValue("@hospital", nombre);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstPlantilla.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " - " + salario);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbHospitales.SelectedIndex != -1)
            {
                string nombre = this.cmbHospitales.SelectedItem.ToString();
                await this.LoadPlantilla(nombre);
            }
        }
    }
}
