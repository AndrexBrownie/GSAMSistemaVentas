using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Entity
{
  public  class Proveedor
    {
        public int ProveedorID { get; set; }
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public string Direccion { get; set; }
        public string Telf { get; set; }
        public string Mail { get; set; }
        public bool Estado { get; set; }
    }
}
