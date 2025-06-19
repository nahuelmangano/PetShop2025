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
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(322, 465);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(421, 465);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // SelecionarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 500);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.rbtnSeleccionarMascota);
            this.Controls.Add(this.rbtnNuevoIngreso);
            this.Controls.Add(this.label1);
            this.Name = "SelecionarMascota";
            this.Text = "Nueva Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnNuevoIngreso;
        private System.Windows.Forms.RadioButton rbtnSeleccionarMascota;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
    }
}