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
    public partial class Form01PrimerAdo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;


        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            //tras cambiar esto, da otro error porque debemos comprobar si la conexion esta abierta
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange; ;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            //este evento se ejecuta cuando la conexion cambia de estado
            this.lblMensaje.Text = "La conexión está pasando de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //si pulso el btn de conectar varias veces, salta un error porque cambia la cadena de conexion
            //entonces la priemra linea se pone al inicilaizar el component
            //this.cn.ConnectionString = this.connectionString;

            //comprobar si la conexion esta abierta
            //comprobar si el servidor esta caido
            //try
            //{
            //    if (this.cn.State == ConnectionState.Closed)
            //    {
            //        this.cn.Open();
            //    }
            //    this.lblMensaje.Text = "Conectado";
            //    this.lblMensaje.BackColor = Color.LightGreen;
            //}
            //catch (SqlException ex)
            //{
            //    this.lblMensaje.Text = ex.ToString();
            //}

            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            //this.lblMensaje.Text = "Conectado";
            this.lblMensaje.BackColor = Color.LightGreen;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //si pulso el btn de desconectar varias veces, no pasa nada
            this.cn.Close();
            //this.lblMensaje.Text = "Desconectado";
            this.lblMensaje.BackColor = Color.Red;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //consulta a realizar
            string sql = "select * from EMP";
            //configuar nuestro commad -> encargado de ejecutar las consultas
            //indicamos la conexion del comando
            this.com.Connection = this.cn;
            //tipo de consulta a realziar
            this.com.CommandType = CommandType.Text;
            //la consulta en si
            this.com.CommandText = sql;
            //aqui deberiamos abrir la conexion -> pulsar en conectar
            //es una consulta de seleccion, por lo que debemos usar el metodo ExecuteReader
            //que nos devuelve un DataReader
            this.reader = this.com.ExecuteReader();
            //ya podemos leer datos
            //empezamos leyendo la primera columna
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i); //devuleve el nombre                                          
                string tipoDato = this.reader.GetDataTypeName(i); //tipo de dato
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);
 
            }

            //LEEMOS EL PRIMER REGISTRO
            //PARA LEER DATOS USARMOS -> Read() cada vez que lo usamos, se posiviona en una fila
            //para leer datos, se usa el bucle while (filas)
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }

            //SIEMPRE DEBEMOS CERRAR TODO PARA PODER REUTILIZARLO
            this.reader.Close();
        }
    }
}
