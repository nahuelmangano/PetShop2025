using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_2025.UI_Veterinario
{
    public partial class AgregarMedicamento : Form
    {
        public AgregarMedicamento()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Medicamento beMedicamento = new BE.Medicamento()
                {
                    Nombre = txtNombre.Text,
                    StockActual = Convert.ToInt32(nudStockActual.Value),
                    StockMinimo = Convert.ToInt32(nudStockMinimo.Value),
                };
                BLL.Medicamento bllMedicamento = new BLL.Medicamento();

                if (bllMedicamento.AgregarMedicamento(beMedicamento))
                {
                    MessageBox.Show($"Medicamento agregado con éxito: \n\n" +
                        $"Nombre:\t\t{beMedicamento.Nombre}\n" +
                        $"Stock Actual:\t{beMedicamento.StockActual}\n" +
                        $"Stock Mínimo:\t{beMedicamento.StockMinimo}\n" +
                        $"Estado:\t\t{beMedicamento.Estado.Descripcion}\n");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema, intente más tarde");
                }

            }
            catch (BE.ExcepcionDeNegocio excepcionPersonalizada)
            {
                MessageBox.Show(excepcionPersonalizada.Mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió una Exception: " + ex.Message);
            }
        }
    }
}
