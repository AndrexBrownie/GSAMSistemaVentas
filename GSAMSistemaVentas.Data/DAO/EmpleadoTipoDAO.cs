using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Data
{
  public  class EmpleadoTipoDAO
    {
        public List<EmpleadoTipo> EmpleadoTipo_Select_simple()
        {
            //conexion a la BD
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                //Creamos un comando y la configuramos para la ejecucion de la consulta
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_EmpleadoTipo_Select_simple";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Ejecutamos el comando y guardamos los datos en el contenedor datareader
                var reader = cmd.ExecuteReader();

         
                var lista = new List<EmpleadoTipo>();

                while (reader.Read())
                {
                    lista.Add(new EmpleadoTipo
                    {
                        EmpleadoTipoID = (int)reader["empleadoTipoID"],
                        Nombre = reader["Nombre"].ToString(),
                    });
                }

                return lista;
            }
        }
    }
}


