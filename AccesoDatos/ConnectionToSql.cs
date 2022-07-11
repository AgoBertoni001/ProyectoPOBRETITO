using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{

    public abstract class ConnectionToSql 
    //solo se usa como clase base
    {
        private readonly string connectionString;//para la cadena de conexion
        public ConnectionToSql()
        {
            connectionString = "Server=DESKTOP-F1AHD1I\\ESCDIRECTASQL;DataAase=POBRETITO;integrated security = True"; //cadena de conexion
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}