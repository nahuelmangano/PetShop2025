using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Vacuna
    {
        DAL.Vacuna dal = new DAL.Vacuna();

        public List<BE.Vacuna> Listar()
        {
            return dal.Listar();
        }

        public int Insertar(BE.Vacuna vacuna)
        {
            if (vacuna == null)
                throw new BE.ExcepcionDeNegocio("Vacuna no puede ser null");

            if (string.IsNullOrWhiteSpace(vacuna.Nombre))
                throw new BE.ExcepcionDeNegocio("El nombre de la vacuna es obligatorio");

            if (vacuna.CantidadDosis <= 0)
                throw new BE.ExcepcionDeNegocio("La cantidad de dosis debe ser mayor a cero");

            return dal.Insertar(vacuna);
        }
    }
}
