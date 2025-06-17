using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        public int UsuarioId { get; set; } // igual al Id generado en Usuarios
        public string Dni { get; set; }
        public int DescuentoPts { get; set; } = 0;

        public Usuario Usuario { get; set; }  // propiedad para acceder a los datos del usuario

        public override string ToString()
        {
            return $"{Usuario.Nombre} {Usuario.Apellido}";
        }
        public string NombreCompleto => $"{Usuario.Nombre} {Usuario.Apellido}";

    }
}

