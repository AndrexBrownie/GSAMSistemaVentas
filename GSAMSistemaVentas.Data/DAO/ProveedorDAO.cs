using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Data
{
   public class ProveedorDAO
    {
        public List<Proveedor> Proveedor_Select_simple()
        {
            //conexion a la BD
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                //Creamos un comando y la configuramos para la ejecucion de la consulta
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Proveedor_Select_simple";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Ejecutamos el comando y guardamos los datos en el contenedor datareader
                var reader = cmd.ExecuteReader();

                //Creamos una lista de objetos Proveedores vacia
                var lista = new List<Proveedor>();

                //Transferimos los registros del reader hacia la lista de Proveedores
                while (reader.Read())
                {
                    lista.Add(new Proveedor
                    {
                        ProveedorID = (int)reader["ProveedorID"],
                        RazonSocial = reader["RazonSocial"].ToString(),
                    });
                }

                return lista;
            }
        }
        public List<Proveedor> GetAll(bool estado)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Proveedor_getAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estado", estado);

                var reader = cmd.ExecuteReader();

                var lista = new List<Proveedor>();

                while (reader.Read())
                {
                    lista.Add(new Proveedor
                    {
                        ProveedorID = (int)reader["ProveedorID"],
                        RazonSocial = reader["RazonSocial"].ToString(),
                        RUC = reader["RUC"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telf = reader["Telf"].ToString(),
                        Mail = reader["Mail"].ToString(),
                        Estado = (bool)reader["Estado"]
                    });
                }

                return lista;
            }
        }
        public int Insert(Proveedor obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Proveedor_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RazonSocial", obj.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", obj.RUC);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Telf", obj.Telf);
                cmd.Parameters.AddWithValue("@Mail", obj.Mail);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
        public int Update(Proveedor obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Proveedor_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RazonSocial", obj.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", obj.RUC);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Telf", obj.Telf);
                cmd.Parameters.AddWithValue("@Mail", obj.Mail);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@ProveedorID", obj.ProveedorID);

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
                cmd.CommandText = "usp_Proveedor_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", id);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
    }
}
