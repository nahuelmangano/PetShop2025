namespace PetShop_2025.UI_Veterinario
{
    partial class NuevoIngreso
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
            this.gBoxBuscarCliente = new System.Windows.Forms.GroupBox();
            this.lblBuscarDNI = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tBoxNombre = new System.Windows.Forms.TextBox();
            this.tBoxApellido = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.nudDNI = new System.Windows.Forms.NumericUpDown();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudBuscarDNI = new System.Windows.Forms.NumericUpDown();
            this.gBoxBuscarCliente.SuspendLayout();
            this.gBoxDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuscarDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxBuscarCliente
            // 
            this.gBoxBuscarCliente.Controls.Add(this.btnBuscar);
            this.gBoxBuscarCliente.Controls.Add(this.nudBuscarDNI);
            this.gBoxBuscarCliente.Controls.Add(this.lblBuscarDNI);
            this.gBoxBuscarCliente.Location = new System.Drawing.Point(12, 12);
            this.gBoxBuscarCliente.Name = "gBoxBuscarCliente";
            this.gBoxBuscarCliente.Size = new System.Drawing.Size(376, 66);
            this.gBoxBuscarCliente.TabIndex = 0;
            this.gBoxBuscarCliente.TabStop = false;
            this.gBoxBuscarCliente.Text = "Buscar Cliente";
            // 
            // lblBuscarDNI
            // 
            this.lblBuscarDNI.AutoSize = true;
            this.lblBuscarDNI.Location = new System.Drawing.Point(30, 33);
            this.lblBuscarDNI.Name = "lblBuscarDNI";
            this.lblBuscarDNI.Size = new System.Drawing.Size(32, 13);
            this.lblBuscarDNI.TabIndex = 0;
            this.lblBuscarDNI.Text = "DNI: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(265, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gBoxDatosCliente
            // 
            this.gBoxDatosCliente.Controls.Add(this.nudDNI);
            this.gBoxDatosCliente.Controls.Add(this.tBoxEmail);
            this.gBoxDatosCliente.Controls.Add(this.tBoxApellido);
            this.gBoxDatosCliente.Controls.Add(this.tBoxNombre);
            this.gBoxDatosCliente.Controls.Add(this.lblEmail);
            this.gBoxDatosCliente.Controls.Add(this.lblDNI);
            this.gBoxDatosCliente.Controls.Add(this.lblApellido);
            this.gBoxDatosCliente.Controls.Add(this.lblNombre);
            this.gBoxDatosCliente.Location = new System.Drawing.Point(12, 88);
            this.gBoxDatosCliente.Name = "gBoxDatosCliente";
            this.gBoxDatosCliente.Size = new System.Drawing.Size(376, 185);
            this.gBoxDatosCliente.TabIndex = 1;
            this.gBoxDatosCliente.TabStop = false;
            this.gBoxDatosCliente.Text = "Datos del Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(33, 90);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // tBoxNombre
            // 
            this.tBoxNombre.Location = new System.Drawing.Point(68, 27);
            this.tBoxNombre.Name = "tBoxNombre";
            this.tBoxNombre.Size = new System.Drawing.Size(148, 20);
            this.tBoxNombre.TabIndex = 4;
            // 
            // tBoxApellido
            // 
            this.tBoxApellido.Location = new System.Drawing.Point(68, 57);
            this.tBoxApellido.Name = "tBoxApellido";
            this.tBoxApellido.Size = new System.Drawing.Size(148, 20);
            this.tBoxApellido.TabIndex = 5;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(68, 123);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(148, 20);
            this.tBoxEmail.TabIndex = 6;
            // 
            // nudDNI
            // 
            this.nudDNI.Location = new System.Drawing.Point(68, 88);
            this.nudDNI.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudDNI.Name = "nudDNI";
            this.nudDNI.Size = new System.Drawing.Size(148, 20);
            this.nudDNI.TabIndex = 3;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(197, 293);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudBuscarDNI
            // 
            this.nudBuscarDNI.Location = new System.Drawing.Point(68, 31);
            this.nudBuscarDNI.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudBuscarDNI.Name = "nudBuscarDNI";
            this.nudBuscarDNI.Size = new System.Drawing.Size(148, 20);
            this.nudBuscarDNI.TabIndex = 1;
            // 
            // NuevoIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 328);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.gBoxDatosCliente);
            this.Controls.Add(this.gBoxBuscarCliente);
            this.Name = "NuevoIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Ingreso";
            this.Load += new System.EventHandler(this.NuevoIngreso_Load);
            this.gBoxBuscarCliente.ResumeLayout(false);
            this.gBoxBuscarCliente.PerformLayout();
            this.gBoxDatosCliente.ResumeLayout(false);
            this.gBoxDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuscarDNI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxBuscarCliente;
        private System.Windows.Forms.Label lblBuscarDNI;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gBoxDatosCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.NumericUpDown nudDNI;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxApellido;
        private System.Windows.Forms.TextBox tBoxNombre;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudBuscarDNI;
    }
}