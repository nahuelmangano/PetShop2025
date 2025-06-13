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

namespace PetShop_2025.UI_Vendedor
{
    public partial class FormCrearVenta : Form
    {
        public FormCrearVenta()
        {
            InitializeComponent();
            CargarComboClientes();
            CargarComboProductos();
        }

        private void CargarComboClientes()
        {
            BLL.Clientes clienteBLL = new BLL.Clientes();
            var listaClientes = clienteBLL.ObtenerClientes();

            cbClientes.DataSource = listaClientes;
            //cbClientes.DisplayMember = "NombreDescripcion"; // Esto muestra "Nombre - Descripción"
            cbClientes.ValueMember = "Nombre";

          

           
        }

        //cargar combobox productos
        private void CargarComboProductos()
        {
            BLL.Productos productoBLL = new BLL.Productos();
            var listaProductos = productoBLL.ObtenerProductos();

            cbProductos.DataSource = listaProductos;
            //cbProductos.DisplayMember = "NombreDescripcion"; // Esto muestra "Nombre"
            cbProductos.ValueMember = "Nombre";
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
