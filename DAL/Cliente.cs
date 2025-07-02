using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cliente
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
                db.crearParametro("@UsuarioId", cliente.ID),
                db.crearParametro("@Nombre", cliente.Nombre),
                db.crearParametro("@Apellido", cliente.Apellido),
                db.crearParametro("@Email", cliente.Email),
                db.crearParametro("@Dni", cliente.DNI),
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
