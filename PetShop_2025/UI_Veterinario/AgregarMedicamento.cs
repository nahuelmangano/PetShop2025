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
        BLL.Medicamento bllMedicamento = new BLL.Medicamento();

        public AgregarMedicamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNombreMedicamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Medicamento beMedicamento = new BE.Medicamento()
                {
                    Nombre = tboxNombre.Text,
                    StockActual = Convert.ToInt32(numStockActual),
                    StockMinimo = Convert.ToInt32(numStockActual),
                    //Descripcion = tboxDescripcion.Text,
                };
                BLL.Medicamento bllMedicamento = new BLL.Medicamento();

                if (bllMedicamento.AgregarMedicamento(beMedicamento)) 
                {
                    MessageBox.Show("Medicamento agregado con éxito");
                    // Refrescar lista, limpiar campos...
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema, intente más tarde");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
