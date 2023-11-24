namespace PruebaIdeas
{
    partial class FormHijo
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
            this.btnInactive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.cmbPaises = new System.Windows.Forms.ComboBox();
            this.cmbCiudades = new System.Windows.Forms.ComboBox();
            this.lvOrigen = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDestino = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn1a1 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInactive
            // 
            this.btnInactive.Location = new System.Drawing.Point(12, 56);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(125, 38);
            this.btnInactive.TabIndex = 1;
            this.btnInactive.Text = "Boton Inactivo";
            this.btnInactive.UseVisualStyleBackColor = true;
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(12, 12);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(125, 38);
            this.btnActive.TabIndex = 2;
            this.btnActive.Text = "Boton Activo";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // cmbPaises
            // 
            this.cmbPaises.FormattingEnabled = true;
            this.cmbPaises.Items.AddRange(new object[] {
            "Brasil",
            "Rusia",
            "India",
            "China",
            "Sudafrica",
            "Peru"});
            this.cmbPaises.Location = new System.Drawing.Point(177, 12);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(121, 24);
            this.cmbPaises.TabIndex = 3;
            this.cmbPaises.SelectedIndexChanged += new System.EventHandler(this.cmbPaises_SelectedIndexChanged);
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Location = new System.Drawing.Point(177, 56);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(121, 24);
            this.cmbCiudades.TabIndex = 4;
            // 
            // lvOrigen
            // 
            this.lvOrigen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.Direccion});
            this.lvOrigen.GridLines = true;
            this.lvOrigen.HideSelection = false;
            this.lvOrigen.Location = new System.Drawing.Point(-1, 129);
            this.lvOrigen.Name = "lvOrigen";
            this.lvOrigen.Size = new System.Drawing.Size(343, 171);
            this.lvOrigen.TabIndex = 5;
            this.lvOrigen.UseCompatibleStateImageBehavior = false;
            this.lvOrigen.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 83;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 95;
            // 
            // Dni
            // 
            this.Dni.Text = "Dni";
            this.Dni.Width = 71;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            this.Direccion.Width = 89;
            // 
            // lvDestino
            // 
            this.lvDestino.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDestino.GridLines = true;
            this.lvDestino.HideSelection = false;
            this.lvDestino.Location = new System.Drawing.Point(515, 129);
            this.lvDestino.Name = "lvDestino";
            this.lvDestino.Size = new System.Drawing.Size(347, 171);
            this.lvDestino.TabIndex = 6;
            this.lvDestino.UseCompatibleStateImageBehavior = false;
            this.lvDestino.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dni";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Direccion";
            this.columnHeader4.Width = 89;
            // 
            // btn1a1
            // 
            this.btn1a1.Location = new System.Drawing.Point(362, 165);
            this.btn1a1.Name = "btn1a1";
            this.btn1a1.Size = new System.Drawing.Size(128, 27);
            this.btn1a1.TabIndex = 7;
            this.btn1a1.Text = "Trasladar 1 a 1";
            this.btn1a1.UseVisualStyleBackColor = true;
            this.btn1a1.Click += new System.EventHandler(this.btn1a1_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(362, 210);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(128, 27);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "Trasladar todos";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // FormHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btn1a1);
            this.Controls.Add(this.lvDestino);
            this.Controls.Add(this.lvOrigen);
            this.Controls.Add(this.cmbCiudades);
            this.Controls.Add(this.cmbPaises);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnInactive);
            this.Name = "FormHijo";
            this.Text = "FormHijo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHijo_FormClosing);
            this.Load += new System.EventHandler(this.FormHijo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.ComboBox cmbPaises;
        private System.Windows.Forms.ComboBox cmbCiudades;
        private System.Windows.Forms.ListView lvOrigen;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Dni;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ListView lvDestino;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn1a1;
        private System.Windows.Forms.Button btnAll;
    }
}