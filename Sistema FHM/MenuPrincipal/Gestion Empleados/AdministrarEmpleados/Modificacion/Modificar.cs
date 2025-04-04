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

namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Modificacion
{
    public partial class Modificar: Form
    {
        private Empleado mEmpleado;

        private Dictionary<string, float> rolesSalarios;
        private const int LongitudTelefono = 10;
        private const int LongitudRFC = 13;
        private const int LongitudTarjeta = 16;
        public Modificar()
        {
            InitializeComponent();
            InicializarRolesSalarios();
            mEmpleado = new Empleado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosEmpleados();

            if (EmpleadoConsultas.modificarEmpleado(mEmpleado))
            {
                string empleadoInfo = $"ID: {mEmpleado.Id}";
                string modificaciones = $"Nombre: {mEmpleado.Nombre} \nApellido: {mEmpleado.Apellido} \nRFC: {mEmpleado.Rfc} \nTeléfono: {mEmpleado.Telefono} \nTarjeta: {mEmpleado.Tarjeta} \nSueldo Base: {mEmpleado.SueldoBase} \nRol: {mEmpleado.Rol} \nEstado: {mEmpleado.Estado}";

                //MessageBox.Show("Empleado modificado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ModificacionCorrecta modificado = new ModificacionCorrecta(empleadoInfo, modificaciones);
                modificado.Show();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool datosCorrectos()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar el(los) nombre(s) correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtApellido.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar los apellidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtRol.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtRfc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar el RFC del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtRfc.Text.Trim().Length != LongitudRFC)
            {
                MessageBox.Show($"El RFC debe tener {LongitudRFC} caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTelefono.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar el teléfono del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTelefono.Text.Trim().Length != LongitudTelefono)
            {
                MessageBox.Show($"El teléfono debe tener {LongitudTelefono} dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTarjeta.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar la tarjeta del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTarjeta.Text.Trim().Length != LongitudTarjeta)
            {
                MessageBox.Show($"La tarjeta debe tener {LongitudTarjeta} dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSueldoBase.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de ingresar el sueldo base ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtEstado.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de seleccionar un horario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txtTelefono.Text.Trim(), out double tel))
            {
                MessageBox.Show("El teléfono debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txtTarjeta.Text.Trim(), out double tarjeta))
            {
                MessageBox.Show("La tarjeta debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!float.TryParse(txtSueldoBase.Text.Trim(), out float sueldo))
            {
                MessageBox.Show("El sueldo base debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
         
            return true;
        }
        private void cargarDatosEmpleados()
        {
            mEmpleado.Id = getEmpleadoIfExiste();
            mEmpleado.Nombre = txtNombre.Text.Trim();
            mEmpleado.Apellido = txtApellido.Text.Trim();
            mEmpleado.Rfc = txtRfc.Text.Trim();
            mEmpleado.Telefono = long.Parse(txtTelefono.Text.Trim());
            mEmpleado.Tarjeta = long.Parse(txtTarjeta.Text.Trim());
            mEmpleado.Rol = txtRol.Text.Trim();
            mEmpleado.SueldoBase = ObtenerSueldoBase(mEmpleado.Rol);

            mEmpleado.Estado = txtEstado.Text.Trim();
            //mEmpleado.Horario = txtHorario.Text.Trim();
            //mEmpleado.Contraseña = txtContraseña.Text.Trim();

        }
        private int getEmpleadoIfExiste()
        {
            if (!txtId.Text.Trim().Equals("") && int.TryParse(txtId.Text.Trim(), out int id))
            {
                return id;
            }
            else
            {
                return -1;
            }
        }

        private void InicializarRolesSalarios()
        {
            rolesSalarios = new Dictionary<string, float>
            {
                { "Gerente General", 50000f },
                { "Administrador de Fábrica", 50000f },
                { "Encargado: Nieves", 30000f },
                {"Encargado: Paletas", 30000f},
                {"Encargado: Aguas", 30000f},
                {"Encargado: Sucursal", 30000f},
                {"Chofer", 5000f},
                {"Empleado: Nieves", 2000f},
                {"Empleado: Paletas", 2000f},
                {"Empleado: Aguas", 2000f},
                {"Empleado: Sucursal", 2000f}
             // Agrega más roles y salarios según sea necesario
            };
        }
        private float ObtenerSueldoBase(string rol)
        {
            if (rolesSalarios.TryGetValue(rol, out float sueldo))
            {
                return sueldo;
            }
            else
            {
                MessageBox.Show("Rol no encontrado. Favor de ingresar un rol válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0f;
            }
        }
        private void txtRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rol = txtRol.SelectedItem.ToString();
            txtSueldoBase.Text = ObtenerSueldoBase(rol).ToString();

           /* if (rol == "Administrador de Fábrica" || rol == "Gerente General")
            {
                txtContraseña.Enabled = true;
                txtConfirmar.Enabled = true;
            }
            else
            {
                txtContraseña.Enabled = false;
                txtConfirmar.Enabled = false;
            }*/
        }
        public void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtRfc.Text = "";
            txtTelefono.Text = "";
            txtTarjeta.Text = "";
            txtSueldoBase.Text = "";
            txtRol.Text="";
            txtEstado.Text = "";

        }
    }
}
