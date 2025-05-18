using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private string _nombreUsuario;
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        private string _apellidoUsuario;


        public string ApellidoUsuario
        {
            get { return _apellidoUsuario; }
            set { _apellidoUsuario = value; }
        }


        private string _emailUsuario;

        public string EmailUsuario
        {
            get { return _emailUsuario; }
            set { _emailUsuario = value; }
        }

        private string _passwordUsuario;

        public string PasswordUsuario
        {
            get { return _passwordUsuario; }
            set { _passwordUsuario = value; }
        }

        public enum PerfilUsuario
        {
            Administrador = 1,
            Gerente = 2,
            Ventas = 3,
            Compras = 4,
            Cliente = 5
        }

        private PerfilUsuario _perfilUsuario;

        public PerfilUsuario Perfil
        {
            get { return _perfilUsuario; }
            set { _perfilUsuario = value; }
        }

    }
}
