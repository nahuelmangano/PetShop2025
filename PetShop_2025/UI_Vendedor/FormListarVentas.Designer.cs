namespace PetShop_2025.UI_Vendedor
{
    partial class FormListarVentas
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
            this.dgvListarVentas = new System.Windows.Forms.DataGridView();
            this.btnAtas = new System.Windows.Forms.Button();
            this.btnDetalleVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarVentas
            // 
            this.dgvListarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarVentas.Location = new System.Drawing.Point(100, 41);
            this.dgvListarVentas.Name = "dgvListarVentas";
            this.dgvListarVentas.Size = new System.Drawing.Size(547, 309);
            this.dgvListarVentas.TabIndex = 0;
            // 
            // btnAtas
            // 
            this.btnAtas.Location = new System.Drawing.Point(677, 390);
            this.btnAtas.Name = "btnAtas";
            this.btnAtas.Size = new System.Drawing.Size(75, 23);
            this.btnAtas.TabIndex = 1;
            this.btnAtas.Text = "Atras";
            this.btnAtas.UseVisualStyleBackColor = true;
            this.btnAtas.Click += new System.EventHandler(this.btnAtas_Click);
            // 
            // btnDetalleVenta
            // 
            this.btnDetalleVenta.Location = new System.Drawing.Point(274, 389);
            this.btnDetalleVenta.Name = "btnDetalleVenta";
            this.btnDetalleVenta.Size = new System.Drawing.Size(147, 23);
            this.btnDetalleVenta.TabIndex = 2;
            this.btnDetalleVenta.Text = "Ver Detalle de Venta";
            this.btnDetalleVenta.UseVisualStyleBackColor = true;
            this.btnDetalleVenta.Click += new System.EventHandler(this.btnDetalleVenta_Click);
            // 
            // FormListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetalleVenta);
            this.Controls.Add(this.btnAtas);
            this.Controls.Add(this.dgvListarVentas);
            this.Name = "FormListarVentas";
            this.Text = "FormListarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarVentas;
        private System.Windows.Forms.Button btnAtas;
        private System.Windows.Forms.Button btnDetalleVenta;
    }
}