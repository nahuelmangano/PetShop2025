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
            txtNombre.Text = cliente.Usuario.Nombre;
            txtApellido.Text = cliente.Usuario.Apellido;
            txtMail.Text = cliente.Usuario.Email;
            txtDni.Text = cliente.Dni;
            nudDescuento.Value = cliente.DescuentoPts;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Usuario.Nombre = txtNombre.Text.Trim();
            cliente.Usuario.Apellido = txtApellido.Text.Trim();
            cliente.Usuario.Email = txtMail.Text.Trim();
            cliente.Dni = txtDni.Text.Trim();
            cliente.DescuentoPts = (int)nudDescuento.Value;

            BLL.Clientes clienteBLL = new BLL.Clientes();
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
