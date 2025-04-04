using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Busqueda
{
    public partial class BusquedaEmpleados: Form
    {
        private List<Empleado> mEmpleados;
        private EmpleadoConsultas mEmpleadoConsultas;
        public BusquedaEmpleados()
        {
            InitializeComponent();
            mEmpleados = new List<Empleado>();
            mEmpleadoConsultas = new EmpleadoConsultas();

            cargarProductos();
        }

        private bool datosCorrectos()
        {
           if(txtID.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar el ID, nombre o apellido del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }   
            if (txtEmpleado.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar el(los) nombre(s) correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void cargarProductos(string filtro = "")
        {
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            mEmpleados.Clear();
            mEmpleados = mEmpleadoConsultas.getEmpleado(filtro);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
