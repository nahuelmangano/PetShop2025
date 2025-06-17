using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Clientes
    {
        public List<BE.Cliente> ObtenerClientes()
        {
            DataTable dt = new DAL.Clientes().ListarClientes();
            List<BE.Cliente> lista = new List<BE.Cliente>();

            foreach (DataRow fila in dt.Rows)
            {
                BE.Cliente cliente = new BE.Cliente
                {
                    UsuarioId = Convert.ToInt32(fila["UsuarioId"]),
                    Dni = fila["Dni"].ToString(),
                    DescuentoPts = Convert.ToInt32(fila["Descuento_pts"]),
                    Usuario = new BE.Usuario
                    {
                        ID = Convert.ToInt32(fila["UsuarioId"]),
                        Nombre = fila["Nombre"].ToString(),
                        Apellido = fila["Apellido"].ToString(),
                        Email = fila["Email"].ToString(),
                        Password = fila["Password"].ToString(),
                        Perfil = new BE.Perfil { ID = Convert.ToInt32(fila["PerfilId"]) }
                    }
                };

                lista.Add(cliente);
            }

            return lista;
        }

        public bool ActualizarCliente(BE.Cliente cliente)
        {
            DAL.Clientes dal = new DAL.Clientes();
            return dal.ActualizarCliente(cliente);
        }
        public DataTable BuscarClientes(string criterio, string valor)
        {
            DAL.Clientes clienteDAL = new DAL.Clientes();
            return clienteDAL.BuscarClientes(criterio, valor);
        }




    }
}
