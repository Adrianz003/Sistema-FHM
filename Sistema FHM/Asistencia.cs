using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FHM
{
    public class Asistencia
    {
       
            public int IdEmpleado { get; set; }
            public string Nombre { get; set; }
            public string Fecha { get; set; }
            public bool ConfirmarAsistencia { get; set; }
            public TimeSpan HoraEntrada { get; set; }
            public TimeSpan HoraSalida { get; set; }

    }

}
