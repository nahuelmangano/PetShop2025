using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Mascota
    {
        private DAL.Mascota dalMascota = new DAL.Mascota();

        public bool AgregarMascota(BE.Mascota unaMascota)
        {
            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(unaMascota.Nombre))
            {
                throw new BE.ExcepcionDeNegocio("Advertencia: El campo 'nombre' es obligatorio");
            }
            
            dalMascota.InsertarMascota(unaMascota);
            return true;
        }

        public List<BE.Mascota> ListarMascotas()
        {
            return dalMascota.ListarMascotas();
        }
    }
}
