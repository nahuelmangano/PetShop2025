using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop_2025.UI_Administrador;

namespace PetShop_2025.UI_Vendedor
{
    public partial class FormListarVentas : Form
    {
        Form formularioAnterior;
        public FormListarVentas(Form formularioAnterior)
        {
            InitializeComponent();
            BLL.Venta bllVenta = new BLL.Venta();
            DataTable dtVentas = bllVenta.ListarVentas();
            dgvListarVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListarVentas.ScrollBars = ScrollBars.Vertical;
            dgvListarVentas.DataSource = dtVentas;
            this.formularioAnterior = formularioAnterior;
        }

        private void btnAtas_Click(object sender, EventArgs e)
        {
         
            //Form formularioDePanelAdmin = new UI_Administrador.FormPanelAdmin();    
            this.Close();
            formularioAnterior.Show();
        
    }

        private void btnDetalleVenta_Click(object sender, EventArgs e)
        {
            if (dgvListarVentas.SelectedRows.Count > 0)
            {
                int ventaId = Convert.ToInt32(dgvListarVentas.SelectedRows[0].Cells["VentaId"].Value);
                FormDetalleVenta formDetalle = new UI_Vendedor.FormDetalleVenta(this,ventaId);
                formDetalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccioná una venta primero.");
            }
        }
    }
}
