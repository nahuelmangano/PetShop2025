using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Clientes
    {
        public DataTable ListarClientes()
        {
            Conexion db = new Conexion();
            return db.LeerPorStoreProcedure("sp_listar_clientes", null);
        }

        public bool ActualizarCliente(BE.Cliente cliente)
        {
            Conexion db = new Conexion();

            SqlParameter[] parametros =
            {
                db.crearParametro("@UsuarioId", cliente.UsuarioId),
                db.crearParametro("@Nombre", cliente.Usuario.Nombre),
                db.crearParametro("@Apellido", cliente.Usuario.Apellido),
                db.crearParametro("@Email", cliente.Usuario.Email),
                db.crearParametro("@Dni", cliente.Dni),
                db.crearParametro("@Descuento_pts", cliente.DescuentoPts)
            };

            db.EscribirPorStoreProcedure("sp_actualizar_cliente", parametros);
            return true;
        }
        public DataTable BuscarClientes(string criterio, string valor)
        {
            Conexion db = new Conexion();
            SqlParameter[] parametros = {
            db.crearParametro("@Criterio", criterio),
            db.crearParametro("@Valor", valor)
            };

            return db.LeerPorStoreProcedure("sp_buscar_cliente", parametros);
        }




    }

}
