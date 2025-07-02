using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Venta
    {
        private DAL.Venta ventaDAL = new DAL.Venta();

        public bool CrearVenta(BE.Venta venta)
        {
            if (venta.Cliente == null || venta.Empleado == null || venta.DetalleVentas.Count == 0)
                throw new BE.ExcepcionDeNegocio("La venta debe tener cliente, vendedor y al menos un producto.");

            foreach (BE.DetalleVentas detalle in venta.DetalleVentas)
            {
                if (detalle.Producto.Stock < detalle.Cantidad)
                    throw new BE.ExcepcionDeNegocio($"Stock insuficiente para el producto {detalle.Producto.Nombre}");
            }
            return ventaDAL.CrearVenta(venta);
        }

        public DataTable ListarVentas()
        {
            DAL.Venta dalVenta = new DAL.Venta();
            return dalVenta.ObtenerVentasConTotales();
        }
        public DataTable ObtenerDetalle(int ventaId)
        {
            DAL.Venta dalVenta = new DAL.Venta();
            return dalVenta.ObtenerDetalleVenta(ventaId);
        }

        public DataTable ObtenerVentasPorCliente(int clienteId)
        {
            DAL.Venta ventaDAL = new DAL.Venta();
            return ventaDAL.ObtenerVentasPorCliente(clienteId);
        }
        public DataTable ObtenerDetalleVenta(int ventaId)
        {
            DAL.Venta ventaDAL = new DAL.Venta();
            return ventaDAL.ObtenerDetalleVenta(ventaId);
        }





    }
}
