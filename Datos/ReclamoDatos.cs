using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Comun.Cache;
using System.Data;
using Comun;

namespace Datos
{
    public class ReclamoDatos: ConnectionToSql
    {
        public string InsertarReclamo(Reclamo obj)
        {
            string respuesta = "";
            try
            {

                using (var connection = GetConnection())
                {
                    SqlCommand command = new SqlCommand("insertarReclamo", connection);

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@estado", SqlDbType.VarChar).Value = obj.Estado;
                    command.Parameters.Add("@fecha", SqlDbType.VarChar).Value = obj.Fecha;
                    command.Parameters.Add("@hora", SqlDbType.VarChar).Value = obj.Hora;
                    command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = obj.IdUsuario;
                    command.Parameters.Add("@idIncidente", SqlDbType.Int).Value = obj.IdIncidente;
                    command.Parameters.Add("@idCalle", SqlDbType.Int).Value = obj.IdCalle;

                    connection.Open();
                    respuesta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo guardar el Reclamo";

                }

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;
        }
    }
}
