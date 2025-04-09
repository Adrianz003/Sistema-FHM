using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_FHM.MenuPrincipal.Gestion_Empleados.AdministrarEmpleados;


namespace Sistema_FHM.MenuPrincipal.Calcular_Nomina
{
    public partial class MenuNominas: Form
    {
        private List<Empleado> mEmpleados;
        private EmpleadoConsultas mEmpleadoConsultas;
        public MenuNominas()
        {
            InitializeComponent();
            mEmpleados = new List<Empleado>();
            mEmpleadoConsultas = new EmpleadoConsultas();

            cargarProductos();

        }
        private void cargarProductos(string filtro = "")
        {
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            mEmpleados.Clear();
            mEmpleados = mEmpleadoConsultas.getEmpleado(filtro);

            for (int i = 0; i < mEmpleados.Count; i++)
            {
                dgvEmpleados.RowTemplate.Height = 50;
                dgvEmpleados.Rows.Add(
                    mEmpleados[i].Id,
                    mEmpleados[i].Nombre,
                    mEmpleados[i].Rol,
                    mEmpleados[i].SueldoBase,
                    mEmpleados[i].HorasTrabajadas,
                    mEmpleados[i].HorasExtra,
                    mEmpleados[i].HorasACumplir,
                    mEmpleados[i].PagoPorHora,
                    mEmpleados[i].Bonos);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
