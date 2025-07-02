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

            return db.LeerPorStoreProcedure("usp_buscar_cliente", parametros);
        }

        public BE.Cliente ObtenerClientePorDNI(int dni)
        {
            DataTable dt = BuscarClientes("DNI", dni.ToString());
            if (dt.Rows.Count == 0)
                return null;
            DataRow fila = dt.Rows[0];
            BE.Cliente cliente = new BE.Cliente
            {
                ID = Convert.ToInt32(fila["UsuarioId"]),
                Nombre = fila["Nombre"].ToString(),
                Apellido = fila["Apellido"].ToString(),
                Email = fila["Email"].ToString(),
                DNI = Convert.ToInt32(fila["Dni"]),
            };
            return cliente;
        }


    }

}
