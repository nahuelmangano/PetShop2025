using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace PetShop_2025.UI_Administrador
{
    public partial class FormEditarUsuario : Form
    {
        private BE.Usuario usuarioEditar;
        private Form _formularioAnterior;
        public FormEditarUsuario(Form formularioAnterior, BE.Usuario usuario)
        {
            InitializeComponent();
            usuarioEditar = usuario;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            if (usuarioEditar != null)
            {
                txtNombre.Text = usuarioEditar.Nombre;
                txtApellido.Text = usuarioEditar.Apellido;
                txtEmail.Text = usuarioEditar.Email; 

                // Por seguridad, la contraseña no se suele mostrar.
                // Si la quieres mostrar para que el usuario pueda verla y cambiarla:
                txtContraseña.Text = usuarioEditar.Password;

                // Asegúrate de que nudPerfilUsuario.Value acepte el ID del perfil.
                // Si Perfil.ID es 0 y nudPerfilUsuario tiene un Minimum mayor, esto podría fallar.
                // Considera un ComboBox para perfiles si los IDs no son secuenciales o quieres mostrar nombres.
                numPerfilUsuario.Value = usuarioEditar.Perfil.ID;
            }
        }

        private void GuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposUsuario(); // Primero, valida los campos del formulario

                // Actualiza el objeto usuario con los nuevos datos
                usuarioEditar.Nombre = txtNombre.Text.Trim();
                usuarioEditar.Apellido = txtApellido.Text.Trim();
                usuarioEditar.Email = txtEmail.Text.Trim();
                usuarioEditar.Password = txtContraseña.Text; // Actualiza la contraseña si se cambió

                // Actualiza el ID del perfil. Si es un ComboBox, sería diferente.
                usuarioEditar.Perfil.ID = (int)numPerfilUsuario.Value;

                BLL.Usuario bllUsuario = new BLL.Usuario();
                
                bool actualizado = bllUsuario.ModificarUsuario(usuarioEditar);

                if (actualizado)
                {
                    MessageBox.Show("Usuario actualizado correctamente.");
                    this.DialogResult = DialogResult.OK; // Indica que la operación fue exitosa
                    this.Close(); // Cierra el formulario actual
                    _formularioAnterior.Show(); // Muestra el formulario anterior
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.");
                }
            }
            catch (BE.ExcepcionDeNegocio exNegocio)
            {
                MessageBox.Show(exNegocio.Mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            _formularioAnterior.Show(); // Muestra el formulario anterior
        }

        private void ValidarCamposUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))   //Nombre del usuario
            {
                throw new BE.ExcepcionDeNegocio("El campo 'nombre' del usuario es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text)) //Apellido del usuario
            {
                throw new BE.ExcepcionDeNegocio("El campo 'Apellido' del usuario es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) // Mail del usuario
            {
                throw new BE.ExcepcionDeNegocio("El campo 'Email' del usuario es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(txtContraseña.Text)) // Contraseña
            {
                throw new BE.ExcepcionDeNegocio("El campo 'Contraseña' del usuario es obligatorio.");
            }
        }

        
    }
}
