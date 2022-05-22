using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Entity {
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public int DocumentoID { get; set; }
        public int EmpleadoTipoID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumDoc { get; set; }
        public string Direccion { get; set; }
        public string Ubigeo { get; set; }
        public bool Estado{ get; set; }


        public string Documento { get; set; }
        public string EmpleadoTipo { get; set; }
    }
}
