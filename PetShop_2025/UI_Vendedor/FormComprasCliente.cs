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
    public partial class FormComprasCliente : Form
    {
        private int clienteId;
        private Form formularioAnterior;

        public FormComprasCliente(Form Formulario,int usuarioId)
        {
            InitializeComponent();
            clienteId = usuarioId;
            formularioAnterior = Formulario;
            CargarCompras();
        }

        private void CargarCompras()
        {
            BLL.Venta ventaBLL = new BLL.Venta();
            DataTable ventasCliente = ventaBLL.ObtenerVentasPorCliente(clienteId);

            if (ventasCliente.Rows.Count == 0)
            {
                MessageBox.Show("Este cliente no tiene compras registradas.");
            }

            dgvComprasCliente.DataSource = ventasCliente;
            dgvComprasCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            formularioAnterior.Show();
        }

        private void btnDetalleVenta_Click(object sender, EventArgs e)
        {
            if (dgvComprasCliente.CurrentRow != null)
            {
                int ventaId = Convert.ToInt32(dgvComprasCliente.CurrentRow.Cells["VentaId"].Value);
                FormDetalleVenta detalleForm = new FormDetalleVenta(this, ventaId);
                detalleForm.ShowDialog();
            }
        }
    }

}
