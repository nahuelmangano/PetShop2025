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
            this.btnListarCliente = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnCrearVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnListarVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(335, 96);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(119, 23);
            this.btnListarCliente.TabIndex = 0;
            this.btnListarCliente.Text = "Listar Cliente";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click);
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Location = new System.Drawing.Point(335, 53);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(119, 23);
            this.btnCrearCliente.TabIndex = 0;
            this.btnCrearCliente.Text = "Crear Cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
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
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(335, 134);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(119, 23);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.Location = new System.Drawing.Point(60, 53);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(119, 23);
            this.btnCrearVenta.TabIndex = 1;
            this.btnCrearVenta.Text = "Crear Venta";
            this.btnCrearVenta.UseVisualStyleBackColor = true;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(91, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "label2";
            // 
            // btnListarVentas
            // 
            this.btnListarVentas.Location = new System.Drawing.Point(60, 96);
            this.btnListarVentas.Name = "btnListarVentas";
            this.btnListarVentas.Size = new System.Drawing.Size(119, 23);
            this.btnListarVentas.TabIndex = 4;
            this.btnListarVentas.Text = "Lista de Ventas";
            this.btnListarVentas.UseVisualStyleBackColor = true;
            this.btnListarVentas.Click += new System.EventHandler(this.btnListarVentas_Click);
            // 
            // FormPanelVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarVentas);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btnListarCliente);
            this.Name = "FormPanelVendedor";
            this.Text = "FormPanelVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnCrearVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnListarVentas;
    }
}