using Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Busqueda;
using Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Eliminar;
using Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Modificacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados
{
    public partial class MenuGestionEmple : Form
    {
        private List<Empleado> mEmpleados;
        private EmpleadoConsultas mEmpleadoConsultas;
        RegistroAsistencia asistencia = new RegistroAsistencia();
        private InsertarEmpleados insertar;
        private Modificar modificar;
        private BusquedaEmpleados busqueda = new BusquedaEmpleados(); // Asegúrate de que la clase Busqueda esté definida en el espacio de nombres correcto

        EliminarEmp eliminar;

        private DataGridViewRow filaSeleccionada;

        public MenuGestionEmple()
        {
            InitializeComponent();

            mEmpleados = new List<Empleado>();
            mEmpleadoConsultas = new EmpleadoConsultas();
            //enuApp = formMenu;

            // Ensure columns are defined before calling cargarProductos
            if (dgvEmpleados.Columns.Count == 0)
            {
                dgvEmpleados.Columns.Add("idEmpleados", "ID Empleado");
                //dgvEmpleados.Columns.Add("IdRol", "ID Rol");
                dgvEmpleados.Columns.Add("nombre", "Nombre");
                dgvEmpleados.Columns.Add("apellido", "Apellido");
                dgvEmpleados.Columns.Add("rfc", "RFC");
                dgvEmpleados.Columns.Add("telefono", "Telefono");
                dgvEmpleados.Columns.Add("tarjeta", "Tarjeta");
                dgvEmpleados.Columns.Add("sueldoBase", "Sueldo Base");
                dgvEmpleados.Columns.Add("rol", "Rol");
                dgvEmpleados.Columns.Add("estado", "Estado");
                //dgvEmpleados.Columns.Add("horario", "Horario");
            }

            cargarProductos();
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

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Insertar_Click(object sender, EventArgs e)
        {
            if (insertar == null || insertar.IsDisposed)
            {
                insertar = new InsertarEmpleados();
            }
            insertar.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Columns.Count == 0)
            {
                dgvEmpleados.Columns.Add("idEmpleados", "ID Empleado");
                dgvEmpleados.Columns.Add("IdRol", "ID Rol");
                dgvEmpleados.Columns.Add("nombre", "Nombre");
                dgvEmpleados.Columns.Add("apellido", "Apellido");
                dgvEmpleados.Columns.Add("rfc", "RFC");
                dgvEmpleados.Columns.Add("telefono", "Telefono");
                dgvEmpleados.Columns.Add("tarjeta", "Tarjeta");
                dgvEmpleados.Columns.Add("sueldoBase", "Sueldo Base");
                dgvEmpleados.Columns.Add("rol", "Rol");
                dgvEmpleados.Columns.Add("estado", "Estado");
                dgvEmpleados.Columns.Add("horario", "Horario");
            }

            cargarProductos();
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != null)
            {
                Empleado empleadoAEliminar = new Empleado
                {
                    Id = Convert.ToInt32(filaSeleccionada.Cells["idEmpleados"].Value),
                    Nombre = Convert.ToString(filaSeleccionada.Cells["nombre"].Value),
                    Rol = Convert.ToString(filaSeleccionada.Cells["rol"].Value)
                };

                if (eliminar == null || eliminar.IsDisposed)
                {
                    eliminar = new EliminarEmp(empleadoAEliminar);
                }
                eliminar.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != null)
            {
                if (modificar == null || modificar.IsDisposed)
                {
                    modificar = new Modificar();
                }
                modificar.LimpiarCampos();

                // Verificar que las columnas existan antes de acceder a ellas
                if (filaSeleccionada.Cells["idEmpleados"] != null)
                    modificar.Controls["txtId"].Text = Convert.ToString(filaSeleccionada.Cells["idEmpleados"].Value);

                if (filaSeleccionada.Cells["nombre"] != null)
                    modificar.Controls["txtNombre"].Text = Convert.ToString(filaSeleccionada.Cells["nombre"].Value);

                if (filaSeleccionada.Cells["apellido"] != null)
                    modificar.Controls["txtApellido"].Text = Convert.ToString(filaSeleccionada.Cells["apellido"].Value);

                if (filaSeleccionada.Cells["rfc"] != null)
                    modificar.Controls["txtRfc"].Text = Convert.ToString(filaSeleccionada.Cells["rfc"].Value);

                if (filaSeleccionada.Cells["telefono"] != null)
                    modificar.Controls["txtTelefono"].Text = Convert.ToString(filaSeleccionada.Cells["telefono"].Value);

                if (filaSeleccionada.Cells["tarjeta"] != null)
                    modificar.Controls["txtTarjeta"].Text = Convert.ToString(filaSeleccionada.Cells["tarjeta"].Value);

                if (filaSeleccionada.Cells["SueldoBase"] != null)
                    modificar.Controls["txtSueldoBase"].Text = Convert.ToString(filaSeleccionada.Cells["SueldoBase"].Value);

                if (filaSeleccionada.Cells["rol"] != null)
                    modificar.Controls["txtRol"].Text = Convert.ToString(filaSeleccionada.Cells["rol"].Value);

                if (filaSeleccionada.Cells["estado"] != null)
                    modificar.Controls["txtEstado"].Text = Convert.ToString(filaSeleccionada.Cells["estado"].Value);

                modificar.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el índice de la fila sea válido
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = dgvEmpleados.Rows[e.RowIndex];
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda.Show();
        }
    }
}
