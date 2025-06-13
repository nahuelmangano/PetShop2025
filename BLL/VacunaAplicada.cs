using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.VacunaAplicada;

namespace BLL
{
    public class VacunaAplicada
    {
        public class VacunaAplicadaBLL
        {
            DAL.VacunaAplicada dal = new DAL.VacunaAplicada();

            public List<BE.VacunaAplicada> ListarPorMascota(int idMascota)
            {
                if (idMascota <= 0)
                    throw new BE.ExcepcionDeNegocio("El ID de la mascota debe ser válido");

                return dal.ListarPorMascota(idMascota);
            }

            public int Insertar(BE.VacunaAplicada vacunaAplicada)
            {
                if (vacunaAplicada == null)
                    throw new BE.ExcepcionDeNegocio("VacunaAplicada no puede ser null");

                if (vacunaAplicada.Mascota == null || vacunaAplicada.Mascota.ID <= 0)
                    throw new BE.ExcepcionDeNegocio("Debe especificarse una mascota válida");

                if (vacunaAplicada.Vacuna == null || vacunaAplicada.Vacuna.ID <= 0)
                    throw new BE.ExcepcionDeNegocio("Debe especificarse una vacuna válida");

                if (vacunaAplicada.NumeroDosis <= 0)
                    throw new BE.ExcepcionDeNegocio("El número de dosis debe ser mayor a cero");

                return dal.InsertarVacunaAplicada(vacunaAplicada);
            }
        }
    }
}
