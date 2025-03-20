using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FHM
{
    class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "heladosmorelia";
        private string user = "root";
        private string password = "root";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "server=" + server + ";database=" + database + ";Uid=" + user + ";pwd=" + password + ";";
        }

        public MySqlConnection getConnection()
        {
            if(conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            return conexion;
        }
    }
}
