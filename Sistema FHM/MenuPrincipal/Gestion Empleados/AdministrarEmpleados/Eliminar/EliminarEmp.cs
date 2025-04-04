using Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Insercion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Eliminar
{
    public partial class EliminarEmp: Form
    {
        private Empleado mEmpleado;
        EliminacionCorrecta mEliminacionCorrecta;

        public EliminarEmp(Empleado empleado)
        {
            InitializeComponent();
            mEmpleado = empleado;
            lblEmpleado.Text = $"ID: {mEmpleado.Id}, Nombre: {mEmpleado.Nombre}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpleadoConsultas.eliminarEmpleado(mEmpleado))
            {
                mEliminacionCorrecta = new EliminacionCorrecta();
                mEliminacionCorrecta.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
