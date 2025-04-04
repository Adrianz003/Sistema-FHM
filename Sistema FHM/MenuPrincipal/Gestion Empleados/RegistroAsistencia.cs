using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_FHM.MenuPrincipal.Gestion_Empleados;

namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados
{
    public partial class RegistroAsistencia: Form
    {
        // private ConexionMysql conexionMysql;
        //private List<Asistencia> mAsistencias;
        //MenuEmpleados menuEmpleados = new MenuEmpleados();
        public RegistroAsistencia()
        {
           // conexionMysql = new ConexionMysql();
           // mAsistencias = new List<Asistencia>();
           InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            //menuEmpleados.Show();
            this.Close();
        }

    }
}
