using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
        private DateTime _fecha;
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private int _descuento;
        public int Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }
        private BE.Usuario _empleadoId;
        public BE.Usuario Empleado
        {
            get { return _empleadoId; }
            set { _empleadoId = value; }
        }
        private BE.Cliente _clienteId;
        public BE.Cliente Cliente
        {
            get { return _clienteId; }
            set { _clienteId = value; }
        }

        private List<BE.Productos> _productoId;
        public List<BE.Productos> Producto
        {
            get { return _productoId; }
            set { _productoId = value; }
        }
        private int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private List<BE.DetalleVentas> _detalleVentas;
        public List<BE.DetalleVentas> DetalleVentas
        {
            get { return _detalleVentas; }
            set { _detalleVentas = value; }
        }


    }
}
