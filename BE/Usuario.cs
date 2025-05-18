using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;


        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public enum PerfilUsuario
        {
            Administrador = 1,
            Gerente = 2,
            Ventas = 3,
            Compras = 4,
            Cliente = 5
        }

        private PerfilUsuario _perfil;

        public PerfilUsuario Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

    }
}
