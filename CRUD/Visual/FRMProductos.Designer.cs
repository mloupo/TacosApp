namespace TacosApp
{
	partial class FRMProductos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMProductos));
			this.pnlBackground = new System.Windows.Forms.Panel();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pnlBusqueda = new System.Windows.Forms.Panel();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.pbBusqueda = new System.Windows.Forms.PictureBox();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.lblFolio = new System.Windows.Forms.Label();
			this.pnlImage = new System.Windows.Forms.Panel();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.lblImagen = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pbCrud = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
			this.pnlBackground.SuspendLayout();
			this.pnlBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).BeginInit();
			this.pnlImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCrud)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlBackground
			// 
			this.pnlBackground.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pnlBackground.Controls.Add(this.btnLimpiar);
			this.pnlBackground.Controls.Add(this.btnSalir);
			this.pnlBackground.Controls.Add(this.pnlBusqueda);
			this.pnlBackground.Controls.Add(this.btnEliminar);
			this.pnlBackground.Controls.Add(this.btnModificar);
			this.pnlBackground.Controls.Add(this.txtFolio);
			this.pnlBackground.Controls.Add(this.lblFolio);
			this.pnlBackground.Controls.Add(this.pnlImage);
			this.pnlBackground.Controls.Add(this.btnAgregar);
			this.pnlBackground.Controls.Add(this.lblImagen);
			this.pnlBackground.Controls.Add(this.dgvProductos);
			this.pnlBackground.Controls.Add(this.lblCantidad);
			this.pnlBackground.Controls.Add(this.lblPrecio);
			this.pnlBackground.Controls.Add(this.lblNombre);
			this.pnlBackground.Controls.Add(this.txtCantidad);
			this.pnlBackground.Controls.Add(this.txtPrecio);
			this.pnlBackground.Controls.Add(this.txtNombre);
			this.pnlBackground.Controls.Add(this.panel2);
			this.pnlBackground.Location = new System.Drawing.Point(-5, -3);
			this.pnlBackground.Name = "pnlBackground";
			this.pnlBackground.Size = new System.Drawing.Size(720, 693);
			this.pnlBackground.TabIndex = 0;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Image = global::TacosApp.Properties.Resources.clean2;
			this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpiar.Location = new System.Drawing.Point(438, 634);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(130, 42);
			this.btnLimpiar.TabIndex = 11;
			this.btnLimpiar.Text = "Limpiar  ";
			this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Image = global::TacosApp.Properties.Resources.logout;
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(589, 634);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(116, 42);
			this.btnSalir.TabIndex = 12;
			this.btnSalir.Text = "Salir  ";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// pnlBusqueda
			// 
			this.pnlBusqueda.BackColor = System.Drawing.SystemColors.Highlight;
			this.pnlBusqueda.Controls.Add(this.txtBusqueda);
			this.pnlBusqueda.Controls.Add(this.pbBusqueda);
			this.pnlBusqueda.Controls.Add(this.lblBusqueda);
			this.pnlBusqueda.Location = new System.Drawing.Point(26, 262);
			this.pnlBusqueda.Name = "pnlBusqueda";
			this.pnlBusqueda.Size = new System.Drawing.Size(679, 63);
			this.pnlBusqueda.TabIndex = 5;
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(117, 19);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(279, 22);
			this.txtBusqueda.TabIndex = 6;
			this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
			// 
			// pbBusqueda
			// 
			this.pbBusqueda.Image = global::TacosApp.Properties.Resources.busqueda;
			this.pbBusqueda.Location = new System.Drawing.Point(412, 13);
			this.pbBusqueda.Name = "pbBusqueda";
			this.pbBusqueda.Size = new System.Drawing.Size(34, 30);
			this.pbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbBusqueda.TabIndex = 1;
			this.pbBusqueda.TabStop = false;
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.AutoSize = true;
			this.lblBusqueda.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBusqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblBusqueda.Location = new System.Drawing.Point(12, 19);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(99, 24);
			this.lblBusqueda.TabIndex = 0;
			this.lblBusqueda.Text = "Búsqueda:";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(303, 634);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(109, 42);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "Eliminar  ";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(153, 634);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(129, 42);
			this.btnModificar.TabIndex = 9;
			this.btnModificar.Text = "Modificar  ";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// txtFolio
			// 
			this.txtFolio.Enabled = false;
			this.txtFolio.Location = new System.Drawing.Point(133, 86);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(219, 22);
			this.txtFolio.TabIndex = 0;
			// 
			// lblFolio
			// 
			this.lblFolio.AutoSize = true;
			this.lblFolio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFolio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblFolio.Location = new System.Drawing.Point(22, 84);
			this.lblFolio.Name = "lblFolio";
			this.lblFolio.Size = new System.Drawing.Size(56, 24);
			this.lblFolio.TabIndex = 10;
			this.lblFolio.Text = "Folio:";
			// 
			// pnlImage
			// 
			this.pnlImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pnlImage.Controls.Add(this.pbImage);
			this.pnlImage.Location = new System.Drawing.Point(495, 84);
			this.pnlImage.Name = "pnlImage";
			this.pnlImage.Size = new System.Drawing.Size(185, 154);
			this.pnlImage.TabIndex = 4;
			// 
			// pbImage
			// 
			this.pbImage.Image = global::TacosApp.Properties.Resources.agregar_imagen;
			this.pbImage.Location = new System.Drawing.Point(14, 15);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(158, 129);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImage.TabIndex = 0;
			this.pbImage.TabStop = false;
			this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(26, 634);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(111, 42);
			this.btnAgregar.TabIndex = 8;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// lblImagen
			// 
			this.lblImagen.AutoSize = true;
			this.lblImagen.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblImagen.Location = new System.Drawing.Point(394, 82);
			this.lblImagen.Name = "lblImagen";
			this.lblImagen.Size = new System.Drawing.Size(80, 24);
			this.lblImagen.TabIndex = 7;
			this.lblImagen.Text = "Imágen:";
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.AllowUserToOrderColumns = true;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Folio,
			this.Nombre,
			this.Precio,
			this.Cantidad,
			this.Imagen});
			this.dgvProductos.Location = new System.Drawing.Point(26, 337);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.RowHeadersWidth = 51;
			this.dgvProductos.RowTemplate.Height = 24;
			this.dgvProductos.Size = new System.Drawing.Size(679, 288);
			this.dgvProductos.TabIndex = 7;
			this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCantidad.Location = new System.Drawing.Point(22, 216);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(91, 24);
			this.lblCantidad.TabIndex = 5;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPrecio.Location = new System.Drawing.Point(22, 173);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(68, 24);
			this.lblPrecio.TabIndex = 4;
			this.lblPrecio.Text = "Precio:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNombre.Location = new System.Drawing.Point(22, 131);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(85, 24);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Nombre:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(133, 216);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(219, 22);
			this.txtCantidad.TabIndex = 3;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(133, 175);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(219, 22);
			this.txtPrecio.TabIndex = 2;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(133, 133);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(219, 22);
			this.txtNombre.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel2.Controls.Add(this.pbCrud);
			this.panel2.Controls.Add(this.lblTitulo);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(715, 63);
			this.panel2.TabIndex = 0;
			// 
			// pbCrud
			// 
			this.pbCrud.Image = global::TacosApp.Properties.Resources.comestibles;
			this.pbCrud.Location = new System.Drawing.Point(324, 12);
			this.pbCrud.Name = "pbCrud";
			this.pbCrud.Size = new System.Drawing.Size(41, 37);
			this.pbCrud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbCrud.TabIndex = 1;
			this.pbCrud.TabStop = false;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTitulo.Location = new System.Drawing.Point(48, 18);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(241, 31);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "CRUD de productos";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(541, 626);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(129, 42);
			this.button3.TabIndex = 14;
			this.button3.Text = "Salir";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.Location = new System.Drawing.Point(372, 626);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 42);
			this.button2.TabIndex = 13;
			this.button2.Text = "Eliminar  ";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Folio
			// 
			this.Folio.HeaderText = "Folio";
			this.Folio.MinimumWidth = 6;
			this.Folio.Name = "Folio";
			this.Folio.ReadOnly = true;
			this.Folio.Width = 50;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.MinimumWidth = 6;
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 150;
			// 
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.MinimumWidth = 6;
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.MinimumWidth = 6;
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			// 
			// Imagen
			// 
			this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Imagen.HeaderText = "Imagen";
			this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.Imagen.MinimumWidth = 6;
			this.Imagen.Name = "Imagen";
			this.Imagen.ReadOnly = true;
			// 
			// FRMProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 685);
			this.Controls.Add(this.pnlBackground);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FRMProductos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Productos";
			this.pnlBackground.ResumeLayout(false);
			this.pnlBackground.PerformLayout();
			this.pnlBusqueda.ResumeLayout(false);
			this.pnlBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).EndInit();
			this.pnlImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCrud)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlBackground;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label lblImagen;
		private System.Windows.Forms.Panel pnlImage;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label lblFolio;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pbCrud;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel pnlBusqueda;
		private System.Windows.Forms.PictureBox pbBusqueda;
		private System.Windows.Forms.Label lblBusqueda;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewImageColumn Imagen;
	}
}

