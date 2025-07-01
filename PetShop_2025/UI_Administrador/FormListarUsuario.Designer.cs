namespace PetShop_2025.UI_Administrador
{
    partial class FormListarUsuario
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
            this.dgwListarUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btn_EditarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwListarUsuarios
            // 
            this.dgwListarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListarUsuarios.Location = new System.Drawing.Point(74, 98);
            this.dgwListarUsuarios.Name = "dgwListarUsuarios";
            this.dgwListarUsuarios.Size = new System.Drawing.Size(643, 236);
            this.dgwListarUsuarios.TabIndex = 0;
            this.dgwListarUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListarUsuarios_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(650, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.Location = new System.Drawing.Point(184, 391);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Size = new System.Drawing.Size(138, 23);
            this.btn_EditarUsuario.TabIndex = 2;
            this.btn_EditarUsuario.Text = "Editar Usuario";
            this.btn_EditarUsuario.UseVisualStyleBackColor = true;
            this.btn_EditarUsuario.Click += new System.EventHandler(this.btn_EditarUsuario_Click);
            // 
            // FormListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_EditarUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgwListarUsuarios);
            this.Name = "FormListarUsuario";
            this.Text = "FormListarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgwListarUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwListarUsuarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btn_EditarUsuario;
    }
}