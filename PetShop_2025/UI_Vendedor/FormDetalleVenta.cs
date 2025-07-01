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
    public partial class FormDetalleVenta : Form
    {
        Form formularioAnterior;
        public FormDetalleVenta(Form formulario, int ventaId)
        {
            InitializeComponent();
            CargarDetalleVenta(ventaId);
            formularioAnterior = formulario;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            formularioAnterior.Show();
        }

        private void CargarDetalleVenta(int ventaId)
        {
            BLL.Venta bllVenta = new BLL.Venta();
            DataTable detalle = bllVenta.ObtenerDetalle(ventaId);

            dgvDetalleVenta.DataSource = detalle;

            // Calcular el total general
            decimal totalVenta = 0;
            foreach (DataRow fila in detalle.Rows)
            {
                totalVenta += Convert.ToDecimal(fila["Total"]);
            }

            lblTotal.Text = $"Total de la Venta: ${totalVenta:N2}";
        }

    }
}
