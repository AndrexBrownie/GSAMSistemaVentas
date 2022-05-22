using GSAMSistemaVentas.Data;
using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Logic
{
   public class EmpleadoTipoLogic
    {
        public List<EmpleadoTipo> EmpleadoTipo_Select_simple()
        {
            return new EmpleadoTipoDAO().EmpleadoTipo_Select_simple();
        }
    }
}
