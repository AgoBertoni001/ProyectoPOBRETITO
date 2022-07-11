using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Cache;


namespace Dominio
{
    public class UsuarioDominio
    {
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        public bool Login(string cuil, string contraseña)
        {
            return usuarioDatos.Login(cuil, contraseña);

        }
        
    }
}
