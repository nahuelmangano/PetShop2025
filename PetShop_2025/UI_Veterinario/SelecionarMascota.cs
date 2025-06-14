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
    public partial class SelecionarMascota : Form
    {
        private BE.Mascota mascotaSeleccionada;
        private BE.Cliente clienteSeleccionado;

        public SelecionarMascota(BE.Mascota mascota, BE.Cliente cliente)
        {
            InitializeComponent();
            rbtnNuevoIngreso.Checked = true;
            rbtnSeleccionarMascota.Checked = false;

            this.mascotaSeleccionada = mascota ?? new BE.Mascota();
            this.clienteSeleccionado = cliente ?? new BE.Cliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form formAtenderMascota = new UI_Veterinario.AtenderMascota();
            this.Hide();
            formAtenderMascota.ShowDialog();

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }
    }
}
