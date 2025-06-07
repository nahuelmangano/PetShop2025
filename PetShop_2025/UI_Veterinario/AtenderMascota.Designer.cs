namespace PetShop_2025.UI_Veterinario
{
    partial class AtenderMascota
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
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.btnBuscarHistorial = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Location = new System.Drawing.Point(311, 73);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(117, 33);
            this.btnNuevaConsulta.TabIndex = 0;
            this.btnNuevaConsulta.Text = "Nueva Consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // btnBuscarHistorial
            // 
            this.btnBuscarHistorial.Location = new System.Drawing.Point(311, 124);
            this.btnBuscarHistorial.Name = "btnBuscarHistorial";
            this.btnBuscarHistorial.Size = new System.Drawing.Size(117, 33);
            this.btnBuscarHistorial.TabIndex = 1;
            this.btnBuscarHistorial.Text = "Buscar Historial";
            this.btnBuscarHistorial.UseVisualStyleBackColor = true;
            this.btnBuscarHistorial.Click += new System.EventHandler(this.btnBuscarHistorial_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(510, 338);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 33);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // AtenderMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscarHistorial);
            this.Controls.Add(this.btnNuevaConsulta);
            this.Name = "AtenderMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atender Mascota";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.Button btnBuscarHistorial;
        private System.Windows.Forms.Button btnVolver;
    }
}