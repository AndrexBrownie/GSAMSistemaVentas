﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Entity
{
   public class Documento
    {
        public int DocumentoID { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
