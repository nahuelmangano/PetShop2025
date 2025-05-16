using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_2025
{
    public partial class f_LogIn : Form
    {
        public f_LogIn()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string usuario1= tb_Usuario.Text;
            if ( tb_Usuario.Text=="admin" && tb_Contraseña.Text=="1234")
            {
                f_PanelAdmin menu = new f_PanelAdmin();
                menu.Show();
                this.Hide();//esconde la pantalla anterior
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
