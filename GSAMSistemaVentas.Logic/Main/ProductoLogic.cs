using GSAMSistemaVentas.Data;
using GSAMSistemaVentas.Entity;
using System.Collections.Generic;

namespace GSAMSistemaVentas.Logic
{
    public class ProductoLogic
    {
        public List<Producto> GetAll(bool estado)
        {
            return new ProductoDAO().GetAll(estado);
        }
        public Producto Get(int productoID)
        {
            return new ProductoDAO().Get(productoID);
        }

        public int Insert(Producto obj)
        {
            return new ProductoDAO().Insert(obj);
        }
        public int Update(Producto obj)
        {
            return new ProductoDAO().Update(obj);
        }
        public int Delete(int id)
        {
            return new ProductoDAO().Delete(id);
        }
    }
}
