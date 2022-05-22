using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Data
{
   public class UMedidaDAO
    {
        public List<UMedida> UMedida_Select_simple()
        {
            //conexion a la BD
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                //Creamos un comando y la configuramos para la ejecucion de la consulta
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_UMedida_Select_simple";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Ejecutamos el comando y guardamos los datos en el contenedor datareader
                var reader = cmd.ExecuteReader();

                //Creamos una lista de objetos UMedidas vacia
                var lista = new List<UMedida>();

                //Transferimos los registros del reader hacia la lista de UMedidas
                while (reader.Read())
                {
                    lista.Add(new UMedida
                    {
                        UMedidaID = (int)reader["UMedidaID"],
                        Nombre = reader["Nombre"].ToString(),
                    });
                }

                return lista;
            }
        }
        public List<UMedida> GetAll(bool estado)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_UMedida_getAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estado", estado);

                var reader = cmd.ExecuteReader();

                var lista = new List<UMedida>();

                while (reader.Read())
                {
                    lista.Add(new UMedida
                    {
                        UMedidaID = (int)reader["UMedidaID"],
                        Cod = reader["Cod"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Estado = (bool)reader["Estado"]
                    });
                }

                return lista;
            }
        }

         public int Insert(UMedida obj)
          {
              using (var cnx = new ConnectionFactory().GetConnection)
              {
                  var cmd = new SqlCommand();
                  cmd.Connection = (SqlConnection)cnx;
                  cmd.CommandText = "usp_UMedida_Insert";
                  cmd.CommandType = System.Data.CommandType.StoredProcedure;
                  cmd.Parameters.AddWithValue("@Cod", obj.Cod);
                  cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                  cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                  int rpta = cmd.ExecuteNonQuery();

                  return rpta;
              }
          }
        public int Update(UMedida obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_UMedida_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod", obj.Cod);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@UMedidaID", obj.UMedidaID);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
    }
}
