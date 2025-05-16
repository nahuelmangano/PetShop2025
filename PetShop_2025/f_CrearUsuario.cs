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
    public partial class f_CrearUsuario : Form
    {
        public f_CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            BE.Usuario usuario = new BE.Usuario();
            usuario.NombreUsuario = tb_Nombre.Text;
            usuario.ApellidoUsuario = tb_Apellido.Text;
            usuario.EmailUsuario = tb_Email.Text;
            usuario.PasswordUsuario = tb_Password.Text;
            usuario.Perfil = Convert.ToInt32(nud_PerfilUsuario.Value);


            BLL.Usuario logicaUsuario = new BLL.Usuario();

            if (logicaUsuario.CrearUsuario(usuario))
            {
                MessageBox.Show("SE CREO EL USUARIOOO");
            }
            else
            {

                MessageBox.Show("ERROR 404! !  !");
            }
        }
    }
}
