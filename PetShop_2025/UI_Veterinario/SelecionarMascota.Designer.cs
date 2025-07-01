namespace PetShop_2025.UI_Veterinario
{
    partial class SelecionarMascota
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnNuevoIngreso = new System.Windows.Forms.RadioButton();
            this.rbtnSeleccionarMascota = new System.Windows.Forms.RadioButton();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gBoxSeleccionarMascota = new System.Windows.Forms.GroupBox();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.gBoxSeleccionarMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indicar si es un Nuevo Ingreso o Seleccionar una Mascota:";
            // 
            // rbtnNuevoIngreso
            // 
            this.rbtnNuevoIngreso.AutoSize = true;
            this.rbtnNuevoIngreso.Location = new System.Drawing.Point(24, 36);
            this.rbtnNuevoIngreso.Name = "rbtnNuevoIngreso";
            this.rbtnNuevoIngreso.Size = new System.Drawing.Size(95, 17);
            this.rbtnNuevoIngreso.TabIndex = 1;
            this.rbtnNuevoIngreso.TabStop = true;
            this.rbtnNuevoIngreso.Text = "Nuevo Ingreso";
            this.rbtnNuevoIngreso.UseVisualStyleBackColor = true;
            // 
            // rbtnSeleccionarMascota
            // 
            this.rbtnSeleccionarMascota.AutoSize = true;
            this.rbtnSeleccionarMascota.Location = new System.Drawing.Point(24, 59);
            this.rbtnSeleccionarMascota.Name = "rbtnSeleccionarMascota";
            this.rbtnSeleccionarMascota.Size = new System.Drawing.Size(125, 17);
            this.rbtnSeleccionarMascota.TabIndex = 2;
            this.rbtnSeleccionarMascota.TabStop = true;
            this.rbtnSeleccionarMascota.Text = "Seleccionar Mascota";
            this.rbtnSeleccionarMascota.UseVisualStyleBackColor = true;
            this.rbtnSeleccionarMascota.CheckedChanged += new System.EventHandler(this.rbtnSeleccionarMascota_CheckedChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContinuar.Location = new System.Drawing.Point(444, 581);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(545, 581);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gBoxSeleccionarMascota
            // 
            this.gBoxSeleccionarMascota.Controls.Add(this.dgvMascotas);
            this.gBoxSeleccionarMascota.Location = new System.Drawing.Point(24, 82);
            this.gBoxSeleccionarMascota.Name = "gBoxSeleccionarMascota";
            this.gBoxSeleccionarMascota.Size = new System.Drawing.Size(604, 460);
            this.gBoxSeleccionarMascota.TabIndex = 5;
            this.gBoxSeleccionarMascota.TabStop = false;
            this.gBoxSeleccionarMascota.Text = "Seleccionar Mascota";
            this.gBoxSeleccionarMascota.Visible = false;
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(6, 19);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.Size = new System.Drawing.Size(590, 435);
            this.dgvMascotas.TabIndex = 0;
            // 
            // SelecionarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 616);
            this.Controls.Add(this.gBoxSeleccionarMascota);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.rbtnSeleccionarMascota);
            this.Controls.Add(this.rbtnNuevoIngreso);
            this.Controls.Add(this.label1);
            this.Name = "SelecionarMascota";
            this.Text = "Nueva Consulta";
            this.Load += new System.EventHandler(this.SelecionarMascota_Load);
            this.gBoxSeleccionarMascota.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnNuevoIngreso;
        private System.Windows.Forms.RadioButton rbtnSeleccionarMascota;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gBoxSeleccionarMascota;
        private System.Windows.Forms.DataGridView dgvMascotas;
    }
}