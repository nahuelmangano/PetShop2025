using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetShop_2025.UI_Veterinario
{
    public partial class NuevaConsulta : Form
    {
        private List<BE.VacunaAplicada> vacunasAplicadas = new List<BE.VacunaAplicada>();

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
            Form formAplicarVacuna = new UI_Veterinario.AplicarVacuna(vacunasAplicadas);
            formAplicarVacuna.ShowDialog();
            ActualizarDGVVacunasAplicadas();

        }

        private void ActualizarDGVVacunasAplicadas ()
        {
            dgvVacunasAplicadas.AutoGenerateColumns = false;
            dgvVacunasAplicadas.Columns.Clear();

            // Columna Nombre de la Vacuna
            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Vacuna"; // Lo manejamos en CellFormatting
            dgvVacunasAplicadas.Columns.Add(colNombre);

            // Columna Nº Dosis
            var colDosis = new DataGridViewTextBoxColumn();
            colDosis.HeaderText = "Nº Dosis";
            colDosis.DataPropertyName = "NumeroDosis";
            dgvVacunasAplicadas.Columns.Add(colDosis);

            // Columna Fecha
            var colFecha = new DataGridViewTextBoxColumn();
            colFecha.HeaderText = "Fecha";
            colFecha.DataPropertyName = "FechaAplicacion";
            dgvVacunasAplicadas.Columns.Add(colFecha);
            

            dgvVacunasAplicadas.DataSource = null;
            dgvVacunasAplicadas.DataSource = vacunasAplicadas;
             
        }

        private void dgvVacunasAplicadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVacunasAplicadas.Columns[e.ColumnIndex].HeaderText == "Fecha")
            {
                if (e.Value is DateTime fecha)
                {
                    e.Value = fecha.ToShortDateString(); // Mostrar solo la fecha, sin hora
                }
            }
        }

        private void NuevaConsulta_Load(object sender, EventArgs e)
        {
            dgvVacunasAplicadas.CellFormatting += dgvVacunasAplicadas_CellFormatting;
        }
    }
}
