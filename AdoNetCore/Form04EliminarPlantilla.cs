﻿using System;
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
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarPlantilla();
        }

        private void CargarPlantilla()
        {
            string sql = "select * from PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstTrabajadores.Items.Clear();
            while (this.reader.Read())
            {
                string id = this.reader["EMPLEADO_NO"].ToString();
                string ape = this.reader["APELLIDO"].ToString();
                this.lstTrabajadores.Items.Add(id + " - " + ape);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "delete from PLANTILLA where EMPLEADO_NO=" + this.txtIdEmpleado.Text;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int trabajadorEliminado = this.com.ExecuteNonQuery();
            this.cn.Close();
            MessageBox.Show("Trabajador eliminado " + trabajadorEliminado);
            this.CargarPlantilla();
        }
    }
}
