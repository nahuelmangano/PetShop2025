using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HistoriaClinica : IEntidad
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        
        private DateTime _fechaCreacion;
        public DateTime Fecha
        {
            get { return _fechaCreacion; }
            set { _fechaCreacion = value; }
        }
        
        private string _motivo;
        public string Motivo
        {
            get { return _motivo; }
            set { _motivo = value; }
        }

        private string _diagnostico;
        public string Diagnostico
        {
            get { return _diagnostico; }
            set { _diagnostico = value; }
        }

        private List<string> _tratamientos;
        public List<string> Tratamientos
        {
            get { return _tratamientos; }
            set { _tratamientos = value; }
        }

        private List<string> _observaciones;
        public List<string> Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

    }
}
