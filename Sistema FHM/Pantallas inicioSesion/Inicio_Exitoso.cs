using System;
using System.Windows.Forms;

namespace Sistema_FHM.Pantallas_Menu
{
    public partial class Inicio_Exitoso : Form
    {
        //private Timer timer;

        public Inicio_Exitoso()
        {
            InitializeComponent();
        }

        /*
        public void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 3000; // Tiempo en milisegundos (5000 ms = 5 segundos)
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Detiene el timer y cierra el formulario
            timer.Stop();
            MessageBox.Show("El formulario se cerrará ahora.");
            this.Close();
        }*/
    }
}
