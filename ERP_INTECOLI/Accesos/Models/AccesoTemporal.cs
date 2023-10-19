using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Accesos.Models
{
    public class AccesoTemporal
    {
        public int UserID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaVinculo { get; set; }
    }
}
