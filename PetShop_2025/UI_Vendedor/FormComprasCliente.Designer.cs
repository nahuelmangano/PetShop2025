namespace PetShop_2025.UI_Vendedor
{
    partial class FormComprasCliente
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
            this.dgvComprasCliente = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnDetalleVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComprasCliente
            // 
            this.dgvComprasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasCliente.Location = new System.Drawing.Point(121, 26);
            this.dgvComprasCliente.Name = "dgvComprasCliente";
            this.dgvComprasCliente.Size = new System.Drawing.Size(543, 150);
            this.dgvComprasCliente.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(589, 375);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnDetalleVenta
            // 
            this.btnDetalleVenta.Location = new System.Drawing.Point(229, 357);
            this.btnDetalleVenta.Name = "btnDetalleVenta";
            this.btnDetalleVenta.Size = new System.Drawing.Size(104, 23);
            this.btnDetalleVenta.TabIndex = 2;
            this.btnDetalleVenta.Text = "Detalle de Venta";
            this.btnDetalleVenta.UseVisualStyleBackColor = true;
            this.btnDetalleVenta.Click += new System.EventHandler(this.btnDetalleVenta_Click);
            // 
            // FormComprasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetalleVenta);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvComprasCliente);
            this.Name = "FormComprasCliente";
            this.Text = "FormComprasCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComprasCliente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnDetalleVenta;
    }
}