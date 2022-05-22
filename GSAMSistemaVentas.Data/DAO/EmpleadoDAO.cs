using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Data
{
    public class EmpleadoDAO
    {
        public List<Empleado> GetAll(bool estado)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Empleado_getAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estado", estado);

                var reader = cmd.ExecuteReader();

                var lista = new List<Empleado>();

                while (reader.Read())
                {
                    lista.Add(new Empleado
                    {
                        EmpleadoID= (int)reader["EmpleadoID"],
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Documento = reader["Documento"].ToString(),

                        NumDoc = reader["NumDoc"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Ubigeo = reader["Ubigeo"].ToString(),
                        EmpleadoTipo = reader["EmpleadoTipo"].ToString(),
                        Estado = (bool)reader["Estado"]
                    });
                }

                return lista;
            }
        }
        public Empleado Get(int EmpleadoID)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Empleado_get";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", EmpleadoID);

                var reader = cmd.ExecuteReader();

                var lista = new List<Empleado>();

                while (reader.Read())
                {
                    lista.Add(new Empleado
                    {
                        EmpleadoID = (int)reader["EmpleadoID"],
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Documento = reader["TipoDocumento"].ToString(),

                        NumDoc = reader["NumDoc"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Ubigeo = reader["Ubigeo"].ToString(),
                        EmpleadoTipo = reader["EmpleadoTipo"].ToString(),

                        Estado = (bool)reader["Estado"]
                    });
                }

                return lista[0];
            }
        }

        public int Insert(Empleado obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Empleado_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocumentoID", obj.DocumentoID);
                cmd.Parameters.AddWithValue("@EmpleadoTipoID", obj.EmpleadoTipoID);
                cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", obj.Apellidos);
                cmd.Parameters.AddWithValue("@NumDoc", obj.NumDoc);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Ubigeo", obj.Ubigeo);;
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
        public int Update(Empleado obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Empleado_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocumentoID", obj.DocumentoID);
                cmd.Parameters.AddWithValue("@EmpleadoTipoID", obj.EmpleadoTipoID);
                cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", obj.Apellidos);
                cmd.Parameters.AddWithValue("@NumDoc", obj.NumDoc);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Ubigeo", obj.Ubigeo); ;
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@EmpleadoID", obj.EmpleadoID);

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
                cmd.CommandText = "usp_Empleado_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", id);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
    }
}
