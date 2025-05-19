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
                throw new Exception("El nombre es obligatorio");

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
