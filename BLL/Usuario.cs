using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        public BE.Usuario ValidarUsuario(string unEmail, string unaPassword)
        {

            if (string.IsNullOrWhiteSpace(unEmail))
            {
                throw new BE.ExcepcionDeNegocio("Falta completar el nombre de usuario");
            }

            if (string.IsNullOrWhiteSpace(unaPassword))
            {
                throw new BE.ExcepcionDeNegocio("Falta completar la contraseña de usuario");
            }

            //Es porque tiene nombre y password

            DAL.Usuario dalUsuario = new DAL.Usuario();

            return dalUsuario.ValidarUsuario(unEmail, unaPassword);
        }

        public bool CrearUsuario(BE.Usuario usuario)
        {

            DAL.Usuario dalUsuario = new DAL.Usuario();
            dalUsuario.CrearUsuario(usuario);

            return true;

        }

        public bool ModificarUsuario(BE.Usuario usuario)
        {

            DAL.Usuario dalUsuario = new DAL.Usuario();
            dalUsuario.ActualizarUsuario(usuario);

            return true;

        }

        public bool Loguearse(string usuarioMail, string password)
        {

            DAL.Usuario dalUsuario = new DAL.Usuario();

            List<BE.Usuario> usuarios = dalUsuario.Listar();

            foreach (BE.Usuario unUsuario in usuarios)
            {
                if (unUsuario.Password == password.Trim() && unUsuario.Email == usuarioMail.Trim())
                {
                    return true;
                }




            }
            return false;
        }

        public List<BE.Usuario> ListarUsuarios() 
        { 
            DAL.Usuario dalUsuario= new DAL.Usuario();

            List<BE.Usuario> usuarios = dalUsuario.Usuarios();


            return usuarios;




        }











    }
}
