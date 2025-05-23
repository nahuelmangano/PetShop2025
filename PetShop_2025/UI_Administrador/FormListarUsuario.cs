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
    public partial class FormListarUsuario : Form
    {
        public FormListarUsuario()
        {
            InitializeComponent();
            CargarUsuarios();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgwListarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void CargarUsuarios()
        {
            BLL.Usuario bllUsuario = new BLL.Usuario();

            try
            {
                List<BE.Usuario> listaUsuarios = bllUsuario.ListarUsuarios();

                dgwListarUsuarios.DataSource = null;  // Limpiar si había datos previos
                dgwListarUsuarios.DataSource = listaUsuarios;

                // Opcional: ajustar columnas, encabezados, ocultar Password por seguridad
                //dgwListarUsuarios.Columns["Password"].Visible = false;
                //dgwListarUsuarios.Columns["Perfil"].Visible = false; // Si no querés mostrar el objeto Perfil entero

                // Si querés mostrar el nombre del perfil en una columna aparte:
                // Podrías usar un BindingList o transformar la lista a una anónima con Select, 
                // o agregar una propiedad extra en BE.Usuario que devuelva el perfil.Nombre
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

   