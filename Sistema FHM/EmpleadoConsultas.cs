using MySql.Data.MySqlClient;
using Sistema_FHM.MenuPrincipal.Gestion_Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FHM
{
    class EmpleadoConsultas
    {
        private ConexionMysql conexionMysql;
        private List<Empleado> mEmpleados;
        public EmpleadoConsultas()
        {
            conexionMysql = new ConexionMysql();
            mEmpleados = new List<Empleado>();
        }

        public List<Empleado> getEmpleado(string filtro)
        {
            string QUERY = "SELECT * FROM empleados ";
            MySqlDataReader mReader = null;
            try
            {
                if(filtro != "")
                {
                    QUERY += "WHERE idEmpleados LIKE '%" + filtro +
                        "%'OR Rol_idRol LIKE '%" + filtro +
                        "%'OR nombre LIKE '%" + filtro + 
                        "%' OR apellido LIKE '%" + filtro + 
                        "%' OR rfc LIKE '%" + filtro + 
                        "%' OR telefono LIKE '%" + filtro + 
                        "%' OR tarjeta LIKE '%" + filtro + 
                        "%' OR sueldo_base LIKE '%" + filtro + 
                        "%' OR rol LIKE '%" + filtro + "%'";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMysql.GetConnection();
                mReader = mComando.ExecuteReader();

                Empleado mEmpleado = null;
                while (mReader.Read())
                {
                    mEmpleado = new Empleado();
                    mEmpleado.Id = mReader.GetInt16("idEmpleados");
                    mEmpleado.IdRol = mReader.GetInt16("Rol_idRol");
                    mEmpleado.Nombre = mReader.GetString("nombre");
                    mEmpleado.Apellido = mReader.GetString("apellido");
                    mEmpleado.Rfc = mReader.GetString("rfc");
                    mEmpleado.Telefono = mReader.GetInt64("telefono");
                    mEmpleado.Tarjeta = mReader.GetInt64("tarjeta");
                    mEmpleado.SueldoBase = mReader.GetFloat("sueldoBase");
                    mEmpleado.Rol = mReader.GetString("rol");
                    mEmpleados.Add(mEmpleado);

                }

                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mEmpleados;
        }
    }
}
