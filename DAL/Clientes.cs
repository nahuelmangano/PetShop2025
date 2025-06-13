using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Clientes
    {
        public List<BE.Usuario> ListarClientes()
        {
            List<BE.Cliente> lista = new List<BE.Cliente>();
            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            Conexion db = new Conexion();

            DataTable dt = db.LeerPorStoreProcedure("sp_listar_clientes");

            foreach (DataRow fila in dt.Rows)
            {
                var usuario = new BE.Usuario
                {
                    ID = Convert.ToInt32(fila["UsuarioId"]),
                    Nombre = fila["Nombre"].ToString(),
                    Apellido = fila["Apellido"].ToString(),
                    Email = fila["Email"].ToString(),
                    Password = fila["Password"].ToString(),
                    Perfil = new BE.Perfil { ID = Convert.ToInt32(fila["PerfilId"]) }
                };

                var cliente = new BE.Cliente
                {
                    UsuarioId = usuario.ID,
                    Dni = fila["Dni"].ToString(),
                    DescuentoPts = Convert.ToInt32(fila["Descuento_pts"])
                };

                usuarios.Add(usuario);
            }

            return usuarios;
        }


    }
}
