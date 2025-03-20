using Sistema_FHM.MenuPrincipal;
using Sistema_FHM.MenuPrincipal.Gestion_Empleados;
using Sistema_FHM.Pantallas_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace Sistema_FHM
{
    public partial class Menú : Form
    {
        private Conexion mConexion; Error_InicioSesion error_InicioSesion = new Error_InicioSesion(); Inicio_Exitoso inicio_Exitoso = new Inicio_Exitoso();
       

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void buton_ingresar_Click(object sender, EventArgs e)
        {
           /* //string result = "";
            MySqlDataReader mySqlDataReader = null;
            string consulta = "SELECT * FROM usuarios";
            if (mConexion.getConnection() != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = mConexion.getConnection();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                ;
                if (mySqlDataReader.GetString("user") == "Gerente" || mySqlDataReader.GetString("user") == "Admin")
                {
                    inicio_Exitoso.Show();
                    this.Hide();
                }

            }

            else
            {
                error_InicioSesion.Show();
            }*/
        }

        private void boton_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}