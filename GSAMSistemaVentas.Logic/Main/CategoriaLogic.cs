using GSAMSistemaVentas.Data;
using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Logic
{
   public class CategoriaLogic
    {
        public List<Categoria> Categoria_Select_simple()
        {
            return new CategoriaDAO().Categoria_Select_simple();
        }

        public List<Categoria> GetAll(bool estado)
        {
            return new CategoriaDAO().GetAll(estado);
        }
        public int Insert(Categoria obj)
        {
            return new CategoriaDAO().Insert(obj);
        }
        public int Update(Categoria obj)
        {
            return new CategoriaDAO().Update(obj);
        }
        public int Delete(int id)
        {
            return new CategoriaDAO().Delete(id);
        }
    }
}
