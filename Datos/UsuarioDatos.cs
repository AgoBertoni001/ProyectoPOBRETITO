using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Comun.Cache;

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
    }
}
