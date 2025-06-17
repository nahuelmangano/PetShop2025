namespace PetShop_2025.UI_Vendedor
{
    partial class FormListarClientes
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
            this.dgvListarClientes = new System.Windows.Forms.DataGridView();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.btnVerComprasCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar Clientes";
            // 
            // dgvListarClientes
            // 
            this.dgvListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarClientes.Location = new System.Drawing.Point(98, 106);
            this.dgvListarClientes.Name = "dgvListarClientes";
            this.dgvListarClientes.Size = new System.Drawing.Size(554, 150);
            this.dgvListarClientes.TabIndex = 1;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(98, 332);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(91, 23);
            this.btnEditarCliente.TabIndex = 2;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(576, 332);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.Location = new System.Drawing.Point(356, 332);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(95, 23);
            this.btnActualizarLista.TabIndex = 4;
            this.btnActualizarLista.Text = "Actualizar Listar";
            this.btnActualizarLista.UseVisualStyleBackColor = true;
            this.btnActualizarLista.Click += new System.EventHandler(this.btnActualizarLista_Click);
            // 
            // btnVerComprasCliente
            // 
            this.btnVerComprasCliente.Location = new System.Drawing.Point(297, 386);
            this.btnVerComprasCliente.Name = "btnVerComprasCliente";
            this.btnVerComprasCliente.Size = new System.Drawing.Size(83, 23);
            this.btnVerComprasCliente.TabIndex = 5;
            this.btnVerComprasCliente.Text = "Ver compras";
            this.btnVerComprasCliente.UseVisualStyleBackColor = true;
            this.btnVerComprasCliente.Click += new System.EventHandler(this.btnVerComprasCliente_Click);
            // 
            // FormListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerComprasCliente);
            this.Controls.Add(this.btnActualizarLista);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.dgvListarClientes);
            this.Controls.Add(this.label1);
            this.Name = "FormListarClientes";
            this.Text = "FormListarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListarClientes;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.Button btnVerComprasCliente;
    }
}