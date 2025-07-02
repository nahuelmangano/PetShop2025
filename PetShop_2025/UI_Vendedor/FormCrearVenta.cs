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
using BLL;

namespace PetShop_2025.UI_Vendedor
{
  
    public partial class FormCrearVenta : Form
    {
        private Form formularioAnterior;
        private BE.Usuario usuarioAutenticado;
        private List<BE.DetalleVentas> detallesVentas = new List<BE.DetalleVentas>();
        public FormCrearVenta(Form form, BE.Usuario usuario)
        {
            InitializeComponent();
            CargarComboClientes();
            CargarComboProductos();
            formularioAnterior = form;
            usuarioAutenticado = usuario;

            //MessageBox.Show("Bienvenido " + usuarioAutenticado.Email + " al panel de vendedor");

        }

        private void CargarComboClientes()
        {
            BLL.Cliente clienteBLL = new BLL.Cliente();
            List<BE.Cliente> listaClientes = clienteBLL.ObtenerClientes();

            cbClientes.DataSource = clienteBLL.ObtenerClientes();
            cbClientes.DisplayMember = "NombreCompleto";
            cbClientes.ValueMember = "UsuarioId";





        }

        //cargar combobox productos
        private void CargarComboProductos()
        {
            BLL.Productos productoBLL = new BLL.Productos();
            var listaProductos = productoBLL.ObtenerProductos();

            cbProductos.DataSource = listaProductos;
            
            cbProductos.ValueMember = "Nombre";
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {

       
            try
            {
                MessageBox.Show("VENTA\n" +
                                "Cliente: " + cbClientes.Text + "\n" +
                                "Producto: " + cbProductos.Text + "\n" +
                                "Cantidad: " + nudCantidad.Value.ToString() + "\n" +
                                "VENDEDOR ID"+ usuarioAutenticado.ID+"\n"+
                                "Fecha: " + DateTime.Now.ToString());

                if (detallesVentas.Count == 0)
                {
                    MessageBox.Show("Debés agregar al menos un producto.");
                    return;
                }

                BE.Venta nuevaVenta = new BE.Venta
                {
                    Cliente = (BE.Cliente)cbClientes.SelectedItem,
                    Fecha = DateTime.Now,
                    Empleado = usuarioAutenticado, // <-- pasalo desde el constructor
                    DetalleVentas = detallesVentas // <-- creá esta propiedad en la clase Venta
                };

                BLL.Venta bllVenta = new BLL.Venta();
                bool creada = bllVenta.CrearVenta(nuevaVenta);

                if (creada)
                {
                    MessageBox.Show("Venta creada correctamente.");
                    detallesVentas.Clear();
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la venta.");
                }
            }
            catch (BE.ExcepcionDeNegocio exNegocio)
            {
                MessageBox.Show(exNegocio.Mensaje);
            }


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioAnterior.Show();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            BE.Productos productoSeleccionado = (BE.Productos)cbProductos.SelectedItem;
            int cantidad = (int)nudCantidad.Value;

            if (productoSeleccionado != null && cantidad > 0)
            {
                detallesVentas.Add(new BE.DetalleVentas
                {
                    Producto = productoSeleccionado,
                    Cantidad = cantidad
                });

                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccioná un producto y cantidad válida.");
            }
        }

        private void ActualizarGrilla()
        {
            dgvDetalleVentas.DataSource = null;
            dgvDetalleVentas.DataSource = detallesVentas.Select(d => new
            {
                Producto = d.Producto.Nombre,
                Precio = d.Producto.Precio,
                Cantidad = d.Cantidad,
                Subtotal = d.Producto.Precio * d.Cantidad
            }).ToList();
        }
        //Form formularioDeDetalleDeVenta = new UI_Vendedor.FormDetalleDeVenta();
        //  this.Hide();
        //formularioDeDetalleDeVenta.ShowDialog();
    }
    

}
