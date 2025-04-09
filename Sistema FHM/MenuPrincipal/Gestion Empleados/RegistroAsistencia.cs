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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados
{
    public partial class RegistroAsistencia: Form
    {
        private Timer timer; // Timer para actualizar la fecha
        public RegistroAsistencia()
        {
            InitializeComponent();

            // Agregar la fecha actual al ComboBox
            comboBox1.Items.Add(DateTime.Now.ToString("yyyy-MM-dd"));
            comboBox1.SelectedIndex = 0; // Seleccionar la fecha actual por defecto

            // Configurar el Timer
            timer = new Timer();
            timer.Interval = 60000; // Verificar cada minuto
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Verificar si la fecha actual ya está en el ComboBox
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            if (!comboBox1.Items.Contains(today))
            {
                comboBox1.Items.Add(today);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1; // Seleccionar la nueva fecha
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fechaSeleccionada = comboBox1.SelectedItem.ToString();
            //cargarAsistenciaPorFecha(fechaSeleccionada);
        }

        /*private void cargarAsistenciaPorFecha(string fecha)
        {
            dgvAsistencia.Rows.Clear();
            dgvAsistencia.Refresh();

            fecha = DateTime.ParseExact(fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            List<Asistencia> asistencias = new EmpleadoConsultas().obtenerAsistenciaPorFecha(fecha);

            foreach (var asistencia in asistencias)
            {
                // Determina si asistió (✔) o no (✘) basado en la hora de check-in
                string simboloAsistencia = asistencia.HoraCheckIn.HasValue ? "✔" : "✘";

                dgvAsistencia.Rows.Add(
                    asistencia.IdEmpleado,
                    asistencia.Nombre,
                    simboloAsistencia, // Columna de asistencia
                    asistencia.Hora
                );
            }
        }*/

    }
}
