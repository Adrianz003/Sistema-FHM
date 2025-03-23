using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_FHM.Pantallas_Menu;

namespace Sistema_FHM.MenuPrincipal
{
    public partial class Menu : Form
    {
        private InicioSesion inicioSesion;

        public Menu(InicioSesion formInicioSesion)
        {
            InitializeComponent();
            inicioSesion = formInicioSesion;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            
            inicioSesion.Show();
            this.Close();
        }
    }
}
