
using Modelo.EntidadesProducto.Tacos;

namespace Vistas
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
			lblIngredientType = new Label();
			cmbTipoIngrediente = new ComboBox();

			lblIngredientName = new Label();
			txtIngredientName = new TextBox();
			lblIngredientPrice = new Label();
			txtIngredientPrice = new TextBox();

			btnCrearIngrediente = new Button();
			btnCancelarCreacion = new Button();

			dgvIngredientDetails = new DataGridView();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			Edit = new DataGridViewLinkColumn();
			Delete = new DataGridViewLinkColumn();
			rellenoBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dgvIngredientDetails).BeginInit();
			((System.ComponentModel.ISupportInitialize)rellenoBindingSource).BeginInit();
			SuspendLayout();
			// 
			// cmbTipoIngrediente
			// 
			cmbTipoIngrediente.FormattingEnabled = true;
			cmbTipoIngrediente.Location = new Point(73, 35);
			cmbTipoIngrediente.Margin = new Padding(3, 2, 3, 2);
			cmbTipoIngrediente.Name = "cmbTipoIngrediente";
			cmbTipoIngrediente.Size = new Size(274, 26);
			cmbTipoIngrediente.TabIndex = 0;
			cmbTipoIngrediente.SelectedIndexChanged += cmbTipoIngrediente_SelectedIndexChanged;
			// 
			// lblIngredientType
			// 
			lblIngredientType.AutoSize = true;
			lblIngredientType.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblIngredientType.Location = new Point(12, 41);
			lblIngredientType.Name = "lblIngredientType";
			lblIngredientType.Size = new Size(40, 18);
			lblIngredientType.TabIndex = 2;
			lblIngredientType.Text = "Tipo";
			// 
			// lblIngredientName
			// 
			lblIngredientName.AutoSize = true;
			lblIngredientName.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblIngredientName.Location = new Point(12, 81);
			lblIngredientName.Name = "lblIngredientName";
			lblIngredientName.Size = new Size(56, 18);
			lblIngredientName.TabIndex = 5;
			lblIngredientName.Text = "Nombre";
			// 
			// txtIngredientName
			// 
			txtIngredientName.Location = new Point(73, 74);
			txtIngredientName.Margin = new Padding(3, 2, 3, 2);
			txtIngredientName.Name = "txtIngredientName";
			txtIngredientName.Size = new Size(274, 25);
			txtIngredientName.TabIndex = 3;
			// 
			// lblIngredientPrice
			// 
			lblIngredientPrice.AutoSize = true;
			lblIngredientPrice.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblIngredientPrice.Location = new Point(12, 121);
			lblIngredientPrice.Name = "lblIngredientPrice";
			lblIngredientPrice.Size = new Size(56, 18);
			lblIngredientPrice.TabIndex = 6;
			lblIngredientPrice.Text = "Precio";
			// 
			// txtIngredientPrice
			// 
			txtIngredientPrice.Location = new Point(73, 115);
			txtIngredientPrice.Margin = new Padding(3, 2, 3, 2);
			txtIngredientPrice.Name = "txtIngredientPrice";
			txtIngredientPrice.Size = new Size(274, 25);
			txtIngredientPrice.TabIndex = 4;
			// 
			// btnCrearIngrediente
			// 
			btnCrearIngrediente.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnCrearIngrediente.Location = new Point(382, 72);
			btnCrearIngrediente.Margin = new Padding(3, 2, 3, 2);
			btnCrearIngrediente.Name = "btnCrearIngrediente";
			btnCrearIngrediente.Size = new Size(111, 26);
			btnCrearIngrediente.TabIndex = 7;
			btnCrearIngrediente.Text = "Crear";
			btnCrearIngrediente.UseVisualStyleBackColor = true;
			btnCrearIngrediente.Click += BtnCreateIngredient_Click;
			// 
			// btnCancelarCreacion
			// 
			btnCancelarCreacion.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnCancelarCreacion.Location = new Point(382, 107);
			btnCancelarCreacion.Margin = new Padding(3, 2, 3, 2);
			btnCancelarCreacion.Name = "btnCancelarCreacion";
			btnCancelarCreacion.Size = new Size(111, 26);
			btnCancelarCreacion.TabIndex = 11;
			btnCancelarCreacion.Text = "Cancelar";
			btnCancelarCreacion.UseVisualStyleBackColor = true;
			btnCancelarCreacion.Click += btnCancelarCreacion_Click;
			// 
			// dgvIngredientDetails
			// 
			dgvIngredientDetails.AllowUserToOrderColumns = true;
			dgvIngredientDetails.AutoGenerateColumns = false;
			dgvIngredientDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvIngredientDetails.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1, Edit, Delete });
			dgvIngredientDetails.DataSource = rellenoBindingSource;
			dgvIngredientDetails.Location = new Point(12, 203);
			dgvIngredientDetails.Margin = new Padding(2);
			dgvIngredientDetails.Name = "dgvIngredientDetails";
			dgvIngredientDetails.RowHeadersWidth = 51;
			dgvIngredientDetails.RowTemplate.Height = 29;
			dgvIngredientDetails.Size = new Size(510, 324);
			dgvIngredientDetails.TabIndex = 12;
			dgvIngredientDetails.CellContentClick += DgvIngredientDetails_CellContentClick;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
			dataGridViewTextBoxColumn2.HeaderText = "Nombre";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.Width = 85;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridViewTextBoxColumn1.DataPropertyName = "Precio";
			dataGridViewTextBoxColumn1.HeaderText = "Precio";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.Width = 85;
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
			// FormCrearIngrediente
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(528, 538);
			Controls.Add(dgvIngredientDetails);
			Controls.Add(btnCancelarCreacion);
			Controls.Add(btnCrearIngrediente);
			Controls.Add(lblIngredientPrice);
			Controls.Add(lblIngredientName);
			Controls.Add(txtIngredientPrice);
			Controls.Add(txtIngredientName);
			Controls.Add(lblIngredientType);
			Controls.Add(cmbTipoIngrediente);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(3, 2, 3, 2);
			Name = "FormCrearIngrediente";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Crear Ingrediente";
			Load += FormIngredientDetails_Load;
			((System.ComponentModel.ISupportInitialize)dgvIngredientDetails).EndInit();
			((System.ComponentModel.ISupportInitialize)rellenoBindingSource).EndInit();
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
		private Button btnCrearIngrediente;
		private Button btnCancelarCreacion;
		private DataGridViewTextBoxColumn preciounitarioDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private BindingSource salsaBindingSource;
		private DataGridView dgvIngredientDetails;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
		private BindingSource rellenoBindingSource;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewLinkColumn Edit;
		private DataGridViewLinkColumn Delete;
	}
}