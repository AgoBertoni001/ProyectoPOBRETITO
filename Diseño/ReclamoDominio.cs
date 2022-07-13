using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Cache;
using Comun;


namespace Diseño
{
    public class ReclamoDominio
    {
        ReclamoDatos reclamoDatos = new ReclamoDatos();
        public string InsertarReclamo(string estado, string fecha,string hora, int idUsuario, int idIncidente, int idCalle)
        {
            Reclamo reclamo = new Reclamo();
            reclamo.Estado = estado;
            reclamo.Fecha = fecha;
            reclamo.Hora = hora;
            reclamo.IdUsuario = idUsuario;
            reclamo.IdIncidente = idIncidente;
            reclamo.IdCalle = idCalle;
            
            return reclamoDatos.InsertarReclamo(reclamo);

        }
    }
}
