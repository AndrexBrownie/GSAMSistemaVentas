using GSAMSistemaVentas.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GSAMSistemaVentas.Data
{
    public class ProductoDAO
    {
        public List<Producto> GetAll(bool estado)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_producto_getAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estado", estado);

                var reader = cmd.ExecuteReader();

                var lista = new List<Producto>();

                while (reader.Read())
                {
                    lista.Add(new Producto
                    {
                        ProductoID = (int)reader["ProductoID"],
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        UMedida = reader["Unidad"].ToString(),
                        Marca = reader["Marca"].ToString(),
                        Proveedor = reader["Proveedor"].ToString(),
                        PrecioCosto = (decimal) reader["PrecioCosto"],
                        PrecioVenta = (decimal) reader["PrecioVenta"],
                        Stock = (int)reader["Stock"],
                        StockMinimo = (int)reader["StockMinimo"],
                        Estado = (bool)reader["Estado"]
                    }) ;
                }

                return lista;
            }
        }

        public Producto Get(int productoID)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_producto_get";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                var reader = cmd.ExecuteReader();

                var lista = new List<Producto>();

                while (reader.Read())
                {
                    lista.Add(new Producto
                    {
                        ProductoID = (int)reader["ProductoID"],
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        UMedida = reader["Unidad"].ToString(),
                        Marca = reader["Marca"].ToString(),
                        Proveedor = reader["Proveedor"].ToString(),
                        PrecioCosto = (decimal)reader["PrecioCosto"],
                        PrecioVenta = (decimal)reader["PrecioVenta"],
                        Stock = (int)reader["Stock"],
                        StockMinimo = (int)reader["StockMinimo"],
                        Estado = (bool)reader["Estado"]
                    });
                }

                return lista[0];
            }
        }

        public int Insert(Producto obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Producto_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", obj.CategoriaID);
                cmd.Parameters.AddWithValue("@UMedidaID", obj.UMedidaID);
                cmd.Parameters.AddWithValue("@MarcaID", obj.MarcaID);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@ProveedorID", obj.ProveedorID);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCosto", obj.PrecioCosto);
                cmd.Parameters.AddWithValue("@PrecioVenta", obj.PrecioVenta);
                cmd.Parameters.AddWithValue("@Stock", obj.Stock);
                cmd.Parameters.AddWithValue("@StockMinimo", obj.StockMinimo);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }

        public int Update(Producto obj)
        {
            using (var cnx = new ConnectionFactory().GetConnection)
            {
                var cmd = new SqlCommand();
                cmd.Connection = (SqlConnection)cnx;
                cmd.CommandText = "usp_Producto_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", obj.CategoriaID);
                cmd.Parameters.AddWithValue("@UMedidaID", obj.UMedidaID);
                cmd.Parameters.AddWithValue("@MarcaID", obj.MarcaID);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@ProveedorID", obj.ProveedorID);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCosto", obj.PrecioCosto);
                cmd.Parameters.AddWithValue("@PrecioVenta", obj.PrecioVenta);
                cmd.Parameters.AddWithValue("@Stock", obj.Stock);
                cmd.Parameters.AddWithValue("@StockMinimo", obj.StockMinimo);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@ProductoID", obj.ProductoID);

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
                cmd.CommandText = "usp_Producto_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", id);

                int rpta = cmd.ExecuteNonQuery();

                return rpta;
            }
        }
    }
}
