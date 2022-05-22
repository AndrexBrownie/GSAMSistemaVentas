using GSAMSistemaVentas.Data;
using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Logic
{
  public  class ProveedorLogic
    {
        public List<Proveedor> Proveedor_Select_simple()
        {
            return new ProveedorDAO().Proveedor_Select_simple();
        }
        public List<Proveedor> GetAll(bool estado)
        {
            return new ProveedorDAO().GetAll(estado);
        }
        public int Insert(Proveedor obj)
        {
            return new ProveedorDAO().Insert(obj);
        }
        public int Update(Proveedor obj)
        {
            return new ProveedorDAO().Update(obj);
        }
        public int Delete(int id)
        {
            return new ProveedorDAO().Delete(id);
        }
    }
}
