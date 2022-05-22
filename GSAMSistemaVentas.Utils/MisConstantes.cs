using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAMSistemaVentas
{
  public  class MisConstantes
    {
        public static readonly Color COLOR_CELDA_FONDO_GRID = Color.White;
        public static readonly Color COLOR_CELDA_FONDO_GRID_ALTER = Color.WhiteSmoke;

        public enum CRUD: byte
        {
            Insercion = 1,
            Modificacion = 2
        }
    }
}
