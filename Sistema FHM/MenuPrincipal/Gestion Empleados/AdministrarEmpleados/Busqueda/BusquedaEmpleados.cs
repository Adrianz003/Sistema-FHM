using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Busqueda
{
    public partial class BusquedaEmpleados : Form
    {
        private List<Empleado> mEmpleados;
        private EmpleadoConsultas mEmpleadoConsultas;

        public BusquedaEmpleados()
        {
            InitializeComponent();
            mEmpleados = new List<Empleado>();
            mEmpleadoConsultas = new EmpleadoConsultas();

            cargarEmpleados();

            // Agregar manejadores de eventos KeyPress
            txtID.KeyPress += new KeyPressEventHandler(txtID_KeyPress);
            txtEmpleado.KeyPress += new KeyPressEventHandler(txtEmpleado_KeyPress);
        }

        private bool datosCorrectos()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) && string.IsNullOrWhiteSpace(txtEmpleado.Text))
            {
                MessageBox.Show("Favor de ingresar el ID, nombre o apellido del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void cargarEmpleados(string filtro = "")
        {
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            mEmpleados.Clear();
            mEmpleados = mEmpleadoConsultas.buscarEmpleado(filtro);

            for (int i = 0; i < mEmpleados.Count; i++)
            {
                dgvEmpleados.RowTemplate.Height = 50;
                dgvEmpleados.Rows.Add(
                    mEmpleados[i].Id,
                    mEmpleados[i].IdRol,
                    mEmpleados[i].Nombre,
                    mEmpleados[i].Apellido,
                    mEmpleados[i].Rfc,
                    mEmpleados[i].Telefono,
                    mEmpleados[i].Tarjeta,
                    mEmpleados[i].SueldoBase,
                    mEmpleados[i].Rol,
                    mEmpleados[i].Estado);
            }
        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (datosCorrectos())
            {
                cargarEmpleados(txtEmpleado.Text.Trim());
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            cargarEmpleados(txtID.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
