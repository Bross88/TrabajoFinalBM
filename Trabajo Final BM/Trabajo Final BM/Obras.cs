using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_BM
{
    public class Obras
    {
        public string Nombre { get; set; }
        public List<int> EntradasDisponiblesPlateaA { get; set; }
        public List<int> EntradasDisponiblesPlateaB { get; set; }
        public List<int> EntradasDisponiblesPlateaC { get; set; }
        public List<int> EntradasDisponiblesPopular { get; set; }
        public List<string> Reparto { get; set; }
        public int EntradasVendidas { get; set; }

        public DateTime FechaYHora { get; set ; }
    }


}
