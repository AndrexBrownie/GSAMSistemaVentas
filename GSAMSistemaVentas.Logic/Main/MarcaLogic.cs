using GSAMSistemaVentas.Data;
using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Logic
{
   public class MarcaLogic
    {
        public List<Marca> Marca_Select_simple()
        {
            return new MarcaDAO().Marca_Select_simple();
        }

        public List<Marca> GetAll(bool estado)
        {
            return new MarcaDAO().GetAll(estado);
        }
        public int Insert(Marca obj)
        {
            return new MarcaDAO().Insert(obj);
        }
        public int Update(Marca obj)
        {
            return new MarcaDAO().Update(obj);
        }
        public int Delete(int id)
        {
            return new MarcaDAO().Delete(id);
        }
    }
}
