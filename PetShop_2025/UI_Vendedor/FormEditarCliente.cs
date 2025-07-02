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
    public partial class FormEditarCliente : Form
    {
      
        private BE.Cliente cliente;
        private FormListarClientes formAnterior;
        public FormEditarCliente(BE.Cliente cliente, FormListarClientes anterior)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.formAnterior = anterior;
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtMail.Text = cliente.Email;
            txtDni.Text = cliente.DNI.ToString();
            //nudDescuento.Value = cliente.DescuentoPts;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellido = txtApellido.Text.Trim();
            cliente.Email = txtMail.Text.Trim();
            cliente.DNI = Convert.ToInt32(txtDni.Text.Trim());
            //cliente.DescuentoPts = (int)nudDescuento.Value;

            BLL.Cliente clienteBLL = new BLL.Cliente();
            bool actualizado = clienteBLL.ActualizarCliente(cliente);

            if (actualizado)
            {
                MessageBox.Show("Cliente actualizado con éxito.");
                this.Close();
                formAnterior.Show(); // método público que actualiza el dgv
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el cliente.");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            formAnterior.Show();
        }
    }
}
