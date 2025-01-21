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

namespace AdoNetCore
{
    public partial class Form10UpdateEmpleados : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
        }
        private async Task LoadOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string ofi in oficios)
            {
                this.lstOficios.Items.Add(ofi);
            }
        }
        private async Task LoadEmpleados(string oficio)
        {
            List<string> empleados = await this.repo.GetEmpleadosOficioAsync(oficio);
            this.lstEmpleados.Items.Clear();
            foreach (string emple in empleados)
            {
                this.lstEmpleados.Items.Add(emple);
            }
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();

                DatosEmpleadosOficio datos = await this.repo.GetDatosEmpleadosOficioAsync(oficio);
                this.lblSumaSalario.Text = "Suma " + datos.SumaSalarial;
                this.lblMedia.Text = "Media " + datos.Mediasalarial;
                this.lblMaximoSalario.Text = "Maximo " + datos.MaximoSalarial;

                this.LoadEmpleados(oficio);
            }
        }

        private async void Incrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            string oldOficio = this.lstOficios.SelectedItem.ToString();
            string newOficio = this.txtOficio.Text;
            int modificados = await this.repo.UpdateEmpleadosOficio(oldOficio, newOficio, incremento);
            MessageBox.Show("modificados " + modificados);

            DatosEmpleadosOficio datos = await this.repo.GetDatosEmpleadosOficioAsync(newOficio);
            this.lblSumaSalario.Text = "Suma " + datos.SumaSalarial;
            this.lblMedia.Text = "Media " + datos.Mediasalarial;
            this.lblMaximoSalario.Text = "Maximo " + datos.MaximoSalarial;

            this.LoadOficios();        
        }
        
    }
}
