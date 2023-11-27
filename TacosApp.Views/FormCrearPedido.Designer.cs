namespace Views
{
	partial class FormCrearPedido
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
			btnCargaPedido = new Button();
			label5 = new Label();
			label6 = new Label();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			txtMayorValorTaco = new TextBox();
			txtPromedioValorTaco = new TextBox();
			txtMenorValorTaco = new TextBox();
			IngredienteTacoGroup = new GroupBox();
			dgvIngredientesTacoDetalle = new DataGridView();
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			tacoBindingSource = new BindingSource(components);
			txtNroContactoCliente = new TextBox();
			label4 = new Label();
			lblEmailCliente = new Label();
			txtDatosCliente = new TextBox();
			dtPickerDeliveryRequest = new DateTimePicker();
			ckbDelivery = new CheckBox();
			ClienteGroup = new GroupBox();
			gbBebidas = new GroupBox();
			ckbBebida = new CheckBox();
			textBox1 = new TextBox();
			lblTipoBebida = new Label();
			lblBebida = new Label();
			textBox2 = new TextBox();
			gbEstadisticas = new GroupBox();
			gbConfirmarPedido = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dgvTacoDetails).BeginInit();
			IngredienteTacoGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvIngredientesTacoDetalle).BeginInit();
			((System.ComponentModel.ISupportInitialize)tacoBindingSource).BeginInit();
			ClienteGroup.SuspendLayout();
			gbBebidas.SuspendLayout();
			gbEstadisticas.SuspendLayout();
			gbConfirmarPedido.SuspendLayout();
			SuspendLayout();
			// 
			// btnAgregarIngrediente
			// 
			btnAgregarIngrediente.Location = new Point(327, 91);
			btnAgregarIngrediente.Name = "btnAgregarIngrediente";
			btnAgregarIngrediente.Size = new Size(228, 26);
			btnAgregarIngrediente.TabIndex = 8;
			btnAgregarIngrediente.Text = "Agregar Ingrediente";
			btnAgregarIngrediente.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(11, 63);
			label2.Name = "label2";
			label2.Size = new Size(96, 18);
			label2.TabIndex = 7;
			label2.Text = "Ingrediente";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(11, 32);
			label1.Name = "label1";
			label1.Size = new Size(136, 18);
			label1.TabIndex = 6;
			label1.Text = "Tipo Ingrediente";
			// 
			// lblTacoCreated
			// 
			lblTacoCreated.AutoSize = true;
			lblTacoCreated.Location = new Point(11, 110);
			lblTacoCreated.Name = "lblTacoCreated";
			lblTacoCreated.Size = new Size(96, 18);
			lblTacoCreated.TabIndex = 11;
			lblTacoCreated.Text = "Taco Info: ";
			// 
			// cmbTipoIngrediente
			// 
			cmbTipoIngrediente.FormattingEnabled = true;
			cmbTipoIngrediente.Location = new Point(164, 29);
			cmbTipoIngrediente.Name = "cmbTipoIngrediente";
			cmbTipoIngrediente.Size = new Size(391, 26);
			cmbTipoIngrediente.TabIndex = 12;
			cmbTipoIngrediente.SelectedIndexChanged += cmbTipoIngrediente_SelectedIndexChanged;
			// 
			// cmbIngrediente
			// 
			cmbIngrediente.FormattingEnabled = true;
			cmbIngrediente.Location = new Point(164, 59);
			cmbIngrediente.Name = "cmbIngrediente";
			cmbIngrediente.Size = new Size(391, 26);
			cmbIngrediente.TabIndex = 13;
			// 
			// dgvTacoDetails
			// 
			dgvTacoDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTacoDetails.Columns.AddRange(new DataGridViewColumn[] { dgvIdTaco, dgvPrecio });
			dgvTacoDetails.Location = new Point(11, 338);
			dgvTacoDetails.Name = "dgvTacoDetails";
			dgvTacoDetails.RowHeadersWidth = 51;
			dgvTacoDetails.RowTemplate.Height = 29;
			dgvTacoDetails.Size = new Size(544, 152);
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
			lblTacoMasCaro.Location = new Point(44, 24);
			lblTacoMasCaro.Name = "lblTacoMasCaro";
			lblTacoMasCaro.Size = new Size(112, 18);
			lblTacoMasCaro.TabIndex = 15;
			lblTacoMasCaro.Text = "Taco mas Caro";
			// 
			// lblTacoPromedio
			// 
			lblTacoPromedio.AutoSize = true;
			lblTacoPromedio.Location = new Point(44, 63);
			lblTacoPromedio.Name = "lblTacoPromedio";
			lblTacoPromedio.Size = new Size(112, 18);
			lblTacoPromedio.TabIndex = 16;
			lblTacoPromedio.Text = "Taco Promedio";
			// 
			// lblTacoMasBarato
			// 
			lblTacoMasBarato.AutoSize = true;
			lblTacoMasBarato.Location = new Point(44, 105);
			lblTacoMasBarato.Name = "lblTacoMasBarato";
			lblTacoMasBarato.Size = new Size(128, 18);
			lblTacoMasBarato.TabIndex = 17;
			lblTacoMasBarato.Text = "Taco mas Barato";
			// 
			// btnCreateTaco
			// 
			btnCreateTaco.Location = new Point(392, 288);
			btnCreateTaco.Name = "btnCreateTaco";
			btnCreateTaco.Size = new Size(163, 26);
			btnCreateTaco.TabIndex = 18;
			btnCreateTaco.Text = "Agregar Taco";
			btnCreateTaco.UseVisualStyleBackColor = true;
			// 
			// btnCargaPedido
			// 
			btnCargaPedido.Location = new Point(14, 86);
			btnCargaPedido.Name = "btnCargaPedido";
			btnCargaPedido.Size = new Size(227, 26);
			btnCargaPedido.TabIndex = 23;
			btnCargaPedido.Text = "Confirmar Pedido";
			btnCargaPedido.UseVisualStyleBackColor = true;
			btnCargaPedido.Click += btnCargaPedido_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(14, 27);
			label5.Name = "label5";
			label5.Size = new Size(96, 18);
			label5.TabIndex = 24;
			label5.Text = "Pedido Nro:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(14, 55);
			label6.Name = "label6";
			label6.Size = new Size(72, 18);
			label6.TabIndex = 25;
			label6.Text = "Importe:";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(107, 24);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(125, 25);
			textBox3.TabIndex = 26;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(107, 52);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(125, 25);
			textBox4.TabIndex = 27;
			// 
			// txtMayorValorTaco
			// 
			txtMayorValorTaco.Location = new Point(186, 24);
			txtMayorValorTaco.Name = "txtMayorValorTaco";
			txtMayorValorTaco.Size = new Size(79, 25);
			txtMayorValorTaco.TabIndex = 28;
			// 
			// txtPromedioValorTaco
			// 
			txtPromedioValorTaco.Location = new Point(186, 63);
			txtPromedioValorTaco.Name = "txtPromedioValorTaco";
			txtPromedioValorTaco.Size = new Size(79, 25);
			txtPromedioValorTaco.TabIndex = 29;
			// 
			// txtMenorValorTaco
			// 
			txtMenorValorTaco.Location = new Point(186, 99);
			txtMenorValorTaco.Name = "txtMenorValorTaco";
			txtMenorValorTaco.Size = new Size(79, 25);
			txtMenorValorTaco.TabIndex = 30;
			// 
			// IngredienteTacoGroup
			// 
			IngredienteTacoGroup.Controls.Add(dgvIngredientesTacoDetalle);
			IngredienteTacoGroup.Controls.Add(label1);
			IngredienteTacoGroup.Controls.Add(btnAgregarIngrediente);
			IngredienteTacoGroup.Controls.Add(dgvTacoDetails);
			IngredienteTacoGroup.Controls.Add(cmbIngrediente);
			IngredienteTacoGroup.Controls.Add(cmbTipoIngrediente);
			IngredienteTacoGroup.Controls.Add(label2);
			IngredienteTacoGroup.Controls.Add(lblTacoCreated);
			IngredienteTacoGroup.Controls.Add(btnCreateTaco);
			IngredienteTacoGroup.Location = new Point(10, 12);
			IngredienteTacoGroup.Name = "IngredienteTacoGroup";
			IngredienteTacoGroup.Size = new Size(566, 518);
			IngredienteTacoGroup.TabIndex = 32;
			IngredienteTacoGroup.TabStop = false;
			IngredienteTacoGroup.Text = "Arma Tu Taco";
			// 
			// dgvIngredientesTacoDetalle
			// 
			dgvIngredientesTacoDetalle.AutoGenerateColumns = false;
			dgvIngredientesTacoDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvIngredientesTacoDetalle.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn });
			dgvIngredientesTacoDetalle.DataSource = tacoBindingSource;
			dgvIngredientesTacoDetalle.Location = new Point(11, 131);
			dgvIngredientesTacoDetalle.Name = "dgvIngredientesTacoDetalle";
			dgvIngredientesTacoDetalle.RowHeadersWidth = 51;
			dgvIngredientesTacoDetalle.RowTemplate.Height = 29;
			dgvIngredientesTacoDetalle.Size = new Size(544, 151);
			dgvIngredientesTacoDetalle.TabIndex = 19;
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "Id";
			idDataGridViewTextBoxColumn.MinimumWidth = 6;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.ReadOnly = true;
			idDataGridViewTextBoxColumn.Width = 125;
			// 
			// tacoBindingSource
			// 
			tacoBindingSource.DataSource = typeof(TacosApp.Model.EntidadesProducto.Taco);
			// 
			// txtNroContactoCliente
			// 
			txtNroContactoCliente.Location = new Point(147, 53);
			txtNroContactoCliente.Name = "txtNroContactoCliente";
			txtNroContactoCliente.Size = new Size(408, 25);
			txtNroContactoCliente.TabIndex = 22;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(43, 56);
			label4.Name = "label4";
			label4.Size = new Size(104, 18);
			label4.TabIndex = 20;
			label4.Text = "Nro Contacto";
			// 
			// lblEmailCliente
			// 
			lblEmailCliente.AutoSize = true;
			lblEmailCliente.Location = new Point(43, 26);
			lblEmailCliente.Name = "lblEmailCliente";
			lblEmailCliente.Size = new Size(48, 18);
			lblEmailCliente.TabIndex = 19;
			lblEmailCliente.Text = "Email";
			// 
			// txtDatosCliente
			// 
			txtDatosCliente.Location = new Point(147, 23);
			txtDatosCliente.Name = "txtDatosCliente";
			txtDatosCliente.Size = new Size(408, 25);
			txtDatosCliente.TabIndex = 21;
			// 
			// dtPickerDeliveryRequest
			// 
			dtPickerDeliveryRequest.Location = new Point(332, 84);
			dtPickerDeliveryRequest.Name = "dtPickerDeliveryRequest";
			dtPickerDeliveryRequest.Size = new Size(223, 25);
			dtPickerDeliveryRequest.TabIndex = 23;
			// 
			// ckbDelivery
			// 
			ckbDelivery.AutoSize = true;
			ckbDelivery.Location = new Point(43, 91);
			ckbDelivery.Name = "ckbDelivery";
			ckbDelivery.Size = new Size(190, 22);
			ckbDelivery.TabIndex = 24;
			ckbDelivery.Text = "Solicita tu Delivery";
			ckbDelivery.UseVisualStyleBackColor = true;
			ckbDelivery.CheckedChanged += ckbDelivery_CheckedChanged;
			// 
			// ClienteGroup
			// 
			ClienteGroup.Controls.Add(ckbDelivery);
			ClienteGroup.Controls.Add(dtPickerDeliveryRequest);
			ClienteGroup.Controls.Add(txtDatosCliente);
			ClienteGroup.Controls.Add(lblEmailCliente);
			ClienteGroup.Controls.Add(label4);
			ClienteGroup.Controls.Add(txtNroContactoCliente);
			ClienteGroup.Location = new Point(582, 162);
			ClienteGroup.Name = "ClienteGroup";
			ClienteGroup.Size = new Size(565, 132);
			ClienteGroup.TabIndex = 31;
			ClienteGroup.TabStop = false;
			ClienteGroup.Text = "Envios";
			// 
			// gbBebidas
			// 
			gbBebidas.Controls.Add(ckbBebida);
			gbBebidas.Controls.Add(textBox1);
			gbBebidas.Controls.Add(lblTipoBebida);
			gbBebidas.Controls.Add(lblBebida);
			gbBebidas.Controls.Add(textBox2);
			gbBebidas.Location = new Point(582, 24);
			gbBebidas.Name = "gbBebidas";
			gbBebidas.Size = new Size(564, 132);
			gbBebidas.TabIndex = 33;
			gbBebidas.TabStop = false;
			gbBebidas.Text = "Bebidas";
			// 
			// ckbBebida
			// 
			ckbBebida.AutoSize = true;
			ckbBebida.Location = new Point(43, 91);
			ckbBebida.Name = "ckbBebida";
			ckbBebida.Size = new Size(166, 22);
			ckbBebida.TabIndex = 24;
			ckbBebida.Text = "Agrega una Bebida";
			ckbBebida.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(147, 23);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(408, 25);
			textBox1.TabIndex = 21;
			// 
			// lblTipoBebida
			// 
			lblTipoBebida.AutoSize = true;
			lblTipoBebida.Location = new Point(43, 26);
			lblTipoBebida.Name = "lblTipoBebida";
			lblTipoBebida.Size = new Size(40, 18);
			lblTipoBebida.TabIndex = 19;
			lblTipoBebida.Text = "Tipo";
			// 
			// lblBebida
			// 
			lblBebida.AutoSize = true;
			lblBebida.Location = new Point(43, 56);
			lblBebida.Name = "lblBebida";
			lblBebida.Size = new Size(56, 18);
			lblBebida.TabIndex = 20;
			lblBebida.Text = "Bebida";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(147, 53);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(408, 25);
			textBox2.TabIndex = 22;
			// 
			// gbEstadisticas
			// 
			gbEstadisticas.Controls.Add(txtMayorValorTaco);
			gbEstadisticas.Controls.Add(lblTacoMasCaro);
			gbEstadisticas.Controls.Add(txtMenorValorTaco);
			gbEstadisticas.Controls.Add(lblTacoPromedio);
			gbEstadisticas.Controls.Add(txtPromedioValorTaco);
			gbEstadisticas.Controls.Add(lblTacoMasBarato);
			gbEstadisticas.Location = new Point(582, 300);
			gbEstadisticas.Name = "gbEstadisticas";
			gbEstadisticas.Size = new Size(565, 151);
			gbEstadisticas.TabIndex = 34;
			gbEstadisticas.TabStop = false;
			gbEstadisticas.Text = "Estadisticas";
			// 
			// gbConfirmarPedido
			// 
			gbConfirmarPedido.Controls.Add(textBox3);
			gbConfirmarPedido.Controls.Add(btnCargaPedido);
			gbConfirmarPedido.Controls.Add(label5);
			gbConfirmarPedido.Controls.Add(textBox4);
			gbConfirmarPedido.Controls.Add(label6);
			gbConfirmarPedido.Location = new Point(896, 457);
			gbConfirmarPedido.Name = "gbConfirmarPedido";
			gbConfirmarPedido.Size = new Size(250, 125);
			gbConfirmarPedido.TabIndex = 35;
			gbConfirmarPedido.TabStop = false;
			gbConfirmarPedido.Text = "Confirmacion";
			// 
			// FormCrearPedido
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1159, 604);
			Controls.Add(gbConfirmarPedido);
			Controls.Add(gbEstadisticas);
			Controls.Add(gbBebidas);
			Controls.Add(ClienteGroup);
			Controls.Add(IngredienteTacoGroup);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "FormCrearPedido";
			Text = "Crear Pedido";
			Load += FormCreateTaco_Load;
			((System.ComponentModel.ISupportInitialize)dgvTacoDetails).EndInit();
			IngredienteTacoGroup.ResumeLayout(false);
			IngredienteTacoGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvIngredientesTacoDetalle).EndInit();
			((System.ComponentModel.ISupportInitialize)tacoBindingSource).EndInit();
			ClienteGroup.ResumeLayout(false);
			ClienteGroup.PerformLayout();
			gbBebidas.ResumeLayout(false);
			gbBebidas.PerformLayout();
			gbEstadisticas.ResumeLayout(false);
			gbEstadisticas.PerformLayout();
			gbConfirmarPedido.ResumeLayout(false);
			gbConfirmarPedido.PerformLayout();
			ResumeLayout(false);
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
		private Button btnCargaPedido;
		private Label label5;
		private Label label6;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox txtMayorValorTaco;
		private TextBox txtPromedioValorTaco;
		private TextBox txtMenorValorTaco;
		private GroupBox IngredienteTacoGroup;
		private TextBox txtNroContactoCliente;
		private Label label4;
		private Label lblEmailCliente;
		private TextBox txtDatosCliente;
		private DateTimePicker dtPickerDeliveryRequest;
		private CheckBox ckbDelivery;
		private GroupBox ClienteGroup;
		private GroupBox gbBebidas;
		private CheckBox ckbBebida;
		private TextBox textBox1;
		private Label lblTipoBebida;
		private Label lblBebida;
		private TextBox textBox2;
		private DataGridView dgvIngredientesTacoDetalle;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private BindingSource tacoBindingSource;
		private GroupBox gbEstadisticas;
		private GroupBox gbConfirmarPedido;
	}
}