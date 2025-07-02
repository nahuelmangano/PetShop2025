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
    public partial class FormListarClientes : Form
    {
        Form FomularioAnterior;
        public FormListarClientes(Form fomularioAnterior)
        {
            InitializeComponent();
            CargarClientes();
            FomularioAnterior = fomularioAnterior;
        }
        private void CargarClientes()
        {
            BLL.Cliente clienteBLL = new BLL.Cliente();
            dgvListarClientes.DataSource = clienteBLL.ObtenerClientes();

            dgvListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FomularioAnterior.Show();

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvListarClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un cliente para editar.");
                return;
            }

            int usuarioId = Convert.ToInt32(dgvListarClientes.CurrentRow.Cells["UsuarioId"].Value);

            BLL.Cliente clienteBLL = new BLL.Cliente();
            var cliente = clienteBLL.ObtenerClientes().FirstOrDefault(c => c.UsuarioId == usuarioId);

            if (cliente != null)
            {
                FormEditarCliente formEditar = new FormEditarCliente(cliente, this);
                formEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.");
            }
        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnVerComprasCliente_Click(object sender, EventArgs e)
        {
        
            if (dgvListarClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un cliente para ver sus compras.");
                return;
            }

            int usuarioId = Convert.ToInt32(dgvListarClientes.CurrentRow.Cells["UsuarioId"].Value);

            // Mostrar el formulario de compras del cliente
            FormComprasCliente formCompras = new FormComprasCliente(this,usuarioId);
            formCompras.ShowDialog();
        
    }
    }
}
