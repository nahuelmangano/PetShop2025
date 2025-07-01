using BE;
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
        private int alturaGBox, alturaFormularioSinGroupBox;

        public SelecionarMascota()
        {
            InitializeComponent();
            this.mascotaSeleccionada = new BE.Mascota();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (rbtnNuevoIngreso.Checked)
            {
                var nuevaConsulta = new UI_Veterinario.NuevoIngreso(); // Nuevo ingreso 
                this.Hide();
                nuevaConsulta.ShowDialog();
            }
            else if (rbtnSeleccionarMascota.Checked)
            {
                if (dgvMascotas.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una mascota.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var mascota = dgvMascotas.CurrentRow.DataBoundItem as BE.Mascota;
                if (mascota != null)
                {
                    var nuevaConsulta = new UI_Veterinario.NuevaConsulta(mascota);
                    this.Hide();
                    nuevaConsulta.ShowDialog();
                }
            }

        }

        private void rbtnSeleccionarMascota_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrar = rbtnSeleccionarMascota.Checked;
            gBoxSeleccionarMascota.Visible = mostrar;

            this.Height = mostrar
                ? alturaFormularioSinGroupBox
                : alturaFormularioSinGroupBox - alturaGBox;

        }

        private void SelecionarMascota_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // Cargar mascotas al DGV
            List<BE.Mascota> mascotas = new BLL.Mascota().ListarMascotas();
            dgvMascotas.AutoGenerateColumns = true;
            dgvMascotas.DataSource = mascotas;

            // Configurar el DataGridView
            dgvMascotas.Columns["ID"].Visible = false;
            dgvMascotas.Columns["FechaNacimiento"].Visible = false;
            dgvMascotas.Columns["Esterilizada"].Visible = false;

            // Guardar altura original del formulario y del GroupBox
            alturaFormularioSinGroupBox = this.Height;
            alturaGBox = gBoxSeleccionarMascota.Height;

            // Ocultar el GroupBox y ajustar el tamaño del formulario
            gBoxSeleccionarMascota.Visible = false;
            this.Height = alturaFormularioSinGroupBox - alturaGBox;


        }
    }
}