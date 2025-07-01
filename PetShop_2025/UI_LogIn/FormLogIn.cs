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
                    MessageBox.Show("Usuario o clave es invalido");
                }
                else
                {
                    const int idPerfilAdministrador = 1;
                    const int idPerfilGerente = 2;
                    const int idPerfilVeterinario = 3;
                    const int idPerfilVendedor = 4;

                    Form formularioDeUsuario;


                    switch (beUsuario.Perfil.ID)
                    {
                        case idPerfilGerente:
                            formularioDeUsuario = new UI_Gerente.FormReportes();
                            this.Hide();
                            formularioDeUsuario.ShowDialog();
                            break;

                        case idPerfilAdministrador:
                            formularioDeUsuario = new UI_Administrador.FormPanelAdmin();
                            this.Hide();
                            formularioDeUsuario.ShowDialog();
                            break;

                        case idPerfilVeterinario:
                            formularioDeUsuario = new UI_Veterinario.MenuPrincipal();
                            this.Hide();
                            formularioDeUsuario.ShowDialog();

                            break;

                        case idPerfilVendedor:
                            formularioDeUsuario = new UI_Vendedor.FormPanelVendedor();
                            this.Hide();
                            formularioDeUsuario.ShowDialog();
                            break;

                        default:

                            break;
                    }
                }
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
