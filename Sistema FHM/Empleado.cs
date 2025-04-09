using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FHM
{
    public class Empleado
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rfc { get; set; }
        public long Telefono { get; set; }
        public long Tarjeta { get; set; }
        public float SueldoBase { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }
        public string Horario { get; set; }
        public string Contraseña { get; set; }
        public float HorasTrabajadas { get;  set; }
        public float HorasExtra { get;  set; }
        public float HorasACumplir { get;  set; }
        public float PagoPorHora { get;  set; }
        public float Bonos { get;  set; }
    }
}
