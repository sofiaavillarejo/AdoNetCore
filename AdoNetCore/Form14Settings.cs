using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace AdoNetCore
{
    public partial class Form14Settings : Form
    {
        public Form14Settings()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //necesitamos un constructor de configuracion (builder)
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //en este entorno, no est nativo por lo que debemos indicar de forma explicita el nombre del fichero
            //y su ubicacion (copy always que hemos configurado anteriormente)
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true); //parámetros opcionales: false es que es obligatorio, si el fichero cambia que lo recargue
            //objeto para recuperar las keys
            IConfigurationRoot configuration = builder.Build();
            //existen claves que ya vienen por defecto -> ConnectionStrings
            string connectionString = configuration.GetConnectionString("SqlTajamar");
            this.lblCadenaConexion.Text = connectionString;
            //si no es una zona conocida como Imagenes/Colores
            //los datos se recuperan en cascada con cada key y su subkey y asi
            string image1 = configuration.GetSection("Imagenes:imagen1").Value;
            string image2 = configuration.GetSection("Imagenes:imagen2").Value;
            string colorFondo = configuration.GetSection("Colores:fondo").Value;
            string colorLetra = configuration.GetSection("Colores:letra").Value;
            this.pictureBox1.Load(image1);
            this.pictureBox2.Load(image2);
            this.btnLeer.BackColor = Color.FromName(colorFondo);
            this.btnLeer.ForeColor = Color.FromName(colorLetra);
        }
    }
}
