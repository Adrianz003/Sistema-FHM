using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados.Modificacion
{
    public partial class ModificacionCorrecta: Form
    {
        public ModificacionCorrecta(string empleadoInfo, string modificaciones)
        {
            InitializeComponent();
            lblEmpleadoInfo.Text = empleadoInfo;
            lblModificaciones.Text = modificaciones;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
