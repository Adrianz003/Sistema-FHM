using Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Sistema_FHM.MenuPrincipal.Menu;


namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados
{
    public partial class MenuEmpleados: Form
    {
        Menu menuApp;
        private List<Empleado> mEmpleados;
        private EmpleadoConsultas mEmpleadoConsultas;
        RegistroAsistencia asistencia = new RegistroAsistencia();
        MenuGestionEmple gestionEmpleado = new MenuGestionEmple();


        public MenuEmpleados(Menu formMenu)
        {
            InitializeComponent();
            mEmpleados = new List<Empleado>();
            mEmpleadoConsultas = new EmpleadoConsultas();
            menuApp = formMenu;

            cargarProductos();

            gestionEmpleado.FormClosed += new FormClosedEventHandler(GestionEmpleado_FormClosed);
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

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {}

        private void salir_Click(object sender, EventArgs e)
        {
            menuApp.Show();
            this.Close();
        }

        private void registroAsistencia_Click(object sender, EventArgs e)
        {
            asistencia.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gestionEmpleado == null || gestionEmpleado.IsDisposed)
            {
                gestionEmpleado = new MenuGestionEmple();
            }
            gestionEmpleado.Show();
            this.Hide();
        }
        private void GestionEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
