using System.Data;

namespace GSAMSistemaVentas.Data
{
    public  interface IConnectionFactory
    {    
        IDbConnection  GetConnection { get; }
    }
}
