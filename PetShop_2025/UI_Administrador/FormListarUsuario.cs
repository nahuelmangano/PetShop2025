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
        private Form formularioAnterior;
        public FormListarUsuario(Form form)
        {
            InitializeComponent();
            formularioAnterior = form;
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

                // mostrar el nombre del perfil en una columna aparte:
                // usar un BindingList o transformar la lista a una anónima con Select, 
                // o agregar una propiedad extra en BE.Usuario que devuelva el perfil.Nombre
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Form formularioDePanelAdmin = new UI_Administrador.FormPanelAdmin();    
            this.Close();
            formularioAnterior.Show();
        }

        private void btn_EditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgwListarUsuarios.SelectedRows.Count == 1)
            {
                var usuarioSeleccionado = (BE.Usuario)dgwListarUsuarios.SelectedRows[0].DataBoundItem;
                var formEditar = new UI_Administrador.FormEditarUsuario(this, usuarioSeleccionado); // este formulario lo creamos ahora
                this.Hide();
                formEditar.Show();
            }
            else
            {
                MessageBox.Show("Por favor seleccioná un usuario para editar.");
            }
        }
    }
    }

   