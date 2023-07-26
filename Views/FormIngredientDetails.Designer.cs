namespace Views
{
	partial class FormIngredientDetails
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
			cmbTipoIngrediente = new ComboBox();
			lblIngredientType = new Label();
			txtIngredientName = new TextBox();
			txtIngredientPrice = new TextBox();
			lblIngredientName = new Label();
			lblIngredientPrice = new Label();
			btnCreateIngredient = new Button();
			btnCancel = new Button();
			salsaBindingSource = new BindingSource(components);
			dgvFormIngredienteDetails = new DataGridView();
			salsaBindingSource1 = new BindingSource(components);
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			Edit = new DataGridViewLinkColumn();
			Delete = new DataGridViewLinkColumn();
			((System.ComponentModel.ISupportInitialize)salsaBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvFormIngredienteDetails).BeginInit();
			((System.ComponentModel.ISupportInitialize)salsaBindingSource1).BeginInit();
			SuspendLayout();
			// 
			// cmbTipoIngrediente
			// 
			cmbTipoIngrediente.FormattingEnabled = true;
			cmbTipoIngrediente.Location = new Point(101, 45);
			cmbTipoIngrediente.Margin = new Padding(4, 3, 4, 3);
			cmbTipoIngrediente.Name = "cmbTipoIngrediente";
			cmbTipoIngrediente.Size = new Size(375, 31);
			cmbTipoIngrediente.TabIndex = 0;
			cmbTipoIngrediente.SelectedIndexChanged += CmbTipoIngrediente_SelectedIndexChanged;
			// 
			// lblIngredientType
			// 
			lblIngredientType.AutoSize = true;
			lblIngredientType.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIngredientType.Location = new Point(17, 53);
			lblIngredientType.Margin = new Padding(4, 0, 4, 0);
			lblIngredientType.Name = "lblIngredientType";
			lblIngredientType.Size = new Size(54, 23);
			lblIngredientType.TabIndex = 2;
			lblIngredientType.Text = "Tipo";
			// 
			// txtIngredientName
			// 
			txtIngredientName.Location = new Point(101, 94);
			txtIngredientName.Margin = new Padding(4, 3, 4, 3);
			txtIngredientName.Name = "txtIngredientName";
			txtIngredientName.Size = new Size(375, 31);
			txtIngredientName.TabIndex = 3;
			// 
			// txtIngredientPrice
			// 
			txtIngredientPrice.Location = new Point(101, 147);
			txtIngredientPrice.Margin = new Padding(4, 3, 4, 3);
			txtIngredientPrice.Name = "txtIngredientPrice";
			txtIngredientPrice.Size = new Size(375, 31);
			txtIngredientPrice.TabIndex = 4;
			// 
			// lblIngredientName
			// 
			lblIngredientName.AutoSize = true;
			lblIngredientName.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIngredientName.Location = new Point(17, 103);
			lblIngredientName.Margin = new Padding(4, 0, 4, 0);
			lblIngredientName.Name = "lblIngredientName";
			lblIngredientName.Size = new Size(76, 23);
			lblIngredientName.TabIndex = 5;
			lblIngredientName.Text = "Nombre";
			// 
			// lblIngredientPrice
			// 
			lblIngredientPrice.AutoSize = true;
			lblIngredientPrice.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIngredientPrice.Location = new Point(17, 155);
			lblIngredientPrice.Margin = new Padding(4, 0, 4, 0);
			lblIngredientPrice.Name = "lblIngredientPrice";
			lblIngredientPrice.Size = new Size(76, 23);
			lblIngredientPrice.TabIndex = 6;
			lblIngredientPrice.Text = "Precio";
			// 
			// btnCreateIngredient
			// 
			btnCreateIngredient.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCreateIngredient.Location = new Point(525, 92);
			btnCreateIngredient.Margin = new Padding(4, 3, 4, 3);
			btnCreateIngredient.Name = "btnCreateIngredient";
			btnCreateIngredient.Size = new Size(153, 33);
			btnCreateIngredient.TabIndex = 7;
			btnCreateIngredient.Text = "Save";
			btnCreateIngredient.UseVisualStyleBackColor = true;
			btnCreateIngredient.Click += BtnCreateIngredient_Click;
			// 
			// btnCancel
			// 
			btnCancel.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCancel.Location = new Point(525, 137);
			btnCancel.Margin = new Padding(4, 3, 4, 3);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(153, 33);
			btnCancel.TabIndex = 11;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += BtnCancel_Click;
			// 
			// dgvFormIngredienteDetails
			// 
			dgvFormIngredienteDetails.AllowUserToOrderColumns = true;
			dgvFormIngredienteDetails.AutoGenerateColumns = false;
			dgvFormIngredienteDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFormIngredienteDetails.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, Edit, Delete });
			dgvFormIngredienteDetails.DataSource = salsaBindingSource1;
			dgvFormIngredienteDetails.Location = new Point(17, 260);
			dgvFormIngredienteDetails.Name = "dgvFormIngredienteDetails";
			dgvFormIngredienteDetails.RowHeadersWidth = 51;
			dgvFormIngredienteDetails.RowTemplate.Height = 29;
			dgvFormIngredienteDetails.Size = new Size(678, 347);
			dgvFormIngredienteDetails.TabIndex = 12;
			dgvFormIngredienteDetails.CellContentClick += dgvFormIngredienteDetails_CellContentClick;
			// 
			// salsaBindingSource1
			// 
			salsaBindingSource1.DataSource = typeof(Model.Salsa);
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "Id";
			idDataGridViewTextBoxColumn.MinimumWidth = 6;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
			// FormIngredientDetails
			// 
			AutoScaleDimensions = new SizeF(11F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(706, 619);
			Controls.Add(dgvFormIngredienteDetails);
			Controls.Add(btnCancel);
			Controls.Add(btnCreateIngredient);
			Controls.Add(lblIngredientPrice);
			Controls.Add(lblIngredientName);
			Controls.Add(txtIngredientPrice);
			Controls.Add(txtIngredientName);
			Controls.Add(lblIngredientType);
			Controls.Add(cmbTipoIngrediente);
			Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 3, 4, 3);
			Name = "FormIngredientDetails";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Detalle Ingredientes";
			Load += FormIngredientDetails_Load;
			((System.ComponentModel.ISupportInitialize)salsaBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvFormIngredienteDetails).EndInit();
			((System.ComponentModel.ISupportInitialize)salsaBindingSource1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cmbTipoIngrediente;
		private Label lblIngredientType;
		private TextBox txtIngredientName;
		private TextBox txtIngredientPrice;
		private Label lblIngredientName;
		private Label lblIngredientPrice;
		private Button btnCreateIngredient;
		private Button btnCancel;
		private DataGridViewTextBoxColumn preciounitarioDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private BindingSource salsaBindingSource;
		private DataGridView dgvFormIngredienteDetails;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
		private DataGridViewLinkColumn Edit;
		private DataGridViewLinkColumn Delete;
		private BindingSource salsaBindingSource1;
	}
}