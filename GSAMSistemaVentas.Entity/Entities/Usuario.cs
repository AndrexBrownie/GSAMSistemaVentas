using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Entity
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public int EmpleadoID { get; set; }
        public string Usuariio { get; set; }
        public string Clase { get; set; }
        public bool Estado { get; set; }
    }
}
