using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Clientes
    {
        private DAL.Clientes clienteDAL = new DAL.Clientes();

        public List<BE.Usuario> ObtenerClientes()
        {
            return clienteDAL.ListarClientes();
        }
    }
}
