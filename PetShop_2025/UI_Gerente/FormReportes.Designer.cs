namespace PetShop_2025.UI_Gerente
{
    partial class FormReportes
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
            this.lbl_Reportes = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Reportes
            // 
            this.lbl_Reportes.AutoSize = true;
            this.lbl_Reportes.Location = new System.Drawing.Point(218, 119);
            this.lbl_Reportes.Name = "lbl_Reportes";
            this.lbl_Reportes.Size = new System.Drawing.Size(121, 13);
            this.lbl_Reportes.TabIndex = 0;
            this.lbl_Reportes.Text = "REPORTES GERENTE";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(614, 321);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Reportes);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Reportes;
        private System.Windows.Forms.Button btn_Salir;
    }
}