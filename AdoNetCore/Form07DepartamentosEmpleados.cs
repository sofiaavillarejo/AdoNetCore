using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Repositories;

namespace AdoNetCore
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;
        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDptos();
        }
        public async void LoadDptos()
        {
            List<string> dptos = await this.repo.GetNombresDptosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string nombre in dptos)
            {
                this.lstDepartamentos.Items.Add(nombre);
            }

        }

        public async void LoadEmpleados()
        {
            string numDpto = this.lstDepartamentos.SelectedItem.ToString().Split('-')[0].Trim();
            List<string> empleados = await this.repo.GetNombreEmpleadoAsync(numDpto);
            this.lstEmpleados.Items.Clear();
            foreach (string emple in empleados)
            {
                this.lstEmpleados.Items.Add(emple);
            }

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstEmpleados.SelectedIndex != -1)
            {
                string apeEmp = this.lstEmpleados.SelectedItem.ToString();
                await this.repo.DeleteEmpleadoAsync(apeEmp);
            }
                this.LoadEmpleados();
        }

        private async void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstDepartamentos.SelectedIndex != -1)
            {
                string numDpto = this.lstDepartamentos.SelectedItem.ToString().Split('-')[0].Trim();
                List<string> empleados = await this.repo.GetNombreEmpleadoAsync(numDpto);

                this.lstEmpleados.Items.Clear();
                foreach (string empleado in empleados)
                {
                    this.lstEmpleados.Items.Add(empleado);
                }
            }
        }
    }
}
