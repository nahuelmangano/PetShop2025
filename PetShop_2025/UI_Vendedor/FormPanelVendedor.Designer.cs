namespace PetShop_2025.UI_Vendedor
{
    partial class FormPanelVendedor
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
            this.btn_EditarUsuario = new System.Windows.Forms.Button();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_BuscarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.Location = new System.Drawing.Point(335, 96);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Size = new System.Drawing.Size(119, 23);
            this.btn_EditarUsuario.TabIndex = 0;
            this.btn_EditarUsuario.Text = "Editar Usuario";
            this.btn_EditarUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.Location = new System.Drawing.Point(335, 53);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(119, 23);
            this.btn_CrearUsuario.TabIndex = 0;
            this.btn_CrearUsuario.Text = "Crear Usuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(644, 331);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_BuscarUsuario
            // 
            this.btn_BuscarUsuario.Location = new System.Drawing.Point(335, 134);
            this.btn_BuscarUsuario.Name = "btn_BuscarUsuario";
            this.btn_BuscarUsuario.Size = new System.Drawing.Size(119, 23);
            this.btn_BuscarUsuario.TabIndex = 0;
            this.btn_BuscarUsuario.Text = "Buscar Usuario";
            this.btn_BuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // FormPanelVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.btn_BuscarUsuario);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_EditarUsuario);
            this.Name = "FormPanelVendedor";
            this.Text = "FormPanelVendedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_EditarUsuario;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_BuscarUsuario;
    }
}