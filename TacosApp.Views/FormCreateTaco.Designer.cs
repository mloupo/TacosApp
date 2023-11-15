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
			lblEmailCliente = new Label();
			label4 = new Label();
			txtDatosCliente = new TextBox();
			txtNroContactoCliente = new TextBox();
			btnCargaPedido = new Button();
			label5 = new Label();
			label6 = new Label();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			txtMayorValorTaco = new TextBox();
			txtPromedioValorTaco = new TextBox();
			txtMenorValorTaco = new TextBox();
			ClienteGroup = new GroupBox();
			ckbDelivery = new CheckBox();
			dtPickerDeliveryRequest = new DateTimePicker();
			IngredienteTacoGroup = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dgvTacoDetails).BeginInit();
			ClienteGroup.SuspendLayout();
			IngredienteTacoGroup.SuspendLayout();
			SuspendLayout();
			// 
			// btnAgregarIngrediente
			// 
			btnAgregarIngrediente.Location = new Point(378, 329);
			btnAgregarIngrediente.Name = "btnAgregarIngrediente";
			btnAgregarIngrediente.Size = new Size(257, 29);
			btnAgregarIngrediente.TabIndex = 8;
			btnAgregarIngrediente.Text = "Agregar Ingrediente";
			btnAgregarIngrediente.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 70);
			label2.Name = "label2";
			label2.Size = new Size(108, 20);
			label2.TabIndex = 7;
			label2.Text = "Ingrediente";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 35);
			label1.Name = "label1";
			label1.Size = new Size(153, 20);
			label1.TabIndex = 6;
			label1.Text = "Tipo Ingrediente";
			// 
			// lblTacoCreated
			// 
			lblTacoCreated.AutoSize = true;
			lblTacoCreated.Location = new Point(11, 379);
			lblTacoCreated.Name = "lblTacoCreated";
			lblTacoCreated.Size = new Size(108, 20);
			lblTacoCreated.TabIndex = 11;
			lblTacoCreated.Text = "Taco Info: ";
			// 
			// cmbTipoIngrediente
			// 
			cmbTipoIngrediente.FormattingEnabled = true;
			cmbTipoIngrediente.Location = new Point(185, 32);
			cmbTipoIngrediente.Name = "cmbTipoIngrediente";
			cmbTipoIngrediente.Size = new Size(439, 28);
			cmbTipoIngrediente.TabIndex = 12;
			cmbTipoIngrediente.SelectedIndexChanged += cmbTipoIngrediente_SelectedIndexChanged;
			// 
			// cmbIngrediente
			// 
			cmbIngrediente.FormattingEnabled = true;
			cmbIngrediente.Location = new Point(185, 66);
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
			btnCreateTaco.Location = new Point(645, 370);
			btnCreateTaco.Name = "btnCreateTaco";
			btnCreateTaco.Size = new Size(183, 29);
			btnCreateTaco.TabIndex = 18;
			btnCreateTaco.Text = "Agregar Taco";
			btnCreateTaco.UseVisualStyleBackColor = true;
			// 
			// lblEmailCliente
			// 
			lblEmailCliente.AutoSize = true;
			lblEmailCliente.Location = new Point(48, 29);
			lblEmailCliente.Name = "lblEmailCliente";
			lblEmailCliente.Size = new Size(54, 20);
			lblEmailCliente.TabIndex = 19;
			lblEmailCliente.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(48, 62);
			label4.Name = "label4";
			label4.Size = new Size(117, 20);
			label4.TabIndex = 20;
			label4.Text = "Nro Contacto";
			// 
			// txtDatosCliente
			// 
			txtDatosCliente.Location = new Point(165, 26);
			txtDatosCliente.Name = "txtDatosCliente";
			txtDatosCliente.Size = new Size(458, 27);
			txtDatosCliente.TabIndex = 21;
			// 
			// txtNroContactoCliente
			// 
			txtNroContactoCliente.Location = new Point(165, 59);
			txtNroContactoCliente.Name = "txtNroContactoCliente";
			txtNroContactoCliente.Size = new Size(458, 27);
			txtNroContactoCliente.TabIndex = 22;
			// 
			// btnCargaPedido
			// 
			btnCargaPedido.Location = new Point(540, 756);
			btnCargaPedido.Name = "btnCargaPedido";
			btnCargaPedido.Size = new Size(255, 29);
			btnCargaPedido.TabIndex = 23;
			btnCargaPedido.Text = "Confirmar Pedido";
			btnCargaPedido.UseVisualStyleBackColor = true;
			btnCargaPedido.Click += btnCargaPedido_Click;
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
			// txtMayorValorTaco
			// 
			txtMayorValorTaco.Location = new Point(178, 631);
			txtMayorValorTaco.Name = "txtMayorValorTaco";
			txtMayorValorTaco.Size = new Size(260, 27);
			txtMayorValorTaco.TabIndex = 28;
			// 
			// txtPromedioValorTaco
			// 
			txtPromedioValorTaco.Location = new Point(178, 674);
			txtPromedioValorTaco.Name = "txtPromedioValorTaco";
			txtPromedioValorTaco.Size = new Size(260, 27);
			txtPromedioValorTaco.TabIndex = 29;
			// 
			// txtMenorValorTaco
			// 
			txtMenorValorTaco.Location = new Point(178, 714);
			txtMenorValorTaco.Name = "txtMenorValorTaco";
			txtMenorValorTaco.Size = new Size(260, 27);
			txtMenorValorTaco.TabIndex = 30;
			// 
			// ClienteGroup
			// 
			ClienteGroup.Controls.Add(ckbDelivery);
			ClienteGroup.Controls.Add(dtPickerDeliveryRequest);
			ClienteGroup.Controls.Add(txtDatosCliente);
			ClienteGroup.Controls.Add(lblEmailCliente);
			ClienteGroup.Controls.Add(label4);
			ClienteGroup.Controls.Add(txtNroContactoCliente);
			ClienteGroup.Location = new Point(12, 27);
			ClienteGroup.Name = "ClienteGroup";
			ClienteGroup.Size = new Size(832, 147);
			ClienteGroup.TabIndex = 31;
			ClienteGroup.TabStop = false;
			ClienteGroup.Text = "CLIENTE";
			// 
			// ckbDelivery
			// 
			ckbDelivery.AutoSize = true;
			ckbDelivery.Location = new Point(48, 101);
			ckbDelivery.Name = "ckbDelivery";
			ckbDelivery.Size = new Size(103, 24);
			ckbDelivery.TabIndex = 24;
			ckbDelivery.Text = "Delivery";
			ckbDelivery.UseVisualStyleBackColor = true;
			ckbDelivery.CheckedChanged += ckbDelivery_CheckedChanged;
			// 
			// dtPickerDeliveryRequest
			// 
			dtPickerDeliveryRequest.Location = new Point(165, 101);
			dtPickerDeliveryRequest.Name = "dtPickerDeliveryRequest";
			dtPickerDeliveryRequest.Size = new Size(250, 27);
			dtPickerDeliveryRequest.TabIndex = 23;
			// 
			// IngredienteTacoGroup
			// 
			IngredienteTacoGroup.Controls.Add(label1);
			IngredienteTacoGroup.Controls.Add(cmbIngrediente);
			IngredienteTacoGroup.Controls.Add(cmbTipoIngrediente);
			IngredienteTacoGroup.Controls.Add(label2);
			IngredienteTacoGroup.Location = new Point(11, 210);
			IngredienteTacoGroup.Name = "IngredienteTacoGroup";
			IngredienteTacoGroup.Size = new Size(844, 101);
			IngredienteTacoGroup.TabIndex = 32;
			IngredienteTacoGroup.TabStop = false;
			IngredienteTacoGroup.Text = "INGREDIENTE TACO";
			// 
			// FormCreateTaco
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(854, 797);
			Controls.Add(btnAgregarIngrediente);
			Controls.Add(txtMenorValorTaco);
			Controls.Add(txtPromedioValorTaco);
			Controls.Add(txtMayorValorTaco);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(btnCargaPedido);
			Controls.Add(btnCreateTaco);
			Controls.Add(lblTacoMasBarato);
			Controls.Add(lblTacoPromedio);
			Controls.Add(lblTacoMasCaro);
			Controls.Add(dgvTacoDetails);
			Controls.Add(lblTacoCreated);
			Controls.Add(ClienteGroup);
			Controls.Add(IngredienteTacoGroup);
			Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "FormCreateTaco";
			Text = "FormCreateTaco";
			Load += FormCreateTaco_Load;
			((System.ComponentModel.ISupportInitialize)dgvTacoDetails).EndInit();
			ClienteGroup.ResumeLayout(false);
			ClienteGroup.PerformLayout();
			IngredienteTacoGroup.ResumeLayout(false);
			IngredienteTacoGroup.PerformLayout();
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
		private Label lblEmailCliente;
		private Label label4;
		private TextBox txtDatosCliente;
		private TextBox txtNroContactoCliente;
		private Button btnCargaPedido;
		private Label label5;
		private Label label6;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox txtMayorValorTaco;
		private TextBox txtPromedioValorTaco;
		private TextBox txtMenorValorTaco;
		private GroupBox ClienteGroup;
		private GroupBox IngredienteTacoGroup;
		private CheckBox ckbDelivery;
		private DateTimePicker dtPickerDeliveryRequest;
	}
}