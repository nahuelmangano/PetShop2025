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
    public partial class FormBuscarCliente : Form
    {
        Form FormularioAnterior;
        public FormBuscarCliente(Form formularioAnterior)
        {
            InitializeComponent();
            FormularioAnterior = formularioAnterior;
            cbCriterioBusqueda.Items.AddRange(new string[] { "Nombre", "Apellido", "DNI" });
            cbCriterioBusqueda.SelectedIndex = 0; // Por defecto
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormularioAnterior.Show();

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string criterio = cbCriterioBusqueda.SelectedItem.ToString();
            string valor = txtBuscarCliente.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Ups el campo busqueda esta vacio!");
                return;
            }

            BLL.Cliente clienteBLL = new BLL.Cliente();
            DataTable resultados = clienteBLL.BuscarClientes(criterio, valor);

            if (resultados.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron clientes.");
            }

            dgvResultadoCliente.DataSource = resultados;
            dgvResultadoCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (dgvResultadoCliente.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un cliente para ver sus compras.");
                return;
            }

            int usuarioId = Convert.ToInt32(dgvResultadoCliente.CurrentRow.Cells["UsuarioId"].Value);

            // Mostrar el formulario de compras del cliente
            FormComprasCliente formCompras = new FormComprasCliente(this, usuarioId);
            formCompras.ShowDialog();
        }
    }
}
