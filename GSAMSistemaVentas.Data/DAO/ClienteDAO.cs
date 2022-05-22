using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Data
{
    public class ClienteDAO
    {
        public List<Cliente> GetAll(bool estado)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Cliente_getAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estado", estado);

                var reader = cmd.ExecuteReader();

                var lista = new List<Cliente>();

                while (reader.Read())
                {
                    lista.Add(new Cliente
                    {
                        ClienteID = (int)reader["ClienteID"],
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        TipoDocumento = reader["TipoDocumento"].ToString(),
                        NumDoc = reader["NumDoc"].ToString(),
                        RazonSocial = reader["RazonSocial"].ToString(),
                        RUC = reader["RUC"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Estado = (bool)reader["Estado"]
                    });
                }

                return lista;
            }
        }
        public int Insert(Cliente obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Cliente_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocumentoID", obj.DocumentoID);
                cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", obj.Apellidos);
                cmd.Parameters.AddWithValue("@NumDoc", obj.NumDoc);
                cmd.Parameters.AddWithValue("@RazonSocial", obj.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", obj.RUC);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }

        public int Update(Cliente obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Cliente_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocumentoID", obj.DocumentoID);
                cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", obj.Apellidos);
                cmd.Parameters.AddWithValue("@NumDoc", obj.NumDoc);
                cmd.Parameters.AddWithValue("@RazonSocial", obj.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", obj.RUC);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@ClienteID", obj.ClienteID);

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
                cmd.CommandText = "usp_Cliente_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", id);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
    }
}
