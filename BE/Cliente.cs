using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Usuario
    {
       
        private long _dni;
        public long DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private List<Mascota> _mascotas;
        public List<Mascota> Mascotas
        {
            get { return _mascotas; }
            set { _mascotas = value; }
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {DNI}";
        }

    }
}

