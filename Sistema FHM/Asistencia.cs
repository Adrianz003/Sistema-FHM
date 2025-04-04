using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FHM
{
    class Asistencia
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; } 
        public float HorasTrabajadas { get; set; }
        public string NombreCompleto { get; set; }

    }
}
