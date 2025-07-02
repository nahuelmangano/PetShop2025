using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_2025.UI_Vendedor
{
    public partial class FormPanelVendedor : Form
    {
        BE.Usuario UsuarioAutenticado;
        public FormPanelVendedor(BE.Usuario usuario)
        {
            UsuarioAutenticado = usuario;
            InitializeComponent();
            //MessageBox.Show("Bienvenido " + UsuarioAutenticado.Apellido + " al panel de vendedor");
            lblUsuario.Text = UsuarioAutenticado.Email;
        }

        


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Form formularioDeVendedor = new UI_Vendedor.FormCrearCliente(this);
            this.Hide();
            formularioDeVendedor.ShowDialog();
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            Form formularioDeVenta = new UI_Vendedor.FormCrearVenta(this,UsuarioAutenticado);
            this.Hide();
            formularioDeVenta.ShowDialog();
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            Form fomularioListarVentas= new UI_Vendedor.FormListarVentas(this);
            this.Hide();
            fomularioListarVentas.ShowDialog();
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            Form formularioListarCliente = new UI_Vendedor.FormListarClientes(this);
            this.Hide();
            formularioListarCliente.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form formularioBusquedaCliente = new UI_Vendedor.FormBuscarCliente(this);
            this.Hide();
            formularioBusquedaCliente.ShowDialog();
        }
    }
}
