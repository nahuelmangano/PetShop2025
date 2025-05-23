namespace PetShop_2025
{
    partial class f_PanelAdmin
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
            this.lbl_PanelAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_PanelAdmin
            // 
            this.lbl_PanelAdmin.AutoSize = true;
            this.lbl_PanelAdmin.Location = new System.Drawing.Point(255, 184);
            this.lbl_PanelAdmin.Name = "lbl_PanelAdmin";
            this.lbl_PanelAdmin.Size = new System.Drawing.Size(84, 13);
            this.lbl_PanelAdmin.TabIndex = 0;
            this.lbl_PanelAdmin.Text = "Panel ADMIN ! !";
            // 
            // f_PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_PanelAdmin);
            this.Name = "f_PanelAdmin";
            this.Text = "f_PanelAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PanelAdmin;
    }
}