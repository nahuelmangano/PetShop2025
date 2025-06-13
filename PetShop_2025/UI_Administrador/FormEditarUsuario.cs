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
        Form formularioAnterior;
        private BE.Usuario usuarioActual;
        public FormEditarUsuario(Form form, BE.Usuario usuario)
        {
            InitializeComponent();
            formularioAnterior = form;
            usuarioActual = usuario;

            CargarDatos();
        }
        private void CargarDatos()
        {
            txtNombre.Text = usuarioActual.Nombre;
            txtApellido.Text = usuarioActual.Apellido;
            txtMail.Text = usuarioActual.Email;
            txtContraseña.Text = usuarioActual.Password;
            nudPerfilUsuario.Value = usuarioActual.Perfil.ID;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            formularioAnterior.Show();
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            usuarioActual.Nombre = txtNombre.Text.Trim();
            usuarioActual.Apellido = txtApellido.Text.Trim();
            usuarioActual.Email = txtMail.Text.Trim();
            usuarioActual.Password = txtContraseña.Text.Trim();
            usuarioActual.Perfil.ID = (int)nudPerfilUsuario.Value;

            BLL.Usuario bllUsuario = new BLL.Usuario();
            bool editado = bllUsuario.ModificarUsuario(usuarioActual);

            if (editado)
            {
                MessageBox.Show("Usuario actualizado correctamente.");
                this.Close();
                formularioAnterior.Show();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario.");
            }
        }
    }
}
