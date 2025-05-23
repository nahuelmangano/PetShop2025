namespace PetShop_2025
{
    partial class f_LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.tb_Contraseña = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(216, 202);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(75, 23);
            this.btn_LogIn.TabIndex = 0;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(360, 202);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(275, 102);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 2;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(275, 141);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 3;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Location = new System.Drawing.Point(278, 118);
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_Usuario.TabIndex = 4;
            // 
            // tb_Contraseña
            // 
            this.tb_Contraseña.Location = new System.Drawing.Point(278, 157);
            this.tb_Contraseña.Name = "tb_Contraseña";
            this.tb_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.tb_Contraseña.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(396, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // f_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tb_Contraseña);
            this.Controls.Add(this.tb_Usuario);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_LogIn);
            this.Name = "f_LogIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.TextBox tb_Contraseña;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

