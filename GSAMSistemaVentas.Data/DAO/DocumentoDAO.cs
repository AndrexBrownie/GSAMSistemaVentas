using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Data
{
   public class DocumentoDAO
    {
        public List<Documento> Documento_Select_simple()
        {
            //conexion a la BD
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                //Creamos un comando y la configuramos para la ejecucion de la consulta
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Documento_Select_simple";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Ejecutamos el comando y guardamos los datos en el contenedor datareader
                var reader = cmd.ExecuteReader();

                //Creamos una lista de objetos documentos vacia
                var lista = new List<Documento>();

                //Transferimos los registros del reader hacia la lista de documentos
                while (reader.Read())
                {
                    lista.Add(new Documento
                    {
                        DocumentoID = (int)reader["DocumentoID"],
                        Tipo = reader["Tipo"].ToString(),
                    });
                }

                return lista;
            }
        }
    }
}
