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
            this.Close();

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Form formAtenderMascota;

            if (rbtnNuevoIngreso.Checked)
            {
                MessageBox.Show("NUEVO INGRESO");
                // Crear nuevos objetos vacíos para un nuevo ingreso
                BE.Cliente nuevoCliente = new BE.Cliente();
                BE.Mascota nuevaMascota = new BE.Mascota();

                formAtenderMascota = new UI_Veterinario.NuevaConsulta(nuevaMascota,nuevoCliente);
                formAtenderMascota.ShowDialog();
            }
            else if (rbtnSeleccionarMascota.Checked)
            {
                MessageBox.Show("MASCOTAS EN BBDD");
                // Usar los objetos seleccionados
                //formAtenderMascota = new UI_Veterinario.NuevaConsulta(nuevaMascota, nuevoCliente);
            }
            else
            {
                MessageBox.Show("Seleccioná una opción para continuar.");
                return;
            }

            this.Hide();
            //formAtenderMascota.ShowDialog();
        }
    }
}
