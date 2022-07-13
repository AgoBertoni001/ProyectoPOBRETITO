using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Cuil { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public int IdRol { get; set; } = 1;
    }

}
