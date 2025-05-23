using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Veterinario : Usuario
    {
        private string _matricula;
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        private string _especialidad;
        public string Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

    }
}
