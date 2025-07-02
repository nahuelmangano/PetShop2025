using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleVentas
    {
        private BE.Productos _producto;
        public BE.Productos Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        private int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
    }
}
