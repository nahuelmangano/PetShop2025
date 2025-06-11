using System;
using System.Windows.Forms;

namespace PetShop_2025.UI_Veterinario
{
    public partial class NuevaConsulta : Form
    {
        public NuevaConsulta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnAplicarVacuna_Click(object sender, EventArgs e)
        {
            Form formAplicarVacuna = new UI_Veterinario.AplicarVacuna();
            formAplicarVacuna.DataBindings.Add();
            formAplicarVacuna.ShowDialog();
        }
    }
}
