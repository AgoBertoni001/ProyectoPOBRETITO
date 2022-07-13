using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Reclamo
    {
        public string Estado { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int IdUsuario { get; set; }
        public int IdIncidente { get; set; }
        public int IdCalle { get; set; }
    }
}
