namespace Vistas
{
	partial class FormCrearBebida
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			lblPrecioBebida = new Label();
			txtNombreBebida = new TextBox();
			txtPrecioBebida = new TextBox();
			cmbTipoBebida = new ComboBox();
			lblTipoBebida = new Label();
			btnCancelarCreacion = new Button();
			btnCrearBebida = new Button();
			dgvBebidaDetalles = new DataGridView();
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			Edit = new DataGridViewLinkColumn();
			Delete = new DataGridViewLinkColumn();
			aguaBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dgvBebidaDetalles).BeginInit();
			((System.ComponentModel.ISupportInitialize)aguaBindingSource).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 78);
			label1.Name = "label1";
			label1.Size = new Size(56, 18);
			label1.TabIndex = 0;
			label1.Text = "Nombre";
			// 
			// lblPrecioBebida
			// 
			lblPrecioBebida.AutoSize = true;
			lblPrecioBebida.Location = new Point(12, 109);
			lblPrecioBebida.Name = "lblPrecioBebida";
			lblPrecioBebida.Size = new Size(56, 18);
			lblPrecioBebida.TabIndex = 1;
			lblPrecioBebida.Text = "Precio";
			// 
			// txtNombreBebida
			// 
			txtNombreBebida.Location = new Point(90, 76);
			txtNombreBebida.Name = "txtNombreBebida";
			txtNombreBebida.Size = new Size(265, 25);
			txtNombreBebida.TabIndex = 2;
			// 
			// txtPrecioBebida
			// 
			txtPrecioBebida.Location = new Point(90, 107);
			txtPrecioBebida.Name = "txtPrecioBebida";
			txtPrecioBebida.Size = new Size(265, 25);
			txtPrecioBebida.TabIndex = 3;
			// 
			// cmbTipoBebida
			// 
			cmbTipoBebida.DataSource = aguaBindingSource;
			cmbTipoBebida.FormattingEnabled = true;
			cmbTipoBebida.Location = new Point(90, 44);
			cmbTipoBebida.Name = "cmbTipoBebida";
			cmbTipoBebida.Size = new Size(265, 26);
			cmbTipoBebida.TabIndex = 4;
			cmbTipoBebida.SelectedIndexChanged += cmbTipoBebida_SelectedIndexChanged;
			// 
			// lblTipoBebida
			// 
			lblTipoBebida.AutoSize = true;
			lblTipoBebida.Location = new Point(12, 47);
			lblTipoBebida.Name = "lblTipoBebida";
			lblTipoBebida.Size = new Size(40, 18);
			lblTipoBebida.TabIndex = 5;
			lblTipoBebida.Text = "Tipo";
			// 
			// btnCancelarCreacion
			// 
			btnCancelarCreacion.Location = new Point(390, 105);
			btnCancelarCreacion.Name = "btnCancelarCreacion";
			btnCancelarCreacion.Size = new Size(94, 26);
			btnCancelarCreacion.TabIndex = 6;
			btnCancelarCreacion.Text = "Cancelar";
			btnCancelarCreacion.UseVisualStyleBackColor = true;
			// 
			// btnCrearBebida
			// 
			btnCrearBebida.Location = new Point(390, 70);
			btnCrearBebida.Name = "btnCrearBebida";
			btnCrearBebida.Size = new Size(94, 26);
			btnCrearBebida.TabIndex = 7;
			btnCrearBebida.Text = "Crear";
			btnCrearBebida.UseVisualStyleBackColor = true;
			// 
			// dgvBebidaDetalles
			// 
			dgvBebidaDetalles.AllowUserToOrderColumns = true;
			dgvBebidaDetalles.AutoGenerateColumns = false;
			dgvBebidaDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBebidaDetalles.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, Edit, Delete });
			dgvBebidaDetalles.DataSource = aguaBindingSource;
			dgvBebidaDetalles.Location = new Point(3, 184);
			dgvBebidaDetalles.Margin = new Padding(2);
			dgvBebidaDetalles.Name = "dgvBebidaDetalles";
			dgvBebidaDetalles.RowHeadersWidth = 51;
			dgvBebidaDetalles.RowTemplate.Height = 29;
			dgvBebidaDetalles.Size = new Size(526, 333);
			dgvBebidaDetalles.TabIndex = 13;
			dgvBebidaDetalles.CellContentClick += dgvBebidaDetalles_CellContentClick;
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "Id";
			idDataGridViewTextBoxColumn.MinimumWidth = 6;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.ReadOnly = true;
			idDataGridViewTextBoxColumn.Visible = false;
			idDataGridViewTextBoxColumn.Width = 125;
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
			nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			nombreDataGridViewTextBoxColumn.Width = 125;
			// 
			// precioDataGridViewTextBoxColumn
			// 
			precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
			precioDataGridViewTextBoxColumn.HeaderText = "Precio";
			precioDataGridViewTextBoxColumn.MinimumWidth = 6;
			precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
			precioDataGridViewTextBoxColumn.Width = 125;
			// 
			// Edit
			// 
			Edit.HeaderText = "";
			Edit.MinimumWidth = 6;
			Edit.Name = "Edit";
			Edit.ReadOnly = true;
			Edit.Text = "Edit";
			Edit.UseColumnTextForLinkValue = true;
			Edit.Width = 60;
			// 
			// Delete
			// 
			Delete.HeaderText = "";
			Delete.MinimumWidth = 6;
			Delete.Name = "Delete";
			Delete.ReadOnly = true;
			Delete.Text = "Delete";
			Delete.UseColumnTextForLinkValue = true;
			Delete.Width = 80;
			// 
			// aguaBindingSource
			// 
			aguaBindingSource.DataSource = typeof(Modelo.EntidadesProducto.Bebidas.Agua);
			// 
			// FormCrearBebida
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(540, 522);
			Controls.Add(dgvBebidaDetalles);
			Controls.Add(btnCrearBebida);
			Controls.Add(btnCancelarCreacion);
			Controls.Add(lblTipoBebida);
			Controls.Add(cmbTipoBebida);
			Controls.Add(txtPrecioBebida);
			Controls.Add(txtNombreBebida);
			Controls.Add(lblPrecioBebida);
			Controls.Add(label1);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "FormCrearBebida";
			Text = "Crear Bebida";
			TopMost = true;
			((System.ComponentModel.ISupportInitialize)dgvBebidaDetalles).EndInit();
			((System.ComponentModel.ISupportInitialize)aguaBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label lblPrecioBebida;
		private TextBox txtNombreBebida;
		private TextBox txtPrecioBebida;
		private ComboBox cmbTipoBebida;
		private Label lblTipoBebida;
		private Button btnCancelarCreacion;
		private Button btnCrearBebida;
		private DataGridView dgvBebidaDetalles;
		private BindingSource aguaBindingSource;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
		private DataGridViewLinkColumn Edit;
		private DataGridViewLinkColumn Delete;
	}
}