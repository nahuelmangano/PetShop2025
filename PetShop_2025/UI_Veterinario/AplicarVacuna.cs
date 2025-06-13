using BLL;
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
    public partial class AplicarVacuna : Form
    {
        private List<BE.VacunaAplicada> vacunasAplicadas;

        public AplicarVacuna(List<BE.VacunaAplicada> vacunasAplicadas)
        {
            InitializeComponent();
            this.vacunasAplicadas = vacunasAplicadas ?? new List<BE.VacunaAplicada>(); ;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Vacuna vacunaSeleccionada = cmbVacuna.SelectedItem as BE.Vacuna; // Obtener la vacuna seleccionada del ComboBox

                if (vacunaSeleccionada == null) // Validar que se haya seleccionado una vacuna
                {
                    throw new BE.ExcepcionDeNegocio("Debe seleccionar una vacuna antes de aplicar.");
                }

                int dosisSeleccionada = (int)nudNumeroDosis.Value; // Obtener el número de dosis del NumericUpDown

                if (dosisSeleccionada <= 0)   // Validar que el número de dosis seleccionado sea mayor a cero
                {
                    throw new BE.ExcepcionDeNegocio("El número de dosis debe ser mayor a cero.");
                }

                // Si no se encuentra la vacuna aplicada, se crea una nueva
                if (!vacunasAplicadas.Any(v => v.Vacuna.ID == vacunaSeleccionada.ID))
                {
                    BE.VacunaAplicada nuevaVacunaAplicada = new BE.VacunaAplicada
                    {
                        Vacuna = vacunaSeleccionada,
                        NumeroDosis = dosisSeleccionada,
                        FechaAplicacion = DateTime.Now
                    };
                    vacunasAplicadas.Add(nuevaVacunaAplicada);
                }
                else  // Si ya existe, se actualiza la lista de vacunas aplicadas
                {
                    //Busca si la mascota ya tiene aplicada esta vacuna
                    foreach (var vacunaAplicada in vacunasAplicadas)
                    {
                        if (vacunaAplicada.Vacuna.ID == vacunaSeleccionada.ID)
                        {
                            int cantidadDosis = vacunaAplicada.Vacuna.CantidadDosis;
                            int dosisActual = vacunaAplicada.NumeroDosis;
                            if (dosisSeleccionada == dosisActual)
                            {
                                throw new BE.ExcepcionDeNegocio("Ya se aplicó esta dosis. No se puede aplicar la misma dosis.");

                            }
                            if (dosisSeleccionada > cantidadDosis)
                            {
                                throw new BE.ExcepcionDeNegocio($"La vacuna seleccionada solo permite un máximo de {cantidadDosis} dosis.");
                            }
                            if (dosisSeleccionada < dosisActual)
                            {
                                throw new BE.ExcepcionDeNegocio("No se puede aplicar una dosis menor a la ya aplicada.");
                            }
                            vacunaAplicada.NumeroDosis = dosisSeleccionada; // Actualizar el número de dosis si ya existe
                            vacunaAplicada.FechaAplicacion = DateTime.Now; // Actualizar la fecha de aplicación
                        }
                    }
                }
                MessageBox.Show("Vacuna registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (BE.ExcepcionDeNegocio ex)
            {
                MessageBox.Show(ex.Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AplicarVacuna_Load(object sender, EventArgs e)
        {
            RellenarCMBVacunas();
        }

        private void RellenarCMBVacunas()
        {
            BLL.Vacuna vacunaBLL = new BLL.Vacuna();
            try
            {
                List<BE.Vacuna> listaVacunas = vacunaBLL.ListarVacunas();
                cmbVacuna.DataSource = listaVacunas;
                cmbVacuna.DisplayMember = "Nombre";
                cmbVacuna.ValueMember = "ID";
            }
            catch (BE.ExcepcionDeNegocio ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
