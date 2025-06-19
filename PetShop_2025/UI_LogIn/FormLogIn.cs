using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_2025.UI_LogIn
{
    public partial class FormLogIn : Form
    {
        public BE.Usuario UsuarioAutenticado { get; private set; }
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            BE.Usuario beUsuario = new BE.Usuario();
            BLL.Usuario bllUsuario = new BLL.Usuario();

            try
            {
                beUsuario = bllUsuario.ValidarUsuario(txtEmail.Text, txtPassword.Text);
                if (beUsuario == null)
                {
                    MessageBox.Show("Usuario o clave inválido");
                }
                else
                {
                    UsuarioAutenticado = beUsuario;
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Esto permitirá al Program.cs continuar
                }
            }
            catch (BE.ExcepcionDeNegocio excepcionPersonalizada)
            {
                UsuarioAutenticado = null;
                MessageBox.Show(excepcionPersonalizada.Mensaje);
            }
            catch (Exception ex)
            {
                UsuarioAutenticado = null;
                MessageBox.Show("Ocurrió una Exception: " + ex.Message);
            }
        }
        public Form ObtenerFormularioPorPerfil()
        {
            if (UsuarioAutenticado == null) return null;

            switch (UsuarioAutenticado.Perfil.ID)
            {
                case 1: return new UI_Administrador.FormPanelAdmin();
                case 2: return new UI_Vendedor.FormPanelVendedor(UsuarioAutenticado);
                case 3: return new UI_Veterinario.MenuPrincipal();               
                case 4: return new UI_Gerente.FormReportes();
                default: return null;
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
