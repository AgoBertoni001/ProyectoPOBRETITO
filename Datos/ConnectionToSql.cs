using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;//para la cadena de conexion
        SqlCommand command =new SqlCommand();

        public ConnectionToSql()
        {
            connectionString = "Server=DESKTOP-F1AHD1I\\ESCDIRECTASQL;DataBase=POBRETITO;integrated security = True"; //cadena de conexion

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        


    }
}
    