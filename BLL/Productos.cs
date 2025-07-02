using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Productos
    {
        private DAL.Productos productoDAL = new DAL.Productos();

        public List<BE.Productos> ObtenerProductos()
        {
            return productoDAL.ListarProductos();
        }
    }
}
