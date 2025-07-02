using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Venta
    {
        public bool CrearVenta(BE.Venta venta)
        {
            Conexion db = new Conexion();

            SqlParameter[] parametrosVenta =
            {
            db.crearParametro("@Fecha", venta.Fecha),
            db.crearParametro("@Descuento", venta.Descuento),
            db.crearParametro("@EmpleadoId", venta.Empleado.ID),
            db.crearParametro("@ClienteId", venta.Cliente.UsuarioId)
        };

            // Primero insertás la venta
            db.EscribirPorStoreProcedure("usp_insertar_venta", parametrosVenta);

            // Luego obtenés el último ID insertado (NO recomendado en apps multiusuario)
            DataTable dt = db.LeerPorComando("SELECT MAX(Id) FROM Ventas");
            int ventaId = Convert.ToInt32(dt.Rows[0][0]);

            // Insertás los detalles con ese ID
            foreach (var detalle in venta.DetalleVentas)
            {
                SqlParameter[] parametrosDetalle =
                {
                db.crearParametro("@VentaId", ventaId),
                db.crearParametro("@ProductoId", detalle.Producto.ID),
                db.crearParametro("@Cantidad", detalle.Cantidad)
            };

                db.EscribirPorStoreProcedure("usp_insertar_detalle_venta", parametrosDetalle);
            }

            return true;
        }
        public DataTable ObtenerVentasConTotales()
        {
            Conexion db = new Conexion();
            return db.LeerPorStoreProcedure("usp_listar_ventas_con_total");
        }

        public DataTable ObtenerDetalleVenta(int ventaId)
        {
            Conexion db = new Conexion();

            SqlParameter[] parametros = new SqlParameter[]
            {
                db.crearParametro("@VentaId", ventaId)
            };

            return db.LeerPorStoreProcedure("usp_ver_detalle_venta", parametros);
        }
        public DataTable ObtenerVentasPorCliente(int clienteId)
        {
            Conexion db = new Conexion();
            SqlParameter[] parametros = {
        db.crearParametro("@ClienteId", clienteId)
    };

            return db.LeerPorStoreProcedure("usp_ventas_por_cliente", parametros);
        }



    }
}
