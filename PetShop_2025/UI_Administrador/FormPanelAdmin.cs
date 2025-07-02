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
    public partial class FormPanelAdmin : Form
    {
        public FormPanelAdmin()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Form formularioDeUsuario = new UI_Administrador.FormCrearUsuario(this);
            this.Hide();
            formularioDeUsuario.ShowDialog();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            Form formularioDeUsuario = new UI_Administrador.FormListarUsuario(this);
            this.Hide();
            formularioDeUsuario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
        

        }
    }
}
