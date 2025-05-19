using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Medicamento
    {
		private int _id;

		public int Id
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

		private int _stockActual;

		public int StockActual
		{
			get { return _stockActual; }
			set { _stockActual = value; }
		}

		private int _stockMinimo;

		public int StockMinimo
		{
			get { return _stockMinimo; }
			set { _stockMinimo = value; }
		}

		public enum EstadoStock
		{
			Agotado = 0,
			Bajo = 1,
			Normal = 2,
        }

		private EstadoStock _estado;

		public EstadoStock Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}


	}
}
