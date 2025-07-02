using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Vendedor
    {
        public bool CrearCliente(BE.Usuario usuario, string dni)
        {
            string nombreStoreProcedure = "usp_insertar_usuario";
            SqlParameter[] parametros = new SqlParameter[5];
            Conexion objConexion = new Conexion();

            parametros[0] = objConexion.crearParametro("@nombre", usuario.Nombre);
            parametros[1] = objConexion.crearParametro("@apellido", usuario.Apellido);
            parametros[2] = objConexion.crearParametro("@email", usuario.Email);
            parametros[3] = objConexion.crearParametro("@perfil", usuario.Perfil.ID);
            parametros[4] = objConexion.crearParametro("@password", usuario.Password);

            int filasAfectadas = objConexion.EscribirPorStoreProcedure(nombreStoreProcedure, parametros);

            if (filasAfectadas > 0)
            {
                int nuevoUsuarioId = ObtenerIdPorEmail(usuario.Email);
                if (nuevoUsuarioId > 0)
                {
                    // Insertar en Clientes
                    SqlParameter[] parametrosCliente = new SqlParameter[3];
                    parametrosCliente[0] = objConexion.crearParametro("@usuarioId", nuevoUsuarioId);
                    parametrosCliente[1] = objConexion.crearParametro("@dni", dni);
                    parametrosCliente[2] = objConexion.crearParametro("@descuento", 0);

                    int resultado = objConexion.EscribirPorStoreProcedure("sp_insertar_cliente", parametrosCliente);
                    return resultado > 0;
                }
            }

            return false;
        }


        public int ObtenerIdPorEmail(string emailBuscado)
        {
            Conexion db = new Conexion();
            DataTable dt = db.LeerPorComando("SELECT id, email FROM Usuarios");

            foreach (DataRow fila in dt.Rows)
            {
                string email = fila["email"].ToString();
                if (email.Equals(emailBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    return Convert.ToInt32(fila["id"]);
                }
            }

            return -1; // No encontrado
        }


    }
}
