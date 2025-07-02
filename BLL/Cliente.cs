using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente
    {
        public List<BE.Cliente> ObtenerClientes()
        {
            DataTable dt = new DAL.Cliente().ListarClientes();
            List<BE.Cliente> lista = new List<BE.Cliente>();

            foreach (DataRow fila in dt.Rows)
            {
                BE.Cliente cliente = new BE.Cliente
                {
                    ID = Convert.ToInt32(fila["UsuarioId"]),
                    Nombre = fila["Nombre"].ToString(),
                    Apellido = fila["Apellido"].ToString(),
                    Email = fila["Email"].ToString(),
                    Password = fila["Password"].ToString(),
                    Perfil = new BE.Perfil { ID = Convert.ToInt32(fila["PerfilId"]) }
                };

                lista.Add(cliente);
            }

            return lista;
        }

        public bool ActualizarCliente(BE.Cliente cliente)
        {
            DAL.Cliente dal = new DAL.Cliente();
            return dal.ActualizarCliente(cliente);
        }
        public DataTable BuscarClientes(string criterio, string valor)
        {
            DAL.Cliente clienteDAL = new DAL.Cliente();
            return clienteDAL.BuscarClientes(criterio, valor);
        }




    }
}
