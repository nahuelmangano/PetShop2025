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
            }
            catch (BE.ExcepcionDeNegocio excepcionPersonalizada)
            {
                beUsuario = null;
                MessageBox.Show(excepcionPersonalizada.Mensaje);
            }
            catch (Exception ex)
            {
                beUsuario = null;
                MessageBox.Show("Ocurrió una Exception: " + ex.Message);
            }

            if (beUsuario == null)
            {
                MessageBox.Show("Usuario o clave es invalido");
            }
            else
            {
                const int idPerfilGerente = 1;
                const int idPerfilAdministrador = 2;
                const int idPerfilVeterinario = 3;
                const int idPerfilVendedor = 4;

                Form formularioDeUsuario;


                switch (beUsuario.Perfil.ID)
                {
                    case idPerfilGerente:
                        /* Ejemplo de como abrir un formulario diferente dependiendo del perfil
                         * formularioDeUsuario = new OtroFormulario();
                         * this.Hide();
                         * formularioDeUsuario.ShowDialog();
                        */
                        break;

                    case idPerfilAdministrador:
                        /* Ejemplo de como abrir un formulario diferente dependiendo del perfil
                         * formularioDeUsuario = new OtroFormulario();
                         * this.Hide();
                         * formularioDeUsuario.ShowDialog();
                        */
                        break;

                    case idPerfilVeterinario:
                        //Ejemplo de como abrir un formulario diferente dependiendo del perfil
                        formularioDeUsuario = new UI_Veterinario.MenuPrincipal();
                        this.Hide();
                        formularioDeUsuario.ShowDialog();

                        break;

                    case idPerfilVendedor:
                        /* Ejemplo de como abrir un formulario diferente dependiendo del perfil
                         * formularioDeUsuario = new OtroFormulario();
                         * this.Hide();
                         * formularioDeUsuario.ShowDialog();
                        */
                        break;

                    default:
                        
                        break;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
