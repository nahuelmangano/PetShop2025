using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Medicamento
    {
        private DAL.Medicamento dalMedicamento = new DAL.Medicamento();

        public bool AgregarMedicamento(BE.Medicamento unMedicamento)
        {
            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(unMedicamento.Nombre))
            {
                throw new BE.ExcepcionDeNegocio("Advertencia: El campo 'nombre' es obligatorio");
            }

            if (unMedicamento.StockActual <= 0) 
            {
                throw new BE.ExcepcionDeNegocio("Advertencia: El campo 'stock actual' es obligatorio");
            }

            if (unMedicamento.StockMinimo <= 0)
            {
                throw new BE.ExcepcionDeNegocio("Advertencia: El campo 'stock mínimo' es obligatorio");
            }

            // Asignar estado según stock
            if (unMedicamento.StockActual < unMedicamento.StockMinimo)
                unMedicamento.Estado = new BE.EstadoStock { ID = 2, Descripcion = "Bajo" };
            else
                unMedicamento.Estado = new BE.EstadoStock { ID = 1, Descripcion = "Normal" };

            dalMedicamento.Insertar(unMedicamento);

            return true;
        }

        public List<BE.Medicamento> ListarMedicamentos()
        {
            return dalMedicamento.Listar();
        }

        // Agregar métodos para editar, eliminar, buscar, reportes, etc.
    }
}
