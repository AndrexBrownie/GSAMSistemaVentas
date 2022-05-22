using GSAMSistemaVentas.Data;
using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Logic
{
   public class UMedidaLogic
    {
        public List<UMedida> UMedida_Select_simple()
        {
            return new UMedidaDAO().UMedida_Select_simple();
        }
        public List<UMedida> GetAll(bool estado)
        {
            return new UMedidaDAO().GetAll(estado);
        }
        public int Insert(UMedida obj)
        {
            return new UMedidaDAO().Insert(obj);
        }
        public int Update(UMedida obj)
        {
            return new UMedidaDAO().Update(obj);
        }
    }
}
