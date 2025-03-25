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


        public MenuEmpleados(Menu formMenu)
        {
            InitializeComponent();
            mEmpleados = new List<Empleado>();
            mEmpleadoConsultas = new EmpleadoConsultas();
            menuApp = formMenu;

            cargarProductos();

        }

        private void cargarProductos(string filtro = "")
        {
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            mEmpleados.Clear();
            mEmpleados = mEmpleadoConsultas.getEmpleado(filtro);

            for(int i = 0; i < mEmpleados.Count; i++)
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
                    mEmpleados[i].Rol);
            }


        }

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuApp.Show();
            this.Close();
        }

        private void registroAsistencia_Click(object sender, EventArgs e)
        {
            registroAsistencia.Show();
        }
    }
}
