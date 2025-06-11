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
    public partial class GestionarMedicamentos : Form
    {
        public GestionarMedicamentos()
        {
            InitializeComponent();
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            Form formAgregarMedicamento = new UI_Veterinario.AgregarMedicamento();
            formAgregarMedicamento.ShowDialog();
        }

        //Agregar Funcionalidad para agregar vacunas

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
