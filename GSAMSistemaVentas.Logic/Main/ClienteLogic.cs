using GSAMSistemaVentas.Data;
using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Logic
{
  public  class ClienteLogic
    {
        public List<Cliente> GetAll(bool estado)
        {
            return new ClienteDAO().GetAll(estado);
        }
        public int Insert(Cliente obj)
        {
            return new ClienteDAO().Insert(obj);
        }
        public int Update(Cliente obj)
        {
            return new ClienteDAO().Update(obj);
        }
        public int Delete(int id)
        {
            return new ClienteDAO().Delete(id);
        }
    }
}
