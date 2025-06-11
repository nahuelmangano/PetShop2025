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
        public AplicarVacuna()
        {
            InitializeComponent();

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AplicarVacuna_Load(object sender, EventArgs e)
        {
            BLL.Vacuna vacunaBLL = new BLL.Vacuna();
            try
            {
                List<BE.Vacuna> listaVacunas = vacunaBLL.Listar();
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
