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
    public partial class Form08CrudDptos : Form
    {
        //EN ESTE EJEMPLO SI NECESITAMOS UN MODEL PARA COMUNICAR TODOS LOS DATOS D CADA DPTO
        private RepositoryDepartamentos repo;
        public Form08CrudDptos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.LoadDptos();
        }

        private async void LoadDptos()
        {
            List<Departamento> dptos = await this.repo.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (Departamento dept in dptos)
            {
                this.lstDepartamentos.Items.Add(dept.IdDepartamento + " - " + dept.Nombre + " - " + dept.Localidad);

            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.InsertDptosAsync(id, nombre, localidad);
            this.LoadDptos();

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.UpdateDepartamentoAsync(id, nombre, localidad);
            this.LoadDptos();
        }

        private async void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteDptoAsync(id);
            this.LoadDptos();
        }
    }
}
