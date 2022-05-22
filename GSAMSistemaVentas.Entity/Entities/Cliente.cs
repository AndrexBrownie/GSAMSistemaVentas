using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Entity
{
  public  class Cliente
    {
        public int ClienteID { get; set; }
        public int DocumentoID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumDoc{ get; set; }
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }


        public string TipoDocumento { get; set; }

    }
}
