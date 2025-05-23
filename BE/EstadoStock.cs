using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EstadoStock : IEntidad
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", ID, Descripcion);
        }

        public void SetNormal() 
        {
            this.ID = 1;
            this.Descripcion = "Normal";
        }

        public void SetBajo() 
        { 
            this.ID = 2;
            this.Descripcion = "Bajo";
        }

        public void SetAgotado() 
        {
            this.ID = 3;
            this.Descripcion = "Agotado";
        }
    }
}
