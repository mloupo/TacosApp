namespace Contactos
{
	partial class ContactosForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			gridContactos = new DataGridView();
			contactoBindingSource1 = new BindingSource(components);
			contactoBindingSource = new BindingSource(components);
			label1 = new Label();
			txtBuscar = new TextBox();
			btnBuscarContacto = new Button();
			btnAgregarContacto = new Button();
			contactoBindingSource2 = new BindingSource(components);
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nroContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			correoElectronicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			direccionEnvioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			contraseñaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			Editar = new DataGridViewLinkColumn();
			Eliminar = new DataGridViewLinkColumn();
			((System.ComponentModel.ISupportInitialize)gridContactos).BeginInit();
			((System.ComponentModel.ISupportInitialize)contactoBindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize)contactoBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)contactoBindingSource2).BeginInit();
			SuspendLayout();
			// 
			// gridContactos
			// 
			gridContactos.AutoGenerateColumns = false;
			gridContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridContactos.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, nroContactoDataGridViewTextBoxColumn, correoElectronicoDataGridViewTextBoxColumn, direccionEnvioDataGridViewTextBoxColumn, contraseñaDataGridViewTextBoxColumn, Editar, Eliminar });
			gridContactos.DataSource = contactoBindingSource2;
			gridContactos.Location = new Point(12, 80);
			gridContactos.Name = "gridContactos";
			gridContactos.RowHeadersWidth = 51;
			gridContactos.RowTemplate.Height = 29;
			gridContactos.Size = new Size(945, 405);
			gridContactos.TabIndex = 0;
			gridContactos.CellContentClick += gridContactos_CellContentClick;
			// 
			// contactoBindingSource1
			// 
			contactoBindingSource1.DataSource = typeof(Model.EntidadesUsuario.Contacto);
			// 
			// contactoBindingSource
			// 
			contactoBindingSource.DataSource = typeof(Model.EntidadesUsuario.Contacto);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 36);
			label1.Name = "label1";
			label1.Size = new Size(56, 18);
			label1.TabIndex = 1;
			label1.Text = "Buscar";
			// 
			// txtBuscar
			// 
			txtBuscar.Location = new Point(90, 33);
			txtBuscar.Name = "txtBuscar";
			txtBuscar.Size = new Size(481, 25);
			txtBuscar.TabIndex = 2;
			// 
			// btnBuscarContacto
			// 
			btnBuscarContacto.Location = new Point(577, 31);
			btnBuscarContacto.Name = "btnBuscarContacto";
			btnBuscarContacto.Size = new Size(94, 29);
			btnBuscarContacto.TabIndex = 3;
			btnBuscarContacto.Text = "Buscar";
			btnBuscarContacto.UseVisualStyleBackColor = true;
			btnBuscarContacto.Click += btnBuscarContacto_Click;
			// 
			// btnAgregarContacto
			// 
			btnAgregarContacto.Location = new Point(677, 31);
			btnAgregarContacto.Name = "btnAgregarContacto";
			btnAgregarContacto.Size = new Size(94, 29);
			btnAgregarContacto.TabIndex = 4;
			btnAgregarContacto.Text = "Agregar";
			btnAgregarContacto.UseVisualStyleBackColor = true;
			btnAgregarContacto.Click += btnAgregarContacto_Click;
			// 
			// contactoBindingSource2
			// 
			contactoBindingSource2.DataSource = typeof(Model.EntidadesUsuario.Contacto);
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "Id";
			idDataGridViewTextBoxColumn.MinimumWidth = 6;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.Visible = false;
			idDataGridViewTextBoxColumn.Width = 125;
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			nombreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
			nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			nombreDataGridViewTextBoxColumn.Width = 85;
			// 
			// apellidoDataGridViewTextBoxColumn
			// 
			apellidoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
			apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
			apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
			apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
			apellidoDataGridViewTextBoxColumn.Width = 101;
			// 
			// nroContactoDataGridViewTextBoxColumn
			// 
			nroContactoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			nroContactoDataGridViewTextBoxColumn.DataPropertyName = "NroContacto";
			nroContactoDataGridViewTextBoxColumn.HeaderText = "NroContacto";
			nroContactoDataGridViewTextBoxColumn.MinimumWidth = 6;
			nroContactoDataGridViewTextBoxColumn.Name = "nroContactoDataGridViewTextBoxColumn";
			nroContactoDataGridViewTextBoxColumn.Width = 125;
			// 
			// correoElectronicoDataGridViewTextBoxColumn
			// 
			correoElectronicoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
			correoElectronicoDataGridViewTextBoxColumn.HeaderText = "CorreoElectronico";
			correoElectronicoDataGridViewTextBoxColumn.MinimumWidth = 6;
			correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
			correoElectronicoDataGridViewTextBoxColumn.Width = 173;
			// 
			// direccionEnvioDataGridViewTextBoxColumn
			// 
			direccionEnvioDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			direccionEnvioDataGridViewTextBoxColumn.DataPropertyName = "DireccionEnvio";
			direccionEnvioDataGridViewTextBoxColumn.HeaderText = "DireccionEnvio";
			direccionEnvioDataGridViewTextBoxColumn.MinimumWidth = 6;
			direccionEnvioDataGridViewTextBoxColumn.Name = "direccionEnvioDataGridViewTextBoxColumn";
			direccionEnvioDataGridViewTextBoxColumn.Width = 149;
			// 
			// contraseñaDataGridViewTextBoxColumn
			// 
			contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
			contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
			contraseñaDataGridViewTextBoxColumn.MinimumWidth = 6;
			contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
			contraseñaDataGridViewTextBoxColumn.Visible = false;
			contraseñaDataGridViewTextBoxColumn.Width = 125;
			// 
			// Editar
			// 
			Editar.HeaderText = "Editar";
			Editar.MinimumWidth = 6;
			Editar.Name = "Editar";
			Editar.ReadOnly = true;
			Editar.Text = "Editar";
			Editar.UseColumnTextForLinkValue = true;
			Editar.Width = 125;
			// 
			// Eliminar
			// 
			Eliminar.HeaderText = "Eliminar";
			Eliminar.MinimumWidth = 6;
			Eliminar.Name = "Eliminar";
			Eliminar.ReadOnly = true;
			Eliminar.Text = "Eliminar";
			Eliminar.UseColumnTextForLinkValue = true;
			Eliminar.Width = 125;
			// 
			// Contactos
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(964, 493);
			Controls.Add(btnAgregarContacto);
			Controls.Add(btnBuscarContacto);
			Controls.Add(txtBuscar);
			Controls.Add(label1);
			Controls.Add(gridContactos);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "Contactos";
			Text = "Contactos";
			Load += FormContactos_Load;
			((System.ComponentModel.ISupportInitialize)gridContactos).EndInit();
			((System.ComponentModel.ISupportInitialize)contactoBindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize)contactoBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)contactoBindingSource2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView gridContactos;
		private Label label1;
		private TextBox txtBuscar;
		private Button btnBuscarContacto;
		private Button btnAgregarContacto;
		private BindingSource contactoBindingSource;
		private BindingSource contactoBindingSource1;
		private BindingSource contactoBindingSource2;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nroContactoDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn direccionEnvioDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
		private DataGridViewLinkColumn Editar;
		private DataGridViewLinkColumn Eliminar;
	}
}