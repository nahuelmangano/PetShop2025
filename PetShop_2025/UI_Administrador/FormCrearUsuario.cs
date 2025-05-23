using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_2025.UI_Administrador
{
    public partial class FormCrearUsuario : Form
    {
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            BE.Usuario nuevoUsuario = new BE.Usuario();
            BLL.Usuario bllUsuario = new BLL.Usuario();

            try
            {
                // Cargar datos del formulario al objeto usuario
                nuevoUsuario.Nombre = txtNombre.Text.Trim();
                nuevoUsuario.Apellido = txtApellido.Text.Trim();
                nuevoUsuario.Email = txtEmail.Text.Trim();
                nuevoUsuario.Password = txtContraseña.Text;

                // Asumimos que tenés un comboBox o algo para elegir el perfil
                nuevoUsuario.Perfil = new BE.Perfil();
               
                nuevoUsuario.Perfil.ID = (int)nudPerfilUsuario.Value;

                bool creado = bllUsuario.CrearUsuario(nuevoUsuario);

                if (creado)
                {
                    MessageBox.Show("Usuario creado correctamente.");
                    // Opcional: limpiar campos o cerrar form
                }
                else
                {
                    MessageBox.Show("No se pudo crear el usuario.");
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
