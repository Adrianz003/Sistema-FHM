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
        //private Timer timer; // Timer para actualizar la fecha
        public RegistroAsistencia()
        {
            InitializeComponent();

            this.Load += RegistroAsistencia_Load;
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
            cargarAsistenciaPorFecha(fechaSeleccionada);
        }

        private void cargarAsistenciaPorFecha(string fecha)
        {
            dgvAsistencia.Rows.Clear();
            dgvAsistencia.Refresh();

            fecha = DateTime.ParseExact(fecha, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            List<Asistencia> asistencias = new EmpleadoConsultas().obtenerAsistenciaPorFecha(fecha);

            foreach (var asistencia in asistencias)
            {
                // Determina si asistió (✔) o no (✘) basado en la hora de check-in
                string simboloAsistencia = asistencia.HoraEntrada != default(TimeSpan) ? "✔" : "✘";

                dgvAsistencia.Rows.Add(
                    asistencia.Fecha, // ID de asistencia
                    asistencia.IdEmpleado,
                    asistencia.Nombre,
                    simboloAsistencia, // Columna de asistencia
                    asistencia.HoraEntrada,
                    asistencia.HoraSalida
                );
            }
        }

        private void RegistroAsistencia_Load(object sender, EventArgs e)
        {
            // Obtener las fechas de la base de datos
            List<string> fechas = new EmpleadoConsultas().obtenerFechasDeAsistencias();

            // Limpiar y cargar las fechas en el ComboBox
            comboBox1.Items.Clear();
            foreach (var fecha in fechas)
            {
                comboBox1.Items.Add(fecha);
            }

            // Seleccionar la primera fecha si hay elementos
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

    }
}
