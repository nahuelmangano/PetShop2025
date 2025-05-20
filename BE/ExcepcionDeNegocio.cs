using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ExcepcionDeNegocio : Exception
    {
        private string _mensaje;

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        public ExcepcionDeNegocio(string texto)
        {
            this.Mensaje = texto;
        }
    }
}
