using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_2025.UI_Veterinario
{
    public partial class NuevaConsulta : Form
    {
        private BE.Mascota mascotaSeleccionada;
        private List<BE.VacunaAplicada> vacunasAplicadas = new List<BE.VacunaAplicada>();
        private bool esNuevoIngreso; // Indica si es un nuevo ingreso

        public NuevaConsulta(BE.Mascota mascota)
        {
            InitializeComponent();
            this.mascotaSeleccionada =  mascota;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposFormulario();

                // Asignar los datos de la mascota
                // Asignar los datos del cliente
                // Asignar datos de la consulta
                
            }
            catch (BE.ExcepcionDeNegocio ex)
            {
                MessageBox.Show(ex.Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnAplicarVacuna_Click(object sender, EventArgs e)
        {
            Form formAplicarVacuna = new UI_Veterinario.AplicarVacuna(vacunasAplicadas);
            formAplicarVacuna.ShowDialog();
            ActualizarDGVVacunasAplicadas();


        }

        private void NuevaConsulta_Load(object sender, EventArgs e)
        {
            // Formato del formulario al cargar
            dgvVacunasAplicadas.CellFormatting += dgvVacunasAplicadas_CellFormatting; // Evento para formatear las celdas de la grilla

            // Establecer los valores por defecto de los campos del formulario
            dtpFechaNacimiento.MaxDate = DateTime.Now; // Establecer la fecha máxima de nacimiento a la fecha actual
            dtpFechaConsulta.Value = DateTime.Now; // Establecer la fecha de la consulta a la fecha actual
            dtpFechaConsulta.Enabled = false; // Deshabilitar el campo de fecha de consulta para que no se pueda modificar

            // Rellenar los ComboBox de la mascota
            RellenarCMBEsterilizada();
            RellenarCMBSexo();

            if (mascotaSeleccionada != null)
            {
                // Si se ha pasado una mascota, cargar sus datos en el formulario
                RellenarCamposMascota();
                // Cargar los datos del cliente asociado a la mascota
                RellenarCamposPropietario();
                // Buscar las vacunas aplicadas a la mascota
                BuscarVacunasAplicadas();
                // Actualizar la grilla de vacunas aplicadas
                ActualizarDGVVacunasAplicadas();
                esNuevoIngreso = false; // Indicar que no es un nuevo ingreso
            }
            else
            {
                // Si no se ha pasado una mascota, inicializar un nuevo objeto mascota
                mascotaSeleccionada = new BE.Mascota();
                mascotaSeleccionada.Propietario = new BE.Cliente(); // Inicializar el propietario
                esNuevoIngreso = true; // Indicar que es un nuevo ingreso
            }
        }

        private void RellenarCMBSexo()
        {
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Macho");
            cmbSexo.Items.Add("Hembra");
            cmbSexo.SelectedIndex = 0; // Seleccionar el primer elemento por defecto
        }

        private void RellenarCMBEsterilizada()
        {
            cmbEsterilizada.DataSource = new[]
            {
                new { Texto = "Si", Valor = true },
                new { Texto = "No", Valor = false }
            };

            cmbEsterilizada.DisplayMember = "Texto";
            cmbEsterilizada.ValueMember = "Valor";
        }

        private void ActualizarDGVVacunasAplicadas()
        {
            dgvVacunasAplicadas.AutoGenerateColumns = false;
            dgvVacunasAplicadas.Columns.Clear();

            // Columna Nombre de la Vacuna y Cantidad de Dosis
            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre (Cant. Dosis)";
            colNombre.DataPropertyName = "Vacuna"; 
            dgvVacunasAplicadas.Columns.Add(colNombre);

            // Columna Dosis Aplicadas
            var colDosis = new DataGridViewTextBoxColumn();
            colDosis.HeaderText = "Dosis Aplicadas";
            colDosis.DataPropertyName = "NumeroDosis";
            dgvVacunasAplicadas.Columns.Add(colDosis);

            // Columna Fecha
            var colFecha = new DataGridViewTextBoxColumn();
            colFecha.HeaderText = "Fecha"; // Lo manejamos en CellFormatting
            colFecha.DataPropertyName = "FechaAplicacion"; 
            dgvVacunasAplicadas.Columns.Add(colFecha);


            dgvVacunasAplicadas.DataSource = null;
            dgvVacunasAplicadas.DataSource = vacunasAplicadas;

        }

        private void dgvVacunasAplicadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVacunasAplicadas.Columns[e.ColumnIndex].HeaderText == "Fecha")
            {
                if (e.Value is DateTime fecha)
                {
                    e.Value = fecha.ToShortDateString(); // Mostrar solo la fecha, sin hora
                }
            }
        }

        private void RellenarCamposMascota()
        {
            // Asignar los valores del objeto mascotaSeleccionada a los campos del formulario
            txtNombreMascota.Text = mascotaSeleccionada.Nombre;
            txtEspecie.Text = mascotaSeleccionada.Especie;
            cmbSexo.SelectedItem = mascotaSeleccionada.Sexo;
            nudPeso.Value = mascotaSeleccionada.Peso;
            txtRaza.Text = mascotaSeleccionada.Raza;
            dtpFechaNacimiento.Value = mascotaSeleccionada.FechaNacimiento;
            txtColor.Text = mascotaSeleccionada.Color;
            cmbEsterilizada.SelectedValue = mascotaSeleccionada.Esterilizada;
            gBoxMascota.Enabled = false; // Deshabilitar el grupo de campos de la mascota para evitar modificaciones
        }

        private void RellenarCamposPropietario()
        {
            // Asignar los valores del objeto mascotaSeleccionada.Propietario a los campos del formulario
            if (mascotaSeleccionada.Propietario != null)
            {
                txtNombreCliente.Text = mascotaSeleccionada.Propietario.Nombre;
                txtApellidoCliente.Text = mascotaSeleccionada.Propietario.Apellido;
                nudDNICliente.Value = mascotaSeleccionada.Propietario.DNI;
                txtEmailCliente.Text = mascotaSeleccionada.Propietario.Email;
                gBoxPropietario.Enabled = false; // Deshabilitar el grupo de campos del propietario para evitar modificaciones
            }
        }

        private void BuscarVacunasAplicadas()
        {
            BLL.VacunaAplicada vacunasEncontradas = new BLL.VacunaAplicada();
            if (mascotaSeleccionada != null && mascotaSeleccionada.ID > 0)
            {
                // Buscar las vacunas aplicadas a la mascota seleccionada
                vacunasAplicadas = vacunasEncontradas.ListarPorMascota(mascotaSeleccionada.ID);
            }
        }

        #region Validaciones de campos
        private void ValidarCamposFormulario()
        {
            ValidarCamposMascota();

            ValidarCamposCliente();

            ValidarCamposConsulta();
        }
        private void ValidarCamposMascota() // Validar que se haya completado los datos de la mascota
        {
            if (string.IsNullOrWhiteSpace(txtNombreMascota.Text))   //Nombre de la mascota
            {
                throw new BE.ExcepcionDeNegocio("El campo 'nombre' de la mascota es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(txtEspecie.Text)) //Especie de la mascota
            {
                throw new BE.ExcepcionDeNegocio("El campo 'especie' de la mascota es obligatorio.");
            }
            if (cmbSexo.SelectedItem is null) //Sexo de la mascota
            {
                throw new BE.ExcepcionDeNegocio("Debe seleccionar el 'Sexo' de la mascota.");
            }
            if (nudPeso.Value <= 0) // Peso de la mascota
            {
                throw new BE.ExcepcionDeNegocio("El peso no puede ser negativo o igual a cero.");
            }
            if (string.IsNullOrWhiteSpace(txtRaza.Text)) // Raza de la mascota
            {
                throw new BE.ExcepcionDeNegocio("El campo 'raza' de la mascota es obligatorio.");
            }
            if (dtpFechaNacimiento.Value >= DateTime.Now) // Fecha de nacimiento de la mascota
            {
                throw new BE.ExcepcionDeNegocio("La fecha de nacimiento no puede ser mayor o igual a la fecha actual.");
            }
            if (string.IsNullOrWhiteSpace(txtColor.Text)) // Color de la mascota
            {
                throw new BE.ExcepcionDeNegocio("El campo 'color' de la mascota es obligatorio.");
            }
            if (cmbEsterilizada.SelectedItem is null) // Estado de esterilización de la mascota
            {
                throw new BE.ExcepcionDeNegocio("Debe seleccionar el estado de 'Esterilización' de la mascota.");
            }
        }
        private void ValidarCamposCliente() // Validar que se haya completado los datos del cliente
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text)) // Nombre del cliente
            {
                throw new BE.ExcepcionDeNegocio("El campo 'nombre' del cliente es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(txtApellidoCliente.Text)) // Apellido del cliente
            {
                throw new BE.ExcepcionDeNegocio("El campo 'apellido' del cliente es obligatorio.");
            }
            if (nudDNICliente.Value <= 0) // DNI del cliente
            {
                throw new BE.ExcepcionDeNegocio("El campo 'DNI' del cliente es obligatorio y debe ser mayor a cero.");
            }
            if (string.IsNullOrWhiteSpace(txtEmailCliente.Text)) // Email del cliente
            {
                throw new BE.ExcepcionDeNegocio("El campo 'email' del cliente es obligatorio.");
            }
        }
        private void ValidarCamposConsulta() // Validar que se haya completado los datos de la consulta
        {
            if (string.IsNullOrWhiteSpace(txtMotivo.Text)) // Motivo de la consulta
            {
                throw new BE.ExcepcionDeNegocio("El campo 'motivo' de la consulta es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text)) // Diagnóstico de la consulta
            {
                throw new BE.ExcepcionDeNegocio("El campo 'diagnóstico' de la consulta es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(txtTratamiento.Text)) // Tratamiento de la consulta
            {
                throw new BE.ExcepcionDeNegocio("El campo 'tratamiento' de la consulta es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(txtObservaciones.Text)) // Observaciones de la consulta
            {
                throw new BE.ExcepcionDeNegocio("El campo 'observaciones' de la consulta es obligatorio.");
            }
        }
        #endregion
    }
}
