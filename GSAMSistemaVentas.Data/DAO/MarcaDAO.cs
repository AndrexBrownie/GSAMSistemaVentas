using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Data
{
   public class MarcaDAO
    {
        public List<Marca> Marca_Select_simple()
        {
            //conexion a la BD
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                //Creamos un comando y la configuramos para la ejecucion de la consulta
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Marca_Select_simple";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Ejecutamos el comando y guardamos los datos en el contenedor datareader
                var reader = cmd.ExecuteReader();

                //Creamos una lista de objetos Marcas vacia
                var lista = new List<Marca>();

                //Transferimos los registros del reader hacia la lista de Marcas
                while (reader.Read())
                {
                    lista.Add(new Marca
                    {
                        MarcaID = (int)reader["MarcaID"],
                        Nombres = reader["Nombres"].ToString(),
                    });
                }

                return lista;
            }
        }
        public List<Marca> GetAll(bool estado)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Marca_getAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estado", estado);

                var reader = cmd.ExecuteReader();

                var lista = new List<Marca>();

                while (reader.Read())
                {
                    lista.Add(new Marca
                    {
                        MarcaID = (int)reader["MarcaID"],
                        Nombres = reader["Nombres"].ToString(),
                        Estado = (bool)reader["Estado"]
                    });
                }

                return lista;
            }
        }

        public int Insert(Marca obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Marca_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
        public int Update(Marca obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Marca_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@MarcaID", obj.MarcaID);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
        public int Delete(int id)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Marca_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MarcaID", id);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
    }
}
