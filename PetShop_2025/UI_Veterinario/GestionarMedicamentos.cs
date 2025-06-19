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
        private List<BE.Medicamento> listaMedicamentos;
        public GestionarMedicamentos()
        {
            InitializeComponent();
            listaMedicamentos = new List<BE.Medicamento>();
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            Form formAgregarMedicamento = new UI_Veterinario.AgregarMedicamento();
            this.Hide();
            formAgregarMedicamento.ShowDialog();
            CargarDGVListaMedicamentos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionarMedicamentos_Load(object sender, EventArgs e)
        {
            CargarDGVListaMedicamentos();
        }

        private void CargarDGVListaMedicamentos()
        {   
            BLL.Medicamento bllMedicamento = new BLL.Medicamento();
            listaMedicamentos = bllMedicamento.ListarMedicamentos();
            dgvMedicamentos.DataSource = null;
            dgvMedicamentos.DataSource = listaMedicamentos;
        }
    }
}
