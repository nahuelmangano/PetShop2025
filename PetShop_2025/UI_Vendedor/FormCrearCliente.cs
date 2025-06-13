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
    public partial class FormCrearCliente : Form
    {
        public FormCrearCliente()
        {
            InitializeComponent();
        }

       


        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            BE.Usuario nuevoUsuario = new BE.Usuario();
        
            BLL.Vendedor bllVendedor = new BLL.Vendedor();

            try
            {
                // Cargar datos del formulario al objeto usuario
                nuevoUsuario.Nombre = txtNombreCliente.Text.Trim();
                nuevoUsuario.Apellido = txtApellidoCliente.Text.Trim();
                nuevoUsuario.Email = txtMailCliente.Text.Trim();
                nuevoUsuario.Password = "Cliente";
                string dni= txtDniCliente.Text.Trim();

                
                nuevoUsuario.Perfil = new BE.Perfil();

                nuevoUsuario.Perfil.ID =5;

                bool creado = bllVendedor.CrearCliente(nuevoUsuario,dni);

                if (creado)
                {
                    MessageBox.Show("Cliente creado correctamente.");
                    // Opcional: limpiar campos o cerrar form
                }
                else
                {
                    MessageBox.Show("No se pudo crear el cliente.");
                }
            }
            catch (BE.ExcepcionDeNegocio exNegocio)
            {
                MessageBox.Show(exNegocio.Mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
