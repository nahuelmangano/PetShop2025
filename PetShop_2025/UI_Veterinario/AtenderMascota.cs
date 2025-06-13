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
    public partial class AtenderMascota : Form
    {
        public AtenderMascota()
        {
            InitializeComponent();
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            Form formNuevaConsulta = new UI_Veterinario.NuevaConsulta();
            this.Hide();
            formNuevaConsulta.ShowDialog();
            this.Show();
        }

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {
            Form formBuscarHistorial = new UI_Veterinario.BuscarHistorialMedico();
            this.Hide();
            formBuscarHistorial.ShowDialog();
            this.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
