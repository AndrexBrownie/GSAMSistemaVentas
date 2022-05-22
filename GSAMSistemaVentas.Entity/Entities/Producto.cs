using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Entity
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public int CategoriaID { get; set; }
        public int UMedidaID { get; set; }
        public int MarcaID { get; set; }
        public int ProveedorID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public bool Estado { get; set; }

        public string Categoria { get; set; }
        public string UMedida { get; set; }
        public string Marca { get; set; }
        public string Proveedor { get; set; }
    }
}
