using Model.Productos;

namespace Views
{
	partial class FormIngredient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngredient));
			dgvFormIngredient = new DataGridView();
			textBox1 = new TextBox();
			btnSeacrhIngredient = new Button();
			btnAddIngredient = new Button();
			rellenoBindingSource = new BindingSource(components);
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
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
			dgvFormIngredient.Location = new Point(13, 79);
			dgvFormIngredient.Margin = new Padding(4, 3, 4, 3);
			dgvFormIngredient.Name = "dgvFormIngredient";
			dgvFormIngredient.RowHeadersWidth = 51;
			dgvFormIngredient.RowTemplate.Height = 29;
			dgvFormIngredient.Size = new Size(661, 427);
			dgvFormIngredient.TabIndex = 0;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(16, 23);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(360, 31);
			textBox1.TabIndex = 1;
			// 
			// btnSeacrhIngredient
			// 
			btnSeacrhIngredient.Location = new Point(382, 23);
			btnSeacrhIngredient.Name = "btnSeacrhIngredient";
			btnSeacrhIngredient.Size = new Size(94, 29);
			btnSeacrhIngredient.TabIndex = 3;
			btnSeacrhIngredient.Text = "Search";
			btnSeacrhIngredient.UseVisualStyleBackColor = true;
			btnSeacrhIngredient.Click += BtnSeacrhIngredient_Click;
			// 
			// btnAddIngredient
			// 
			btnAddIngredient.Location = new Point(482, 23);
			btnAddIngredient.Name = "btnAddIngredient";
			btnAddIngredient.Size = new Size(114, 29);
			btnAddIngredient.TabIndex = 4;
			btnAddIngredient.Text = "Agregar";
			btnAddIngredient.UseVisualStyleBackColor = true;
			btnAddIngredient.Click += BtnAddIngredient_Click;
			// 
			// rellenoBindingSource
			// 
			rellenoBindingSource.DataSource = typeof(Relleno);
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
			// FormIngredient
			// 
			AutoScaleDimensions = new SizeF(11F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(686, 518);
			Controls.Add(btnAddIngredient);
			Controls.Add(btnSeacrhIngredient);
			Controls.Add(textBox1);
			Controls.Add(dgvFormIngredient);
			Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 3, 4, 3);
			Name = "FormIngredient";
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
		private TextBox textBox1;
		private Button btnSeacrhIngredient;
		private Button btnAddIngredient;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private BindingSource rellenoBindingSource;
	}
}