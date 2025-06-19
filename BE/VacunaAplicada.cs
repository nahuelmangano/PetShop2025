using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class VacunaAplicada : IEntidad
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private Vacuna _vacuna;
        public Vacuna Vacuna
        {
            get { return _vacuna; }
            set { _vacuna = value; }
        }

        private int _numeroDosis;
        public int NumeroDosis
        {
            get { return _numeroDosis; }
            set { _numeroDosis = value; }
        }

        private DateTime _fechaAplicacion;
        public DateTime FechaAplicacion
        {
            get { return _fechaAplicacion; }
            set { _fechaAplicacion = value; }
        }

        private Mascota _mascota;
        public Mascota Mascota
        {
            get { return _mascota; }
            set { _mascota = value; }
        }

        public override string ToString()
        {
            return $"Vacuna: {Vacuna?.Nombre}, Dosis: {NumeroDosis}, Fecha: {FechaAplicacion.ToShortDateString()}";
        }
    }
}

