using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Sistema_FHM
{
    class EmpleadoConsultas
    {
        ConexionMysql conexionMysql;
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
                if (filtro != "")
                {
                    QUERY += "WHERE Empleados_idEmpleados LIKE '%" + filtro +
                        "%' OR rfc LIKE '%" + filtro +
                        "%' OR telefono LIKE '%" + filtro +
                        "%' OR tarjeta LIKE '%" + filtro +
                        "%' OR sueldo_base LIKE '%" + filtro +
                        "%' OR rol LIKE '%" + filtro + "%'" +
                        "%'OR nombre LIKE '%" + filtro +
                        "%' OR apellido LIKE '%" + filtro +
                        "% OR estado LIKE '%" + filtro;
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
                    mEmpleado.Estado = mReader.GetString("estado");
                    //mEmpleado.Horario = mReader.GetString("horario");
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

        private int ObtenerIdRolPorNombre(string nombreRol)
        {
            if(string.IsNullOrEmpty(nombreRol))
            {
                throw new ArgumentException("El nombre del rol no puede ser nulo o vacío.");
            }

            string QUERY = "SELECT idRol FROM rol WHERE nombreRol = @nombreRol";

            using (var connection = conexionMysql.GetConnection())
            {
                MySqlCommand mComando = new MySqlCommand(QUERY, connection);
                mComando.Parameters.Add(new MySqlParameter("@nombreRol", nombreRol));
                object result = mComando.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    throw new Exception("El nombre del rol no existe en la tabla rol.");
                }
            }
        }

        internal static bool insertarEmpleado(Empleado mEmpleado)
        {
            EmpleadoConsultas consultas = new EmpleadoConsultas();
            mEmpleado.IdRol = consultas.ObtenerIdRolPorNombre(mEmpleado.Rol);

            string INSERT = "INSERT INTO Empleados(Rol_idRol, nombre, apellido, rfc, telefono, tarjeta, sueldoBase, rol, estado, horario) " +
                "values (@Rol_idRol, @nombre,@apellido,@rfc,@telefono,@tarjeta,@sueldoBase,@rol,@estado,@horario)";

            using (var connection = new ConexionMysql().GetConnection())
            {
                MySqlCommand mComando = new MySqlCommand(INSERT, connection);

                mComando.Parameters.Add(new MySqlParameter("@Rol_idRol", mEmpleado.IdRol));
                mComando.Parameters.Add(new MySqlParameter("@nombre", mEmpleado.Nombre));
                mComando.Parameters.Add(new MySqlParameter("@apellido", mEmpleado.Apellido));
                mComando.Parameters.Add(new MySqlParameter("@rfc", mEmpleado.Rfc));
                mComando.Parameters.Add(new MySqlParameter("@telefono", mEmpleado.Telefono));
                mComando.Parameters.Add(new MySqlParameter("@tarjeta", mEmpleado.Tarjeta));
                mComando.Parameters.Add(new MySqlParameter("@sueldoBase", mEmpleado.SueldoBase));
                mComando.Parameters.Add(new MySqlParameter("@rol", mEmpleado.Rol));
                mComando.Parameters.Add(new MySqlParameter("@estado", mEmpleado.Estado));
                mComando.Parameters.Add(new MySqlParameter("@horario", mEmpleado.Horario));

                //connection.Open();
                int result = mComando.ExecuteNonQuery();

                if (result > 0)
                {
                    // Obtener el ID del empleado insertado
                    long empleadoId = mComando.LastInsertedId;

                    if (mEmpleado.IdRol == 1 || mEmpleado.IdRol == 2)
                    {
                        string INSERTUSUARIO = "INSERT INTO Usuarios(user, password) " +
                            "values (@nombre ,@contraseña)";

                        MySqlCommand mComando2 = new MySqlCommand(INSERTUSUARIO, connection);
                        //mComando2.Parameters.Add(new MySqlParameter("@Empleados_idEmpleados", empleadoId.Id));
                        mComando2.Parameters.Add(new MySqlParameter("@nombre", mEmpleado.Nombre));
                        mComando2.Parameters.Add(new MySqlParameter("@contraseña", mEmpleado.Contraseña));

                        return mComando2.ExecuteNonQuery() > 0;
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal static bool modificarEmpleado(Empleado mEmpleado)
        {
            string UPDATE = "UPDATE Empleados SET " +
                "nombre = @nombre, " +
                "apellido=@apellido," +
                " rfc=@rfc, " +
                "telefono=@telefono, " +
                "tarjeta=@tarjeta, " +
                "sueldoBase=@sueldoBase, " +
                "rol=@rol, " +
                "estado=@estado " +
                "WHERE idEmpleados=@idEmpleado; ";

            using (var connection = new ConexionMysql().GetConnection())
            {
                MySqlCommand mComando = new MySqlCommand(UPDATE, connection);

                mComando.Parameters.Add(new MySqlParameter("@nombre", mEmpleado.Nombre));
                mComando.Parameters.Add(new MySqlParameter("@apellido", mEmpleado.Apellido));
                mComando.Parameters.Add(new MySqlParameter("@rfc", mEmpleado.Rfc));
                mComando.Parameters.Add(new MySqlParameter("@telefono", mEmpleado.Telefono));
                mComando.Parameters.Add(new MySqlParameter("@tarjeta", mEmpleado.Tarjeta));
                mComando.Parameters.Add(new MySqlParameter("@sueldoBase", mEmpleado.SueldoBase));
                mComando.Parameters.Add(new MySqlParameter("@rol", mEmpleado.Rol));
                mComando.Parameters.Add(new MySqlParameter("@estado", mEmpleado.Estado));
                mComando.Parameters.Add(new MySqlParameter("@idEmpleado", mEmpleado.Id));

                return mComando.ExecuteNonQuery() > 0;
            }
        }

        internal static bool eliminarEmpleado(Empleado mEmpleado)
        {
            EmpleadoConsultas consultas = new EmpleadoConsultas();

            string DELETE = "DELETE FROM Empleados WHERE idEmpleados=@idEmpleado;";

            using (var connection = new ConexionMysql().GetConnection())
            {
                // Verificar si el empleado existe antes de intentar eliminarlo
                string CHECK_EXISTENCE = "SELECT COUNT(*) FROM Empleados WHERE idEmpleados=@idEmpleado";
                MySqlCommand checkCommand = new MySqlCommand(CHECK_EXISTENCE, connection);
                checkCommand.Parameters.Add(new MySqlParameter("@idEmpleado", mEmpleado.Id));
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count == 0)
                {
                    throw new Exception("El empleado no existe o ya ha sido eliminado.");
                }

                MySqlCommand mComando = new MySqlCommand(DELETE, connection);
                mComando.Parameters.Add(new MySqlParameter("@idEmpleado", mEmpleado.Id));
                mComando.Parameters.Add(new MySqlParameter("@Rol_idRol", mEmpleado.IdRol));

                int result = mComando.ExecuteNonQuery();

                if (result > 0)
                {
                    mEmpleado.IdRol = consultas.ObtenerIdRolPorNombre(mEmpleado.Rol);
                    long empleadoId = mComando.LastInsertedId;

                    if (mEmpleado.IdRol == 1 || mEmpleado.IdRol == 2)
                    {
                        string DELETEUSER = "DELETE from Usuarios WHERE user = @nombre";

                        MySqlCommand mComando2 = new MySqlCommand(DELETEUSER, connection);
                        mComando2.Parameters.Add(new MySqlParameter("@nombre", mEmpleado.Nombre));
                        return mComando2.ExecuteNonQuery() > 0;
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal List<Empleado> buscarEmpleado(string filtro)
        {
            string QUERY = "SELECT * FROM empleados ";
            MySqlDataReader mReader = null;
            List<Empleado> mEmpleados = new List<Empleado>();

            try
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    QUERY += "WHERE idEmpleados LIKE @filtro OR nombre LIKE @filtro OR apellido LIKE @filtro";
                }

                using (var connection = new ConexionMysql().GetConnection())
                {
                    MySqlCommand mComando = new MySqlCommand(QUERY, connection);
                    mComando.Parameters.Add(new MySqlParameter("@filtro", "%" + filtro + "%"));
                    mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Empleado mEmpleado = new Empleado();
                        mEmpleado.Id = mReader.GetInt16("idEmpleados");
                        mEmpleado.IdRol = mReader.GetInt16("Rol_idRol");
                        mEmpleado.Nombre = mReader.GetString("nombre");
                        mEmpleado.Apellido = mReader.GetString("apellido");
                        mEmpleado.Rfc = mReader.GetString("rfc");
                        mEmpleado.Telefono = mReader.GetInt64("telefono");
                        mEmpleado.Tarjeta = mReader.GetInt64("tarjeta");
                        mEmpleado.SueldoBase = mReader.GetFloat("sueldoBase");
                        mEmpleado.Rol = mReader.GetString("rol");
                        mEmpleado.Estado = mReader.GetString("estado");
                        //mEmpleado.Horario = mReader.GetString("horario");
                        mEmpleados.Add(mEmpleado);
                    }

                    mReader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar empleados: " + ex.Message);
            }
            return mEmpleados;
        }

        /*public List<Asistencia> obtenerAsistenciaPorFecha(string fecha)
        {
            List<Asistencia> asistencias = new List<Asistencia>();
            string QUERY = "SELECT empleados_idEmpleados, nombreEmpleado, fecha, horasTrabajadas FROM asistencia WHERE fecha = @fecha";

            using (var connection = new ConexionMysql().GetConnection())
            {
                MySqlCommand command = new MySqlCommand(QUERY, connection);
                command.Parameters.Add(new MySqlParameter("@fecha", fecha));

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Asistencia asistencia = new Asistencia
                        {
                            IdEmpleado = reader.GetInt32("empleados_idEmpleados"),
                            Nombre = reader.GetString("nombre"),
                            //Fecha = reader.GetDateTime("fecha").ToString("dd-MM-yyyy"),
                            HorasTrabajadas = reader.GetInt32("horasTrabajadas")
                        };
                        asistencias.Add(asistencia);
                    }
                }
            }

            return asistencias;

        }*/

    }
}
