using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Vacuna : IEntidad
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _cantidadDosis;
        public int CantidadDosis
        {
            get { return _cantidadDosis; }
            set { _cantidadDosis = value; }
        }

        public override string ToString()
        {
            return $"{Nombre} ({CantidadDosis} dosis)";
        }
    }
}

