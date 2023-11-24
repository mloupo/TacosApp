using Model.Productos;

namespace Views
{
	partial class FormCrearIngrediente
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
			CmbIngredientType = new ComboBox();
			lblIngredientType = new Label();
			txtIngredientName = new TextBox();
			txtIngredientPrice = new TextBox();
			lblIngredientName = new Label();
			lblIngredientPrice = new Label();
			btnCreateIngredient = new Button();
			btnCancel = new Button();
			dgvIngredientDetails = new DataGridView();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			Edit = new DataGridViewLinkColumn();
			Delete = new DataGridViewLinkColumn();
			rellenoBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dgvIngredientDetails).BeginInit();
			((System.ComponentModel.ISupportInitialize)rellenoBindingSource).BeginInit();
			SuspendLayout();
			// 
			// CmbIngredientType
			// 
			CmbIngredientType.FormattingEnabled = true;
			CmbIngredientType.Location = new Point(101, 45);
			CmbIngredientType.Margin = new Padding(4, 3, 4, 3);
			CmbIngredientType.Name = "CmbIngredientType";
			CmbIngredientType.Size = new Size(375, 31);
			CmbIngredientType.TabIndex = 0;
			CmbIngredientType.SelectedIndexChanged += CmbIngredientType_SelectedIndexChanged;
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
			// dgvIngredientDetails
			// 
			dgvIngredientDetails.AllowUserToOrderColumns = true;
			dgvIngredientDetails.AutoGenerateColumns = false;
			dgvIngredientDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvIngredientDetails.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1, Edit, Delete });
			dgvIngredientDetails.DataSource = rellenoBindingSource;
			dgvIngredientDetails.Location = new Point(17, 260);
			dgvIngredientDetails.Name = "dgvFormIngredienteDetails";
			dgvIngredientDetails.RowHeadersWidth = 51;
			dgvIngredientDetails.RowTemplate.Height = 29;
			dgvIngredientDetails.Size = new Size(678, 347);
			dgvIngredientDetails.TabIndex = 12;
			dgvIngredientDetails.CellContentClick += DgvIngredientDetails_CellContentClick;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.DataPropertyName = "Id";
			dataGridViewTextBoxColumn3.HeaderText = "Id";
			dataGridViewTextBoxColumn3.MinimumWidth = 6;
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.Width = 125;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
			dataGridViewTextBoxColumn2.HeaderText = "Nombre";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.Width = 125;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.DataPropertyName = "Precio";
			dataGridViewTextBoxColumn1.HeaderText = "Precio";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.Width = 125;
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
			// rellenoBindingSource
			// 
			rellenoBindingSource.DataSource = typeof(Relleno);
			// 
			// FormIngredientDetails
			// 
			AutoScaleDimensions = new SizeF(11F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(706, 619);
			Controls.Add(dgvIngredientDetails);
			Controls.Add(btnCancel);
			Controls.Add(btnCreateIngredient);
			Controls.Add(lblIngredientPrice);
			Controls.Add(lblIngredientName);
			Controls.Add(txtIngredientPrice);
			Controls.Add(txtIngredientName);
			Controls.Add(lblIngredientType);
			Controls.Add(CmbIngredientType);
			Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 3, 4, 3);
			Name = "FormIngredientDetails";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Detalle Ingredientes";
			Load += FormIngredientDetails_Load;
			((System.ComponentModel.ISupportInitialize)dgvIngredientDetails).EndInit();
			((System.ComponentModel.ISupportInitialize)rellenoBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox CmbIngredientType;
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
		private DataGridView dgvIngredientDetails;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewLinkColumn Edit;
		private DataGridViewLinkColumn Delete;
		private BindingSource rellenoBindingSource;
	}
}