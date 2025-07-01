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
    public partial class NuevoIngreso : Form
    {
        public NuevoIngreso()
        {
            InitializeComponent();
        }

        private void NuevoIngreso_Load(object sender, EventArgs e)
        {
            gBoxDatosCliente.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (nudBuscarDNI.Value == 0 || nudBuscarDNI.Value < 10000000)
            {
                MessageBox.Show("Debe ingresar un DNI para buscar al cliente y poder Continuar con la consulta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int dni = (int)nudBuscarDNI.Value;
                BE.Cliente cliente = new BLL.Cliente().BuscarClientePorDNI(dni);
                if (cliente == null)
                {
                    MessageBox.Show("No se encontró un cliente con ese DNI.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                gBoxDatosCliente.Enabled = true;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDNI.Text = cliente.DNI.ToString();
                txtTelefono.Text = cliente.Telefono;
                txtEmail.Text = cliente.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
