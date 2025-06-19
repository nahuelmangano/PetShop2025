using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mascota : IEntidad
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

        private string _sexo;
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        private int _peso;
        public int Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        private DateTime _fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private string _especie;
        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        private string _raza;
        public string Raza
        {
            get { return _raza; }
            set { _raza = value; }
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private bool _esterilizada;
        public bool Esterilizada
        {
            get { return _esterilizada; }
            set { _esterilizada = value; }
        }

        private List<HistoriaClinica> _historiasClinicas;
        public List<HistoriaClinica> HistoriasClinicas
        {
            get { return _historiasClinicas; }
            set { _historiasClinicas = value; }
        }

        private List<VacunaAplicada> _vacunasAplicadas;
        public List<VacunaAplicada> VacunasAplicadas
        {
            get { return _vacunasAplicadas; }
            set { _vacunasAplicadas = value; }
        }
    }
}
