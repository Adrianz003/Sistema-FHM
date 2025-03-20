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
using System.Drawing.Text;
namespace Sistema_FHM
{
    public partial class InicioSesion : Form
    {
        private Conexion mConexion; Error_InicioSesion error_InicioSesion = new Error_InicioSesion(); Inicio_Exitoso inicio_Exitoso = new Inicio_Exitoso();
        public InicioSesion()
        {
            InitializeComponent();
            //mConexion = new Conexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioBox.Text;
            string contraseña = ContraseñaBox.Text;

            MySqlConnection con = new MySqlConnection("server= localhost; Database=heladosmorelia; user = root; password = root "); 
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            String sql = "SELECT user, password FROM usuarios WHERE user = '" + usuario + "' AND password = '" + contraseña + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                inicio_Exitoso.Show();
                this.Hide();
            }
            else
            {
                error_InicioSesion.Show();
                //this.Hide();
            }
        }



        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}