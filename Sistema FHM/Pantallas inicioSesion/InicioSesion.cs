using Sistema_FHM.MenuPrincipal;
using Sistema_FHM.Pantallas_Menu;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Menu = Sistema_FHM.MenuPrincipal.Menu;


namespace Sistema_FHM
{
    public partial class InicioSesion : Form
    {
        private Error_InicioSesion error_InicioSesion = new Error_InicioSesion(); Inicio_Exitoso inicio_Exitoso = new Inicio_Exitoso(); Menu menu;
 
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

            if (reader.Read())
            {
                if (inicio_Exitoso == null || inicio_Exitoso.IsDisposed)
                {
                    inicio_Exitoso = new Inicio_Exitoso();
                }
                inicio_Exitoso.Show();
                inicio_Exitoso.StartTimer();

                if (menu == null || menu.IsDisposed)
                {
                    menu = new Menu(this); // Pasamos el formulario actual como referencia
                }
                menu.Show();
                this.Hide(); // Oculta InicioSesion pero no lo cierra.
            }
            else
            {
                if (error_InicioSesion == null || error_InicioSesion.IsDisposed)
                {
                    error_InicioSesion = new Error_InicioSesion();
                }
                error_InicioSesion.Show();
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