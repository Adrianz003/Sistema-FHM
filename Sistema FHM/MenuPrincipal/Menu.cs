using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_FHM.MenuPrincipal.Calcular_Nomina;
using Sistema_FHM.MenuPrincipal.Gestion_Empleados;
using Sistema_FHM.Pantallas_Menu;

namespace Sistema_FHM.MenuPrincipal
{
    public partial class Menu : Form
    {
        private InicioSesion inicioSesion; MenuEmpleados menuEmpleados;
        private MenuNominas menuNominas;

        public Menu(InicioSesion formInicioSesion)
        {
            InitializeComponent();
            inicioSesion = formInicioSesion;
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnGestionEmp_Click(object sender, EventArgs e)
        {
            if(menuEmpleados == null || menuEmpleados.IsDisposed)
            {
                menuEmpleados = new MenuEmpleados(this);
            }
            menuEmpleados.Show();


        }

        private void Btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            inicioSesion.Show();
            this.Hide();
        }

        private void Btn_CNomina_Click(object sender, EventArgs e)
        {
            if (menuNominas == null || menuNominas.IsDisposed)
            {
                menuNominas = new MenuNominas();
            }
            menuNominas.Show();
            this.Hide();
        }
    }
}
