using Model.Productos;

namespace Views
{
	partial class FormMostrarIngrediente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrarIngrediente));
			dgvFormIngredient = new DataGridView();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			rellenoBindingSource = new BindingSource(components);
			txtSearchIngredient = new TextBox();
			btnSearchIngredient = new Button();
			btnAddIngredient = new Button();
			((System.ComponentModel.ISupportInitialize)dgvFormIngredient).BeginInit();
			((System.ComponentModel.ISupportInitialize)rellenoBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dgvFormIngredient
			// 
			dgvFormIngredient.AutoGenerateColumns = false;
			dgvFormIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFormIngredient.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1 });
			dgvFormIngredient.DataSource = rellenoBindingSource;
			dgvFormIngredient.Location = new Point(9, 62);
			dgvFormIngredient.Margin = new Padding(3, 2, 3, 2);
			dgvFormIngredient.Name = "dgvFormIngredient";
			dgvFormIngredient.RowHeadersWidth = 51;
			dgvFormIngredient.RowTemplate.Height = 29;
			dgvFormIngredient.Size = new Size(481, 334);
			dgvFormIngredient.TabIndex = 0;
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
			// rellenoBindingSource
			// 
			rellenoBindingSource.DataSource = typeof(Relleno);
			// 
			// txtSearchIngredient
			// 
			txtSearchIngredient.Location = new Point(12, 18);
			txtSearchIngredient.Margin = new Padding(2, 2, 2, 2);
			txtSearchIngredient.Name = "txtSearchIngredient";
			txtSearchIngredient.Size = new Size(263, 25);
			txtSearchIngredient.TabIndex = 1;
			// 
			// btnSearchIngredient
			// 
			btnSearchIngredient.Location = new Point(278, 18);
			btnSearchIngredient.Margin = new Padding(2, 2, 2, 2);
			btnSearchIngredient.Name = "btnSearchIngredient";
			btnSearchIngredient.Size = new Size(68, 23);
			btnSearchIngredient.TabIndex = 3;
			btnSearchIngredient.Text = "Search";
			btnSearchIngredient.UseVisualStyleBackColor = true;
			btnSearchIngredient.Click += btnSearchIngredient_Click;
			// 
			// btnAddIngredient
			// 
			btnAddIngredient.Location = new Point(360, 18);
			btnAddIngredient.Margin = new Padding(2, 2, 2, 2);
			btnAddIngredient.Name = "btnAddIngredient";
			btnAddIngredient.Size = new Size(83, 23);
			btnAddIngredient.TabIndex = 13;
			btnAddIngredient.Text = "Agregar";
			btnAddIngredient.UseVisualStyleBackColor = true;
			btnAddIngredient.Click += BtnAddIngredient_Click;
			// 
			// FormMostrarIngrediente
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(506, 412);
			Controls.Add(btnAddIngredient);
			Controls.Add(btnSearchIngredient);
			Controls.Add(txtSearchIngredient);
			Controls.Add(dgvFormIngredient);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(3, 2, 3, 2);
			Name = "FormMostrarIngrediente";
			StartPosition = FormStartPosition.CenterScreen;
			Text = resources.GetString("$this.Text");
			Activated += FormIngredient_Activated;
			Load += FormIngredient_Load;
			((System.ComponentModel.ISupportInitialize)dgvFormIngredient).EndInit();
			((System.ComponentModel.ISupportInitialize)rellenoBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvFormIngredient;
		private TextBox txtSearchIngredient;
		private Button btnSearchIngredient;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private BindingSource rellenoBindingSource;
		private Button btnAddIngredient;
	}
}