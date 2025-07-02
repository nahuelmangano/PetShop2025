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
                BE.Cliente clienteEncontrado = new BLL.Cliente().ObtenerClientePorDNI(dni);
                if (clienteEncontrado is null)
                {
                    // Si no se encontró el cliente, mostrar un mensaje
                    MessageBox.Show("No se encontró un cliente con ese DNI. Complete los datos para ingresarlo al sistema.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gBoxDatosCliente.Enabled = true; // Habilitar el grupo de datos del cliente para que se puedan ingresar los datos
                    
                }
                else 
                {
                    // Entonces se encontró el cliente, mostrar sus datos
                    MessageBox.Show("Cliente encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Asignar los datos del cliente a los controles del formulario
                    tBoxNombre.Text = clienteEncontrado.Nombre;
                    tBoxApellido.Text = clienteEncontrado.Apellido;
                    nudDNI.Text = clienteEncontrado.DNI.ToString();
                    tBoxEmail.Text = clienteEncontrado.Email;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
