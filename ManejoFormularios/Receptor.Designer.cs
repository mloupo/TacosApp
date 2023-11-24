namespace ManejoFormularios
{
    partial class Receptor
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
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(24, 57);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(34, 16);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = "Info: ";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(200, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbMensaje
            // 
            this.txbMensaje.Location = new System.Drawing.Point(27, 15);
            this.txbMensaje.Name = "txbMensaje";
            this.txbMensaje.Size = new System.Drawing.Size(151, 22);
            this.txbMensaje.TabIndex = 2;
            // 
            // Receptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 94);
            this.Controls.Add(this.txbMensaje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblInformacion);
            this.Name = "Receptor";
            this.Text = "Receptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbMensaje;
    }
}