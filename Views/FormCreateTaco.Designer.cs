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
			label3 = new Label();
			label4 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			btnCargaPedido = new Button();
			label5 = new Label();
			label6 = new Label();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			((System.ComponentModel.ISupportInitialize)dgvTacoDetails).BeginInit();
			SuspendLayout();
			// 
			// btnAgregarIngrediente
			// 
			btnAgregarIngrediente.Location = new Point(657, 134);
			btnAgregarIngrediente.Name = "btnAgregarIngrediente";
			btnAgregarIngrediente.Size = new Size(183, 29);
			btnAgregarIngrediente.TabIndex = 8;
			btnAgregarIngrediente.Text = "Agregar Ingrediente";
			btnAgregarIngrediente.UseVisualStyleBackColor = true;
			btnAgregarIngrediente.Click += BtnAgregarIngrediente_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 138);
			label2.Name = "label2";
			label2.Size = new Size(108, 20);
			label2.TabIndex = 7;
			label2.Text = "Ingrediente";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 103);
			label1.Name = "label1";
			label1.Size = new Size(153, 20);
			label1.TabIndex = 6;
			label1.Text = "Tipo Ingrediente";
			// 
			// lblTacoCreated
			// 
			lblTacoCreated.AutoSize = true;
			lblTacoCreated.Location = new Point(25, 218);
			lblTacoCreated.Name = "lblTacoCreated";
			lblTacoCreated.Size = new Size(108, 20);
			lblTacoCreated.TabIndex = 11;
			lblTacoCreated.Text = "Taco Info: ";
			// 
			// cmbTipoIngrediente
			// 
			cmbTipoIngrediente.FormattingEnabled = true;
			cmbTipoIngrediente.Items.AddRange(new object[] { "Tortilla", "Relleno", "Salsa" });
			cmbTipoIngrediente.Location = new Point(188, 100);
			cmbTipoIngrediente.Name = "cmbTipoIngrediente";
			cmbTipoIngrediente.Size = new Size(439, 28);
			cmbTipoIngrediente.TabIndex = 12;
			cmbTipoIngrediente.SelectedIndexChanged += CmbTipoIngrediente_SelectedIndexChanged;
			// 
			// cmbIngrediente
			// 
			cmbIngrediente.FormattingEnabled = true;
			cmbIngrediente.Location = new Point(188, 134);
			cmbIngrediente.Name = "cmbIngrediente";
			cmbIngrediente.Size = new Size(439, 28);
			cmbIngrediente.TabIndex = 13;
			// 
			// dgvTacoDetails
			// 
			dgvTacoDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTacoDetails.Columns.AddRange(new DataGridViewColumn[] { dgvIdTaco, dgvPrecio });
			dgvTacoDetails.Location = new Point(18, 440);
			dgvTacoDetails.Name = "dgvTacoDetails";
			dgvTacoDetails.RowHeadersWidth = 51;
			dgvTacoDetails.RowTemplate.Height = 29;
			dgvTacoDetails.Size = new Size(826, 169);
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
			lblTacoMasCaro.Location = new Point(18, 631);
			lblTacoMasCaro.Name = "lblTacoMasCaro";
			lblTacoMasCaro.Size = new Size(126, 20);
			lblTacoMasCaro.TabIndex = 15;
			lblTacoMasCaro.Text = "Taco mas Caro";
			// 
			// lblTacoPromedio
			// 
			lblTacoPromedio.AutoSize = true;
			lblTacoPromedio.Location = new Point(18, 674);
			lblTacoPromedio.Name = "lblTacoPromedio";
			lblTacoPromedio.Size = new Size(126, 20);
			lblTacoPromedio.TabIndex = 16;
			lblTacoPromedio.Text = "Taco Promedio";
			// 
			// lblTacoMasBarato
			// 
			lblTacoMasBarato.AutoSize = true;
			lblTacoMasBarato.Location = new Point(18, 721);
			lblTacoMasBarato.Name = "lblTacoMasBarato";
			lblTacoMasBarato.Size = new Size(144, 20);
			lblTacoMasBarato.TabIndex = 17;
			lblTacoMasBarato.Text = "Taco mas Barato";
			// 
			// btnCreateTaco
			// 
			btnCreateTaco.Location = new Point(660, 209);
			btnCreateTaco.Name = "btnCreateTaco";
			btnCreateTaco.Size = new Size(183, 29);
			btnCreateTaco.TabIndex = 18;
			btnCreateTaco.Text = "Agregar Taco";
			btnCreateTaco.UseVisualStyleBackColor = true;
			btnCreateTaco.Click += BtnCreateTaco_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(18, 25);
			label3.Name = "label3";
			label3.Size = new Size(72, 20);
			label3.TabIndex = 19;
			label3.Text = "Cliente";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(18, 58);
			label4.Name = "label4";
			label4.Size = new Size(117, 20);
			label4.TabIndex = 20;
			label4.Text = "Nro Contacto";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(135, 22);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(550, 27);
			textBox1.TabIndex = 21;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(135, 55);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(550, 27);
			textBox2.TabIndex = 22;
			// 
			// btnCargaPedido
			// 
			btnCargaPedido.Location = new Point(540, 756);
			btnCargaPedido.Name = "btnCargaPedido";
			btnCargaPedido.Size = new Size(255, 29);
			btnCargaPedido.TabIndex = 23;
			btnCargaPedido.Text = "Confirmar Pedido";
			btnCargaPedido.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(540, 690);
			label5.Name = "label5";
			label5.Size = new Size(108, 20);
			label5.TabIndex = 24;
			label5.Text = "Pedido Nro:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(540, 721);
			label6.Name = "label6";
			label6.Size = new Size(81, 20);
			label6.TabIndex = 25;
			label6.Text = "Importe:";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(645, 687);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(140, 27);
			textBox3.TabIndex = 26;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(645, 718);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(140, 27);
			textBox4.TabIndex = 27;
			// 
			// FormCreateTaco
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(854, 797);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(btnCargaPedido);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(label3);
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
			Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
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
		private Label label3;
		private Label label4;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button btnCargaPedido;
		private Label label5;
		private Label label6;
		private TextBox textBox3;
		private TextBox textBox4;
	}
}