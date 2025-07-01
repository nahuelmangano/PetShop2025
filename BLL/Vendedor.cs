using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Vendedor
    {
        public bool CrearCliente(BE.Usuario usuario, string dni)
        {

            DAL.Vendedor dalVendedor = new DAL.Vendedor();
            dalVendedor.CrearCliente(usuario,dni);

            return true;

        }
    }
}
