using GSAMSistemaVentas.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GSAMSistemaVentas.Data
{
    public class CategoriaDAO
    {
        public List<Categoria> Categoria_Select_simple()
        {
            //conexion a la BD
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                //Creamos un comando y la configuramos para la ejecucion de la consulta
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Categoria_Select_simple";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Ejecutamos el comando y guardamos los datos en el contenedor datareader
                var reader = cmd.ExecuteReader();

                //Creamos una lista de objetos Categorias vacia
                var lista = new List<Categoria>();

                //Transferimos los registros del reader hacia la lista de categorias
                while (reader.Read())
                {
                    lista.Add(new Categoria
                    {
                        CategoriaID = (int)reader["CategoriaID"],
                        Nombre = reader["Nombre"].ToString(),
                    });
                }

                return lista;
            }
        }

        public List<Categoria> GetAll(bool estado)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Categoria_getAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estado", estado);

                var reader = cmd.ExecuteReader();

                var lista = new List<Categoria>();

                while (reader.Read())
                {
                    lista.Add(new Categoria
                    {
                        CategoriaID = (int)reader["CategoriaID"],
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Estado = (bool)reader["Estado"]
                    });
                }

                return lista;
            }
        }

        public int Insert(Categoria obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Categoria_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }

        public int Update(Categoria obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Categoria_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@CategoriaID", obj.CategoriaID);

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
                cmd.CommandText = "usp_Categoria_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", id);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
    }
}
