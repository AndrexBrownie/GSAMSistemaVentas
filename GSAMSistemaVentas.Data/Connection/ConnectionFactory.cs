using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GSAMSistemaVentas.Data
{
    public  class ConnectionFactory: IConnectionFactory
    {
       public IDbConnection GetConnection { 
            get
            {
                SqlConnection cnx = new SqlConnection();
                if (cnx == null) return null;
                cnx.ConnectionString = (ConfigurationManager.ConnectionStrings["miCadena"]).ConnectionString;
                cnx.Open();
                return cnx;
            }
        }
    }
}

