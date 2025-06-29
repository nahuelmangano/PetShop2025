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
    public partial class FormEditarUsuario : Form
    {
        public FormEditarUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
