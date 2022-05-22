using GSAMSistemaVentas.Data;
using GSAMSistemaVentas.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas.Logic
{
   public class EmpleadoLogic
    {
        public List<Empleado> GetAll(bool estado)
        {
            return new EmpleadoDAO().GetAll(estado);
        }

        public Empleado Get(int EmpleadoID)
        {
            return new EmpleadoDAO().Get(EmpleadoID);
        }

        public int Insert(Empleado obj)
        {
            return new EmpleadoDAO().Insert(obj);
        }
        public int Update(Empleado obj)
        {
            return new EmpleadoDAO().Update(obj);
        }
        public int Delete(int id)
        {
            return new EmpleadoDAO().Delete(id);
        }
    }
}
