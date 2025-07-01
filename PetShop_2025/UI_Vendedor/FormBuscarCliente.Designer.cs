namespace PetShop_2025.UI_Vendedor
{
    partial class FormBuscarCliente
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
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.cbCriterioBusqueda = new System.Windows.Forms.ComboBox();
            this.dgvResultadoCliente = new System.Windows.Forms.DataGridView();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(293, 38);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCliente.TabIndex = 0;
            // 
            // cbCriterioBusqueda
            // 
            this.cbCriterioBusqueda.FormattingEnabled = true;
            this.cbCriterioBusqueda.Location = new System.Drawing.Point(293, 95);
            this.cbCriterioBusqueda.Name = "cbCriterioBusqueda";
            this.cbCriterioBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbCriterioBusqueda.TabIndex = 1;
            // 
            // dgvResultadoCliente
            // 
            this.dgvResultadoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoCliente.Location = new System.Drawing.Point(50, 193);
            this.dgvResultadoCliente.Name = "dgvResultadoCliente";
            this.dgvResultadoCliente.Size = new System.Drawing.Size(699, 150);
            this.dgvResultadoCliente.TabIndex = 3;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(286, 154);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(128, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(175, 393);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(128, 23);
            this.btnSeleccionarCliente.TabIndex = 2;
            this.btnSeleccionarCliente.Text = "Seleccionar Cliente";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(437, 393);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(128, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultadoCliente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.cbCriterioBusqueda);
            this.Controls.Add(this.txtBuscarCliente);
            this.Name = "FormBuscarCliente";
            this.Text = "FormBuscarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.ComboBox cbCriterioBusqueda;
        private System.Windows.Forms.DataGridView dgvResultadoCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Button btnAtras;
    }
}