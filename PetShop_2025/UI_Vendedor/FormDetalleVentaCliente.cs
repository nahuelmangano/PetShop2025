using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_2025.UI_Vendedor
{
    public partial class FormDetalleVentaCliente : Form
    {
        private int ventaId;
        private Form formularioAnterior;
        public FormDetalleVentaCliente(int ventaId, Form formularioAnterior)
        {
            InitializeComponent();
            this.ventaId = ventaId;
            CargarDetalleVenta();
            this.formularioAnterior = formularioAnterior;
        }
        private void CargarDetalleVenta()
        {
            BLL.Venta ventaBLL = new BLL.Venta();
            DataTable detalle = ventaBLL.ObtenerDetalleVenta(ventaId);

            dgvDetalleVenta.DataSource = detalle;
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Calcular total
            decimal total = 0;
            foreach (DataRow row in detalle.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }

            lblVentaId.Text = $"Venta N° {ventaId} - Total: ${total:N2}";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            formularioAnterior.Show();

        }
    }
}
