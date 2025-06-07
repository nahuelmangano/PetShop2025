namespace PetShop_2025.UI_Veterinario
{
    partial class MenuPrincipal
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
            this.btnGestionarMedicamentos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAtenderMascota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionarMedicamentos
            // 
            this.btnGestionarMedicamentos.Location = new System.Drawing.Point(311, 154);
            this.btnGestionarMedicamentos.Name = "btnGestionarMedicamentos";
            this.btnGestionarMedicamentos.Size = new System.Drawing.Size(139, 39);
            this.btnGestionarMedicamentos.TabIndex = 0;
            this.btnGestionarMedicamentos.Text = "Gestionar Medicamentos";
            this.btnGestionarMedicamentos.UseVisualStyleBackColor = true;
            this.btnGestionarMedicamentos.Click += new System.EventHandler(this.btnGestionarMedicamentos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(627, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAtenderMascota
            // 
            this.btnAtenderMascota.Location = new System.Drawing.Point(311, 83);
            this.btnAtenderMascota.Name = "btnAtenderMascota";
            this.btnAtenderMascota.Size = new System.Drawing.Size(139, 39);
            this.btnAtenderMascota.TabIndex = 2;
            this.btnAtenderMascota.Text = "Atender Mascota";
            this.btnAtenderMascota.UseVisualStyleBackColor = true;
            this.btnAtenderMascota.Click += new System.EventHandler(this.btnAtenderMascota_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtenderMascota);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestionarMedicamentos);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarMedicamentos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAtenderMascota;
    }
}