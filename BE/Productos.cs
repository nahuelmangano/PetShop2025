using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Productos : IEntidad
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

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private decimal _precio;
        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private string _categoria;
        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private int _stock;
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
