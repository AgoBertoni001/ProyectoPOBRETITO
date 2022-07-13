using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Cache;
using Comun;


namespace Dominio
{
    public class UsuarioDominio
    {
        
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        public bool Login(string cuil, string contraseña)
        {
            return usuarioDatos.Login(cuil, contraseña);

        }

        public string InsertarUsuario(string nombre, string cuil, string contraseña, int idRol)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = nombre;
            usuario.Cuil=cuil;
            usuario.Contraseña = contraseña;
            usuario.IdRol = idRol;

            return usuarioDatos.InsertarUsuario(usuario);

        }



    }
}
