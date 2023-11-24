namespace PruebaIdeas
{
    partial class FormHijo2
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
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParticipantes.Location = new System.Drawing.Point(0, 0);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.ReadOnly = true;
            this.dgvParticipantes.RowHeadersWidth = 51;
            this.dgvParticipantes.RowTemplate.Height = 24;
            this.dgvParticipantes.Size = new System.Drawing.Size(805, 350);
            this.dgvParticipantes.TabIndex = 0;
            this.dgvParticipantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipantes_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvParticipantes);
            this.panel1.Location = new System.Drawing.Point(-3, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 350);
            this.panel1.TabIndex = 1;
            // 
            // FormHijo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormHijo2";
            this.Text = "FormHijo2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHijo2_FormClosing);
            this.Load += new System.EventHandler(this.FormHijo2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.Panel panel1;
    }
}