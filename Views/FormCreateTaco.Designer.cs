namespace Views
{
	partial class FormCreateTaco
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
			btnAgregarIngrediente = new Button();
			label2 = new Label();
			label1 = new Label();
			lblTacoCreated = new Label();
			cmbTipoIngrediente = new ComboBox();
			cmbIngrediente = new ComboBox();
			dgvTacoDetails = new DataGridView();
			dgvIdTaco = new DataGridViewTextBoxColumn();
			dgvPrecio = new DataGridViewTextBoxColumn();
			lblTacoMasCaro = new Label();
			lblTacoPromedio = new Label();
			lblTacoMasBarato = new Label();
			btnCreateTaco = new Button();
			((System.ComponentModel.ISupportInitialize)dgvTacoDetails).BeginInit();
			SuspendLayout();
			// 
			// btnAgregarIngrediente
			// 
			btnAgregarIngrediente.Location = new Point(393, 96);
			btnAgregarIngrediente.Name = "btnAgregarIngrediente";
			btnAgregarIngrediente.Size = new Size(163, 29);
			btnAgregarIngrediente.TabIndex = 8;
			btnAgregarIngrediente.Text = "Agregar Ingrediente";
			btnAgregarIngrediente.UseVisualStyleBackColor = true;
			btnAgregarIngrediente.Click += BtnAgregarIngrediente_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(56, 63);
			label2.Name = "label2";
			label2.Size = new Size(85, 20);
			label2.TabIndex = 7;
			label2.Text = "Ingrediente";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(39, 37);
			label1.Name = "label1";
			label1.Size = new Size(119, 20);
			label1.TabIndex = 6;
			label1.Text = "Tipo Ingrediente";
			// 
			// lblTacoCreated
			// 
			lblTacoCreated.AutoSize = true;
			lblTacoCreated.Location = new Point(12, 185);
			lblTacoCreated.Name = "lblTacoCreated";
			lblTacoCreated.Size = new Size(65, 20);
			lblTacoCreated.TabIndex = 11;
			lblTacoCreated.Text = "Creaste: ";
			// 
			// cmbTipoIngrediente
			// 
			cmbTipoIngrediente.FormattingEnabled = true;
			cmbTipoIngrediente.Items.AddRange(new object[] { "Tortilla", "Relleno", "Salsa" });
			cmbTipoIngrediente.Location = new Point(177, 28);
			cmbTipoIngrediente.Name = "cmbTipoIngrediente";
			cmbTipoIngrediente.Size = new Size(379, 28);
			cmbTipoIngrediente.TabIndex = 12;
			cmbTipoIngrediente.SelectedIndexChanged += CmbTipoIngrediente_SelectedIndexChanged;
			// 
			// cmbIngrediente
			// 
			cmbIngrediente.FormattingEnabled = true;
			cmbIngrediente.Location = new Point(177, 60);
			cmbIngrediente.Name = "cmbIngrediente";
			cmbIngrediente.Size = new Size(379, 28);
			cmbIngrediente.TabIndex = 13;
			// 
			// dgvTacoDetails
			// 
			dgvTacoDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTacoDetails.Columns.AddRange(new DataGridViewColumn[] { dgvIdTaco, dgvPrecio });
			dgvTacoDetails.Location = new Point(12, 226);
			dgvTacoDetails.Name = "dgvTacoDetails";
			dgvTacoDetails.RowHeadersWidth = 51;
			dgvTacoDetails.RowTemplate.Height = 29;
			dgvTacoDetails.Size = new Size(581, 230);
			dgvTacoDetails.TabIndex = 14;
			// 
			// dgvIdTaco
			// 
			dgvIdTaco.HeaderText = "Taco Nro";
			dgvIdTaco.MinimumWidth = 6;
			dgvIdTaco.Name = "dgvIdTaco";
			dgvIdTaco.Width = 125;
			// 
			// dgvPrecio
			// 
			dgvPrecio.HeaderText = "Precio";
			dgvPrecio.MinimumWidth = 6;
			dgvPrecio.Name = "dgvPrecio";
			dgvPrecio.Width = 125;
			// 
			// lblTacoMasCaro
			// 
			lblTacoMasCaro.AutoSize = true;
			lblTacoMasCaro.Location = new Point(12, 478);
			lblTacoMasCaro.Name = "lblTacoMasCaro";
			lblTacoMasCaro.Size = new Size(105, 20);
			lblTacoMasCaro.TabIndex = 15;
			lblTacoMasCaro.Text = "Taco mas Caro";
			// 
			// lblTacoPromedio
			// 
			lblTacoPromedio.AutoSize = true;
			lblTacoPromedio.Location = new Point(244, 478);
			lblTacoPromedio.Name = "lblTacoPromedio";
			lblTacoPromedio.Size = new Size(108, 20);
			lblTacoPromedio.TabIndex = 16;
			lblTacoPromedio.Text = "Taco Promedio";
			// 
			// lblTacoMasBarato
			// 
			lblTacoMasBarato.AutoSize = true;
			lblTacoMasBarato.Location = new Point(475, 478);
			lblTacoMasBarato.Name = "lblTacoMasBarato";
			lblTacoMasBarato.Size = new Size(118, 20);
			lblTacoMasBarato.TabIndex = 17;
			lblTacoMasBarato.Text = "Taco mas Barato";
			// 
			// btnCreateTaco
			// 
			btnCreateTaco.Location = new Point(475, 176);
			btnCreateTaco.Name = "btnCreateTaco";
			btnCreateTaco.Size = new Size(118, 29);
			btnCreateTaco.TabIndex = 18;
			btnCreateTaco.Text = "Agregar Taco";
			btnCreateTaco.UseVisualStyleBackColor = true;
			btnCreateTaco.Click += BtnCreateTaco_Click;
			// 
			// FormCreateTaco
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(605, 518);
			Controls.Add(btnCreateTaco);
			Controls.Add(lblTacoMasBarato);
			Controls.Add(lblTacoPromedio);
			Controls.Add(lblTacoMasCaro);
			Controls.Add(dgvTacoDetails);
			Controls.Add(cmbIngrediente);
			Controls.Add(cmbTipoIngrediente);
			Controls.Add(lblTacoCreated);
			Controls.Add(btnAgregarIngrediente);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FormCreateTaco";
			Text = "FormCreateTaco";
			((System.ComponentModel.ISupportInitialize)dgvTacoDetails).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion


		private Button btnAgregarIngrediente;
		private Label label2;
		private Label label1;
		private Label lblTacoCreated;
		private ComboBox cmbTipoIngrediente;
		private ComboBox cmbIngrediente;
		private DataGridView dgvTacoDetails;
		private Label lblTacoMasCaro;
		private Label lblTacoPromedio;
		private Label lblTacoMasBarato;
		private Button btnCreateTaco;
		private DataGridViewTextBoxColumn dgvIdTaco;
		private DataGridViewTextBoxColumn dgvPrecio;
	}
}