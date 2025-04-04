using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Insercion
{
    public partial class InsercionCorrecta: Form
    {
        public InsercionCorrecta()
        {
            InitializeComponent();
        }

        public InsercionCorrecta(int idEmpleado, string nombreEmpleado)
        {
            InitializeComponent();
            //lblIdEmpleado.Text = "ID: " + idEmpleado;
            lblNombreEmpleado.Text = "Nombre del empleado: " + nombreEmpleado;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
