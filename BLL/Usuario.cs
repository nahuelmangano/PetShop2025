using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        public bool CrearUsuario(BE.Usuario usuario)
        {

            DAL.Usuario dalUsuario = new DAL.Usuario();
            dalUsuario.crear(usuario);

            return true;

        }

        public bool ModificarUsuario(BE.Usuario usuario)
        {

            DAL.Usuario dalUsuario = new DAL.Usuario();
            dalUsuario.modificar(usuario);

            return true;

        }

        public bool Loguearse(string usuarioMail, string password)
        {

            DAL.Usuario dalUsuario = new DAL.Usuario();

            List<BE.Usuario> usuarios = dalUsuario.Listar();

            foreach (BE.Usuario unUsuario in usuarios)
            {
                if (unUsuario.PasswordUsuario == password.Trim() && unUsuario.EmailUsuario == usuarioMail.Trim())
                {
                    return true;
                }




            }
            return false;
        }











    }
}
