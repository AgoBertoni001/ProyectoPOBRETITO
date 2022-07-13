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
    public class UsuarioDatos : ConnectionToSql
    {
        public bool Login(string cuil, string contraseña)
        {
            using (var connection = GetConnection())
            {
                connection.Open ();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuario where cuil=@cuil and contraseña=@contraseña";
                    command.Parameters.AddWithValue("@cuil",cuil);
                    command.Parameters.AddWithValue("@contraseña",contraseña);
                    command.CommandType=System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioLoginCache.IdUsuario = reader.GetInt32(0);
                            UsuarioLoginCache.Nombre=reader.GetString(1);
                            UsuarioLoginCache.Cuil = reader.GetString(2);
                            UsuarioLoginCache.Rol=reader.GetInt32(4);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        public string InsertarUsuario(Usuario obj)
        {
            string respuesta = "";
            try
            {

                using (var connection = GetConnection())
                {
                    SqlCommand command = new SqlCommand("insertarUsuario",connection);

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                    command.Parameters.Add("@cuil", SqlDbType.VarChar).Value = obj.Cuil;
                    command.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = obj.Contraseña;
                    command.Parameters.Add("@idRol", SqlDbType.Int).Value = obj.IdRol;

                    connection.Open();
                    respuesta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";

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
