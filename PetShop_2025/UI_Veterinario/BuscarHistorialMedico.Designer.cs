namespace PetShop_2025.UI_Veterinario
{
    partial class BuscarHistorialMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDNIPropietario = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblHistorialesEncontrados = new System.Windows.Forms.Label();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvHistorialesEncontrados = new System.Windows.Forms.DataGridView();
            this.txtDNIPropietario = new System.Windows.Forms.TextBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialesEncontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDNIPropietario
            // 
            this.lblDNIPropietario.AutoSize = true;
            this.lblDNIPropietario.Location = new System.Drawing.Point(12, 25);
            this.lblDNIPropietario.Name = "lblDNIPropietario";
            this.lblDNIPropietario.Size = new System.Drawing.Size(82, 13);
            this.lblDNIPropietario.TabIndex = 0;
            this.lblDNIPropietario.Text = "DNI Propietario:";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Location = new System.Drawing.Point(206, 25);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(106, 13);
            this.lblNombreMascota.TabIndex = 1;
            this.lblNombreMascota.Text = "Nombre de Mascota:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(422, 25);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Especie:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(12, 59);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(72, 13);
            this.lblFechaDesde.TabIndex = 3;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(243, 60);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 13);
            this.lblFechaHasta.TabIndex = 4;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(501, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 27);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblHistorialesEncontrados
            // 
            this.lblHistorialesEncontrados.AutoSize = true;
            this.lblHistorialesEncontrados.Location = new System.Drawing.Point(12, 107);
            this.lblHistorialesEncontrados.Name = "lblHistorialesEncontrados";
            this.lblHistorialesEncontrados.Size = new System.Drawing.Size(120, 13);
            this.lblHistorialesEncontrados.TabIndex = 6;
            this.lblHistorialesEncontrados.Text = "Historiales encontrados:";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(425, 356);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(75, 31);
            this.btnVerDetalle.TabIndex = 7;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(517, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvHistorialesEncontrados
            // 
            this.dgvHistorialesEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialesEncontrados.Location = new System.Drawing.Point(15, 123);
            this.dgvHistorialesEncontrados.Name = "dgvHistorialesEncontrados";
            this.dgvHistorialesEncontrados.Size = new System.Drawing.Size(577, 191);
            this.dgvHistorialesEncontrados.TabIndex = 9;
            // 
            // txtDNIPropietario
            // 
            this.txtDNIPropietario.Location = new System.Drawing.Point(100, 22);
            this.txtDNIPropietario.Name = "txtDNIPropietario";
            this.txtDNIPropietario.Size = new System.Drawing.Size(100, 20);
            this.txtDNIPropietario.TabIndex = 10;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(316, 22);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMascota.TabIndex = 11;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(476, 22);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtEspecie.TabIndex = 12;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(90, 53);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(110, 20);
            this.dtpFechaDesde.TabIndex = 13;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(316, 54);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(110, 20);
            this.dtpFechaHasta.TabIndex = 14;
            // 
            // BuscarHistorialMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 410);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.txtDNIPropietario);
            this.Controls.Add(this.dgvHistorialesEncontrados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.lblHistorialesEncontrados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblNombreMascota);
            this.Controls.Add(this.lblDNIPropietario);
            this.Name = "BuscarHistorialMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Historial Médico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialesEncontrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNIPropietario;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblHistorialesEncontrados;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvHistorialesEncontrados;
        private System.Windows.Forms.TextBox txtDNIPropietario;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
    }
}