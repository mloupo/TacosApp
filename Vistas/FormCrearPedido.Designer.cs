namespace Vistas
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
			lblIngrediente = new Label();
			lblTipoIngrediente = new Label();
			lblTacoInfo = new Label();
			cmbTipoIngrediente = new ComboBox();
			cmbIngrediente = new ComboBox();
			dgvTacoDetails = new DataGridView();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			tacoBindingSource = new BindingSource(components);
			lblTacoMasCaro = new Label();
			lblTacoPromedio = new Label();
			lblTacoMasBarato = new Label();
			btnCrearTaco = new Button();
			btnCargaPedido = new Button();
			lblNumeroPedido = new Label();
			lblImporteTotaPedido = new Label();
			txtNumeroPedido = new TextBox();
			txtImporteTotalPedido = new TextBox();
			txtMayorValorTaco = new TextBox();
			txtPromedioValorTaco = new TextBox();
			txtMenorValorTaco = new TextBox();
			IngredienteTacoGroup = new GroupBox();
			dgvIngredientesTacoDetalle = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			cantidadMaximaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			rellenoBindingSource = new BindingSource(components);
			txtNroContactoCliente = new TextBox();
			label4 = new Label();
			lblEmailCliente = new Label();
			dtPickerDeliveryRequest = new DateTimePicker();
			ckbDelivery = new CheckBox();
			ClienteGroup = new GroupBox();
			cmbNombreCliente = new ComboBox();
			btnAgregarContactoDelivery = new Button();
			gbBebidas = new GroupBox();
			btnAgregarBebida = new Button();
			cmbBebida = new ComboBox();
			cmbTipoBebida = new ComboBox();
			ckbBebida = new CheckBox();
			lblTipoBebida = new Label();
			lblBebida = new Label();
			gbEstadisticas = new GroupBox();
			gbConfirmarPedido = new GroupBox();
			contactoBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dgvTacoDetails).BeginInit();
			((System.ComponentModel.ISupportInitialize)tacoBindingSource).BeginInit();
			IngredienteTacoGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvIngredientesTacoDetalle).BeginInit();
			((System.ComponentModel.ISupportInitialize)rellenoBindingSource).BeginInit();
			ClienteGroup.SuspendLayout();
			gbBebidas.SuspendLayout();
			gbEstadisticas.SuspendLayout();
			gbConfirmarPedido.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)contactoBindingSource).BeginInit();
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
			btnAgregarIngrediente.Click += btnAgregarIngrediente_Click;
			// 
			// lblIngrediente
			// 
			lblIngrediente.AutoSize = true;
			lblIngrediente.Location = new Point(11, 63);
			lblIngrediente.Name = "lblIngrediente";
			lblIngrediente.Size = new Size(96, 18);
			lblIngrediente.TabIndex = 7;
			lblIngrediente.Text = "Ingrediente";
			// 
			// lblTipoIngrediente
			// 
			lblTipoIngrediente.AutoSize = true;
			lblTipoIngrediente.Location = new Point(11, 32);
			lblTipoIngrediente.Name = "lblTipoIngrediente";
			lblTipoIngrediente.Size = new Size(136, 18);
			lblTipoIngrediente.TabIndex = 6;
			lblTipoIngrediente.Text = "Tipo Ingrediente";
			// 
			// lblTacoInfo
			// 
			lblTacoInfo.AutoSize = true;
			lblTacoInfo.Location = new Point(11, 138);
			lblTacoInfo.Name = "lblTacoInfo";
			lblTacoInfo.Size = new Size(96, 18);
			lblTacoInfo.TabIndex = 11;
			lblTacoInfo.Text = "Taco Info: ";
			// 
			// cmbTipoIngrediente
			// 
			cmbTipoIngrediente.FormattingEnabled = true;
			cmbTipoIngrediente.Location = new Point(164, 29);
			cmbTipoIngrediente.Name = "cmbTipoIngrediente";
			cmbTipoIngrediente.Size = new Size(391, 26);
			cmbTipoIngrediente.TabIndex = 12;
			cmbTipoIngrediente.Text = "Tipo Ingrediente";
			cmbTipoIngrediente.SelectedIndexChanged += cmbTipoIngrediente_SelectedIndexChanged;
			// 
			// cmbIngrediente
			// 
			cmbIngrediente.FormattingEnabled = true;
			cmbIngrediente.Location = new Point(164, 59);
			cmbIngrediente.Name = "cmbIngrediente";
			cmbIngrediente.Size = new Size(391, 26);
			cmbIngrediente.TabIndex = 13;
			cmbIngrediente.Text = "Ingrediente";
			// 
			// dgvTacoDetails
			// 
			dgvTacoDetails.AutoGenerateColumns = false;
			dgvTacoDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTacoDetails.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
			dgvTacoDetails.DataSource = tacoBindingSource;
			dgvTacoDetails.Location = new Point(11, 428);
			dgvTacoDetails.Name = "dgvTacoDetails";
			dgvTacoDetails.ReadOnly = true;
			dgvTacoDetails.RowHeadersWidth = 51;
			dgvTacoDetails.RowTemplate.Height = 29;
			dgvTacoDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvTacoDetails.Size = new Size(544, 152);
			dgvTacoDetails.TabIndex = 14;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.DataPropertyName = "Id";
			dataGridViewTextBoxColumn2.HeaderText = "Id";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			dataGridViewTextBoxColumn2.Width = 125;
			// 
			// tacoBindingSource
			// 
			tacoBindingSource.DataSource = typeof(Modelo.EntidadesProducto.Tacos.Taco);
			// 
			// lblTacoMasCaro
			// 
			lblTacoMasCaro.AutoSize = true;
			lblTacoMasCaro.Location = new Point(30, 44);
			lblTacoMasCaro.Name = "lblTacoMasCaro";
			lblTacoMasCaro.Size = new Size(112, 18);
			lblTacoMasCaro.TabIndex = 15;
			lblTacoMasCaro.Text = "Taco mas Caro";
			// 
			// lblTacoPromedio
			// 
			lblTacoPromedio.AutoSize = true;
			lblTacoPromedio.Location = new Point(30, 75);
			lblTacoPromedio.Name = "lblTacoPromedio";
			lblTacoPromedio.Size = new Size(112, 18);
			lblTacoPromedio.TabIndex = 16;
			lblTacoPromedio.Text = "Taco Promedio";
			// 
			// lblTacoMasBarato
			// 
			lblTacoMasBarato.AutoSize = true;
			lblTacoMasBarato.Location = new Point(30, 106);
			lblTacoMasBarato.Name = "lblTacoMasBarato";
			lblTacoMasBarato.Size = new Size(128, 18);
			lblTacoMasBarato.TabIndex = 17;
			lblTacoMasBarato.Text = "Taco mas Barato";
			// 
			// btnCrearTaco
			// 
			btnCrearTaco.Location = new Point(392, 332);
			btnCrearTaco.Name = "btnCrearTaco";
			btnCrearTaco.Size = new Size(163, 26);
			btnCrearTaco.TabIndex = 18;
			btnCrearTaco.Text = "Agregar Taco";
			btnCrearTaco.UseVisualStyleBackColor = true;
			btnCrearTaco.Click += btnCrearTaco_Click;
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
			// lblNumeroPedido
			// 
			lblNumeroPedido.AutoSize = true;
			lblNumeroPedido.Location = new Point(14, 27);
			lblNumeroPedido.Name = "lblNumeroPedido";
			lblNumeroPedido.Size = new Size(96, 18);
			lblNumeroPedido.TabIndex = 24;
			lblNumeroPedido.Text = "Pedido Nro:";
			// 
			// lblImporteTotaPedido
			// 
			lblImporteTotaPedido.AutoSize = true;
			lblImporteTotaPedido.Location = new Point(14, 55);
			lblImporteTotaPedido.Name = "lblImporteTotaPedido";
			lblImporteTotaPedido.Size = new Size(72, 18);
			lblImporteTotaPedido.TabIndex = 25;
			lblImporteTotaPedido.Text = "Importe:";
			// 
			// txtNumeroPedido
			// 
			txtNumeroPedido.Location = new Point(107, 24);
			txtNumeroPedido.Name = "txtNumeroPedido";
			txtNumeroPedido.Size = new Size(125, 25);
			txtNumeroPedido.TabIndex = 26;
			// 
			// txtImporteTotalPedido
			// 
			txtImporteTotalPedido.Location = new Point(107, 52);
			txtImporteTotalPedido.Name = "txtImporteTotalPedido";
			txtImporteTotalPedido.Size = new Size(125, 25);
			txtImporteTotalPedido.TabIndex = 27;
			// 
			// txtMayorValorTaco
			// 
			txtMayorValorTaco.Location = new Point(173, 44);
			txtMayorValorTaco.Name = "txtMayorValorTaco";
			txtMayorValorTaco.Size = new Size(79, 25);
			txtMayorValorTaco.TabIndex = 28;
			// 
			// txtPromedioValorTaco
			// 
			txtPromedioValorTaco.Location = new Point(173, 75);
			txtPromedioValorTaco.Name = "txtPromedioValorTaco";
			txtPromedioValorTaco.Size = new Size(79, 25);
			txtPromedioValorTaco.TabIndex = 29;
			// 
			// txtMenorValorTaco
			// 
			txtMenorValorTaco.Location = new Point(173, 106);
			txtMenorValorTaco.Name = "txtMenorValorTaco";
			txtMenorValorTaco.Size = new Size(79, 25);
			txtMenorValorTaco.TabIndex = 30;
			// 
			// IngredienteTacoGroup
			// 
			IngredienteTacoGroup.Controls.Add(dgvIngredientesTacoDetalle);
			IngredienteTacoGroup.Controls.Add(lblTipoIngrediente);
			IngredienteTacoGroup.Controls.Add(btnAgregarIngrediente);
			IngredienteTacoGroup.Controls.Add(dgvTacoDetails);
			IngredienteTacoGroup.Controls.Add(cmbIngrediente);
			IngredienteTacoGroup.Controls.Add(cmbTipoIngrediente);
			IngredienteTacoGroup.Controls.Add(lblIngrediente);
			IngredienteTacoGroup.Controls.Add(lblTacoInfo);
			IngredienteTacoGroup.Controls.Add(btnCrearTaco);
			IngredienteTacoGroup.Location = new Point(10, 12);
			IngredienteTacoGroup.Name = "IngredienteTacoGroup";
			IngredienteTacoGroup.Size = new Size(566, 586);
			IngredienteTacoGroup.TabIndex = 32;
			IngredienteTacoGroup.TabStop = false;
			IngredienteTacoGroup.Text = "Arma Tu Taco";
			// 
			// dgvIngredientesTacoDetalle
			// 
			dgvIngredientesTacoDetalle.AutoGenerateColumns = false;
			dgvIngredientesTacoDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvIngredientesTacoDetalle.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, precioDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, cantidadMaximaDataGridViewTextBoxColumn });
			dgvIngredientesTacoDetalle.DataSource = rellenoBindingSource;
			dgvIngredientesTacoDetalle.Location = new Point(11, 159);
			dgvIngredientesTacoDetalle.Name = "dgvIngredientesTacoDetalle";
			dgvIngredientesTacoDetalle.ReadOnly = true;
			dgvIngredientesTacoDetalle.RowHeadersWidth = 51;
			dgvIngredientesTacoDetalle.RowTemplate.Height = 29;
			dgvIngredientesTacoDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvIngredientesTacoDetalle.Size = new Size(544, 151);
			dgvIngredientesTacoDetalle.TabIndex = 19;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			dataGridViewTextBoxColumn1.HeaderText = "Id";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Width = 125;
			// 
			// precioDataGridViewTextBoxColumn
			// 
			precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
			precioDataGridViewTextBoxColumn.HeaderText = "Precio";
			precioDataGridViewTextBoxColumn.MinimumWidth = 6;
			precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
			precioDataGridViewTextBoxColumn.ReadOnly = true;
			precioDataGridViewTextBoxColumn.Width = 125;
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
			nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			nombreDataGridViewTextBoxColumn.ReadOnly = true;
			nombreDataGridViewTextBoxColumn.Width = 125;
			// 
			// cantidadMaximaDataGridViewTextBoxColumn
			// 
			cantidadMaximaDataGridViewTextBoxColumn.DataPropertyName = "CantidadMaxima";
			cantidadMaximaDataGridViewTextBoxColumn.HeaderText = "CantidadMaxima";
			cantidadMaximaDataGridViewTextBoxColumn.MinimumWidth = 6;
			cantidadMaximaDataGridViewTextBoxColumn.Name = "cantidadMaximaDataGridViewTextBoxColumn";
			cantidadMaximaDataGridViewTextBoxColumn.ReadOnly = true;
			cantidadMaximaDataGridViewTextBoxColumn.Visible = false;
			cantidadMaximaDataGridViewTextBoxColumn.Width = 125;
			// 
			// rellenoBindingSource
			// 
			rellenoBindingSource.DataSource = typeof(Modelo.EntidadesProducto.Tacos.Relleno);
			// 
			// txtNroContactoCliente
			// 
			txtNroContactoCliente.Location = new Point(129, 96);
			txtNroContactoCliente.Name = "txtNroContactoCliente";
			txtNroContactoCliente.Size = new Size(408, 25);
			txtNroContactoCliente.TabIndex = 22;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(25, 99);
			label4.Name = "label4";
			label4.Size = new Size(104, 18);
			label4.TabIndex = 20;
			label4.Text = "Nro Contacto";
			// 
			// lblEmailCliente
			// 
			lblEmailCliente.AutoSize = true;
			lblEmailCliente.Location = new Point(25, 69);
			lblEmailCliente.Name = "lblEmailCliente";
			lblEmailCliente.Size = new Size(48, 18);
			lblEmailCliente.TabIndex = 19;
			lblEmailCliente.Text = "Email";
			// 
			// dtPickerDeliveryRequest
			// 
			dtPickerDeliveryRequest.Location = new Point(25, 143);
			dtPickerDeliveryRequest.Name = "dtPickerDeliveryRequest";
			dtPickerDeliveryRequest.Size = new Size(223, 25);
			dtPickerDeliveryRequest.TabIndex = 23;
			// 
			// ckbDelivery
			// 
			ckbDelivery.AutoSize = true;
			ckbDelivery.Location = new Point(30, 24);
			ckbDelivery.Name = "ckbDelivery";
			ckbDelivery.Size = new Size(190, 22);
			ckbDelivery.TabIndex = 24;
			ckbDelivery.Text = "Solicita tu Delivery";
			ckbDelivery.UseVisualStyleBackColor = true;
			ckbDelivery.CheckedChanged += ckbDelivery_CheckedChanged;
			// 
			// ClienteGroup
			// 
			ClienteGroup.Controls.Add(cmbNombreCliente);
			ClienteGroup.Controls.Add(btnAgregarContactoDelivery);
			ClienteGroup.Controls.Add(ckbDelivery);
			ClienteGroup.Controls.Add(dtPickerDeliveryRequest);
			ClienteGroup.Controls.Add(lblEmailCliente);
			ClienteGroup.Controls.Add(label4);
			ClienteGroup.Controls.Add(txtNroContactoCliente);
			ClienteGroup.Location = new Point(582, 216);
			ClienteGroup.Name = "ClienteGroup";
			ClienteGroup.Size = new Size(565, 208);
			ClienteGroup.TabIndex = 31;
			ClienteGroup.TabStop = false;
			ClienteGroup.Text = "Envios";
			// 
			// cmbNombreCliente
			// 
			cmbNombreCliente.DataSource = contactoBindingSource;
			cmbNombreCliente.FormattingEnabled = true;
			cmbNombreCliente.Location = new Point(129, 64);
			cmbNombreCliente.Name = "cmbNombreCliente";
			cmbNombreCliente.Size = new Size(408, 26);
			cmbNombreCliente.TabIndex = 26;
			cmbNombreCliente.SelectedIndexChanged += cmbNombreCliente_SelectedIndexChanged;
			// 
			// btnAgregarContactoDelivery
			// 
			btnAgregarContactoDelivery.Location = new Point(443, 143);
			btnAgregarContactoDelivery.Name = "btnAgregarContactoDelivery";
			btnAgregarContactoDelivery.Size = new Size(94, 29);
			btnAgregarContactoDelivery.TabIndex = 25;
			btnAgregarContactoDelivery.Text = "Agregar";
			btnAgregarContactoDelivery.UseVisualStyleBackColor = true;
			btnAgregarContactoDelivery.Click += btnAgregarContactoDelivery_Click;
			// 
			// gbBebidas
			// 
			gbBebidas.Controls.Add(btnAgregarBebida);
			gbBebidas.Controls.Add(cmbBebida);
			gbBebidas.Controls.Add(cmbTipoBebida);
			gbBebidas.Controls.Add(ckbBebida);
			gbBebidas.Controls.Add(lblTipoBebida);
			gbBebidas.Controls.Add(lblBebida);
			gbBebidas.Location = new Point(582, 24);
			gbBebidas.Name = "gbBebidas";
			gbBebidas.Size = new Size(564, 186);
			gbBebidas.TabIndex = 33;
			gbBebidas.TabStop = false;
			gbBebidas.Text = "Bebidas";
			// 
			// btnAgregarBebida
			// 
			btnAgregarBebida.Location = new Point(443, 147);
			btnAgregarBebida.Name = "btnAgregarBebida";
			btnAgregarBebida.Size = new Size(94, 29);
			btnAgregarBebida.TabIndex = 27;
			btnAgregarBebida.Text = "Agregar";
			btnAgregarBebida.UseVisualStyleBackColor = true;
			btnAgregarBebida.Click += btnAgregarBebida_Click;
			// 
			// cmbBebida
			// 
			cmbBebida.FormattingEnabled = true;
			cmbBebida.Location = new Point(129, 98);
			cmbBebida.Name = "cmbBebida";
			cmbBebida.Size = new Size(408, 26);
			cmbBebida.TabIndex = 26;
			cmbBebida.Text = "Bebida";
			// 
			// cmbTipoBebida
			// 
			cmbTipoBebida.FormattingEnabled = true;
			cmbTipoBebida.Items.AddRange(new object[] { "Agua", "Gaseosa", "Cerveza" });
			cmbTipoBebida.Location = new Point(129, 66);
			cmbTipoBebida.Name = "cmbTipoBebida";
			cmbTipoBebida.Size = new Size(408, 26);
			cmbTipoBebida.TabIndex = 25;
			cmbTipoBebida.Text = "Tipo Bebida";
			// 
			// ckbBebida
			// 
			ckbBebida.AutoSize = true;
			ckbBebida.Location = new Point(30, 24);
			ckbBebida.Name = "ckbBebida";
			ckbBebida.Size = new Size(166, 22);
			ckbBebida.TabIndex = 24;
			ckbBebida.Text = "Agrega una Bebida";
			ckbBebida.UseVisualStyleBackColor = true;
			ckbBebida.CheckedChanged += ckbBebida_CheckedChanged;
			// 
			// lblTipoBebida
			// 
			lblTipoBebida.AutoSize = true;
			lblTipoBebida.Location = new Point(25, 74);
			lblTipoBebida.Name = "lblTipoBebida";
			lblTipoBebida.Size = new Size(40, 18);
			lblTipoBebida.TabIndex = 19;
			lblTipoBebida.Text = "Tipo";
			// 
			// lblBebida
			// 
			lblBebida.AutoSize = true;
			lblBebida.Location = new Point(25, 104);
			lblBebida.Name = "lblBebida";
			lblBebida.Size = new Size(56, 18);
			lblBebida.TabIndex = 20;
			lblBebida.Text = "Bebida";
			// 
			// gbEstadisticas
			// 
			gbEstadisticas.Controls.Add(txtMayorValorTaco);
			gbEstadisticas.Controls.Add(lblTacoMasCaro);
			gbEstadisticas.Controls.Add(txtMenorValorTaco);
			gbEstadisticas.Controls.Add(lblTacoPromedio);
			gbEstadisticas.Controls.Add(txtPromedioValorTaco);
			gbEstadisticas.Controls.Add(lblTacoMasBarato);
			gbEstadisticas.Location = new Point(582, 447);
			gbEstadisticas.Name = "gbEstadisticas";
			gbEstadisticas.Size = new Size(273, 151);
			gbEstadisticas.TabIndex = 34;
			gbEstadisticas.TabStop = false;
			gbEstadisticas.Text = "Estadisticas";
			// 
			// gbConfirmarPedido
			// 
			gbConfirmarPedido.Controls.Add(txtNumeroPedido);
			gbConfirmarPedido.Controls.Add(btnCargaPedido);
			gbConfirmarPedido.Controls.Add(lblNumeroPedido);
			gbConfirmarPedido.Controls.Add(txtImporteTotalPedido);
			gbConfirmarPedido.Controls.Add(lblImporteTotaPedido);
			gbConfirmarPedido.Location = new Point(887, 467);
			gbConfirmarPedido.Name = "gbConfirmarPedido";
			gbConfirmarPedido.Size = new Size(250, 125);
			gbConfirmarPedido.TabIndex = 35;
			gbConfirmarPedido.TabStop = false;
			gbConfirmarPedido.Text = "Confirmacion";
			// 
			// contactoBindingSource
			// 
			contactoBindingSource.DataSource = typeof(Modelo.EntidadesUsuario.Contacto);
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
			((System.ComponentModel.ISupportInitialize)tacoBindingSource).EndInit();
			IngredienteTacoGroup.ResumeLayout(false);
			IngredienteTacoGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvIngredientesTacoDetalle).EndInit();
			((System.ComponentModel.ISupportInitialize)rellenoBindingSource).EndInit();
			ClienteGroup.ResumeLayout(false);
			ClienteGroup.PerformLayout();
			gbBebidas.ResumeLayout(false);
			gbBebidas.PerformLayout();
			gbEstadisticas.ResumeLayout(false);
			gbEstadisticas.PerformLayout();
			gbConfirmarPedido.ResumeLayout(false);
			gbConfirmarPedido.PerformLayout();
			((System.ComponentModel.ISupportInitialize)contactoBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion


		private Button btnAgregarIngrediente;
		private Label lblIngrediente;
		private Label lblTipoIngrediente;
		private Label lblTacoInfo;
		private ComboBox cmbTipoIngrediente;
		private ComboBox cmbIngrediente;
		private DataGridView dgvTacoDetails;
		private Label lblTacoMasCaro;
		private Label lblTacoPromedio;
		private Label lblTacoMasBarato;
		private Button btnCrearTaco;
		private Button btnCargaPedido;
		private Label lblNumeroPedido;
		private Label lblImporteTotaPedido;
		private TextBox txtNumeroPedido;
		private TextBox txtImporteTotalPedido;
		private TextBox txtMayorValorTaco;
		private TextBox txtPromedioValorTaco;
		private TextBox txtMenorValorTaco;
		private GroupBox IngredienteTacoGroup;
		private TextBox txtNroContactoCliente;
		private Label label4;
		private Label lblEmailCliente;
		private DateTimePicker dtPickerDeliveryRequest;
		private CheckBox ckbDelivery;
		private GroupBox ClienteGroup;
		private GroupBox gbBebidas;
		private CheckBox ckbBebida;
		private Label lblTipoBebida;
		private Label lblBebida;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private GroupBox gbEstadisticas;
		private GroupBox gbConfirmarPedido;
		private ComboBox cmbBebida;
		private ComboBox cmbTipoBebida;
		private DataGridView dgvIngredientesTacoDetalle;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private BindingSource tacoBindingSource;
		private BindingSource rellenoBindingSource;
		private Button btnAgregarContactoDelivery;
		private Button btnAgregarBebida;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn cantidadMaximaDataGridViewTextBoxColumn;
		private ComboBox cmbNombreCliente;
		private BindingSource contactoBindingSource;
	}
}