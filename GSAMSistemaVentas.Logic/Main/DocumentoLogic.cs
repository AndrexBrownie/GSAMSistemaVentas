using GSAMSistemaVentas.Data;
using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Logic
{
  public  class DocumentoLogic
    {
        public List<Documento> Documento_Select_simple()
        {
            return new DocumentoDAO().Documento_Select_simple();
        }
    }
}
