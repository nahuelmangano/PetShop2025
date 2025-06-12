namespace PetShop_2025.UI_Veterinario
{
    partial class AplicarVacuna
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
            this.nudNumeroDosis = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroDosis = new System.Windows.Forms.Label();
            this.lblVacuna = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.cmbVacuna = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDosis)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumeroDosis
            // 
            this.nudNumeroDosis.Location = new System.Drawing.Point(84, 83);
            this.nudNumeroDosis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroDosis.Name = "nudNumeroDosis";
            this.nudNumeroDosis.Size = new System.Drawing.Size(70, 20);
            this.nudNumeroDosis.TabIndex = 14;
            this.nudNumeroDosis.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumeroDosis
            // 
            this.lblNumeroDosis.AutoSize = true;
            this.lblNumeroDosis.Location = new System.Drawing.Point(12, 85);
            this.lblNumeroDosis.Name = "lblNumeroDosis";
            this.lblNumeroDosis.Size = new System.Drawing.Size(66, 13);
            this.lblNumeroDosis.TabIndex = 12;
            this.lblNumeroDosis.Text = "Nº de Dosis:";
            // 
            // lblVacuna
            // 
            this.lblVacuna.AutoSize = true;
            this.lblVacuna.Location = new System.Drawing.Point(12, 43);
            this.lblVacuna.Name = "lblVacuna";
            this.lblVacuna.Size = new System.Drawing.Size(47, 13);
            this.lblVacuna.TabIndex = 11;
            this.lblVacuna.Text = "Vacuna:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(278, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(15, 169);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 8;
            this.btnAplicar.Text = "➕ Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // cmbVacuna
            // 
            this.cmbVacuna.FormattingEnabled = true;
            this.cmbVacuna.Location = new System.Drawing.Point(65, 40);
            this.cmbVacuna.Name = "cmbVacuna";
            this.cmbVacuna.Size = new System.Drawing.Size(295, 21);
            this.cmbVacuna.TabIndex = 15;
            // 
            // AplicarVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 211);
            this.Controls.Add(this.cmbVacuna);
            this.Controls.Add(this.nudNumeroDosis);
            this.Controls.Add(this.lblNumeroDosis);
            this.Controls.Add(this.lblVacuna);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Name = "AplicarVacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicar Vacuna";
            this.Load += new System.EventHandler(this.AplicarVacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudNumeroDosis;
        private System.Windows.Forms.Label lblNumeroDosis;
        private System.Windows.Forms.Label lblVacuna;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.ComboBox cmbVacuna;
    }
}