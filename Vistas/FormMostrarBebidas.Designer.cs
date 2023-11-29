
namespace Vistas
{
	partial class FormMostrarBebidas
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			txtBuscarBebida = new TextBox();
			btnBuscarBebida = new Button();
			btnCrearBebida = new Button();
			dgvFormBebida = new DataGridView();
			gaseosaBindingSource = new BindingSource(components);
			dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvFormBebida).BeginInit();
			((System.ComponentModel.ISupportInitialize)gaseosaBindingSource).BeginInit();
			SuspendLayout();
			// 
			// txtBuscarBebida
			// 
			txtBuscarBebida.Location = new Point(34, 45);
			txtBuscarBebida.Name = "txtBuscarBebida";
			txtBuscarBebida.Size = new Size(265, 25);
			txtBuscarBebida.TabIndex = 1;
			// 
			// btnBuscarBebida
			// 
			btnBuscarBebida.ForeColor = SystemColors.ActiveCaptionText;
			btnBuscarBebida.Location = new Point(316, 44);
			btnBuscarBebida.Name = "btnBuscarBebida";
			btnBuscarBebida.Size = new Size(84, 26);
			btnBuscarBebida.TabIndex = 2;
			btnBuscarBebida.Text = "Buscar";
			btnBuscarBebida.UseVisualStyleBackColor = true;
			// 
			// btnCrearBebida
			// 
			btnCrearBebida.ForeColor = SystemColors.ActiveCaptionText;
			btnCrearBebida.Location = new Point(406, 44);
			btnCrearBebida.Name = "btnCrearBebida";
			btnCrearBebida.Size = new Size(84, 26);
			btnCrearBebida.TabIndex = 3;
			btnCrearBebida.Text = "Agregar";
			btnCrearBebida.UseVisualStyleBackColor = true;
			btnCrearBebida.Click += btnCrearBebida_Click;
			// 
			// dgvFormBebida
			// 
			dgvFormBebida.AllowUserToOrderColumns = true;
			dgvFormBebida.AutoGenerateColumns = false;
			dgvFormBebida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFormBebida.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
			dgvFormBebida.DataSource = gaseosaBindingSource;
			dgvFormBebida.Location = new Point(12, 86);
			dgvFormBebida.Name = "dgvFormBebida";
			dgvFormBebida.RowHeadersWidth = 51;
			dgvFormBebida.RowTemplate.Height = 29;
			dgvFormBebida.Size = new Size(478, 307);
			dgvFormBebida.TabIndex = 4;
			// 
			// gaseosaBindingSource
			// 
			gaseosaBindingSource.DataSource = typeof(Modelo.EntidadesProducto.Bebidas.Gaseosa);
			// 
			// dataGridViewTextBoxColumn4
			// 
			dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridViewTextBoxColumn4.DataPropertyName = "Id";
			dataGridViewCellStyle1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.Black;
			dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewTextBoxColumn4.HeaderText = "Id";
			dataGridViewTextBoxColumn4.MinimumWidth = 6;
			dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			dataGridViewTextBoxColumn4.Width = 53;
			// 
			// dataGridViewTextBoxColumn5
			// 
			dataGridViewTextBoxColumn5.DataPropertyName = "Nombre";
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewTextBoxColumn5.HeaderText = "Nombre";
			dataGridViewTextBoxColumn5.MinimumWidth = 6;
			dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			dataGridViewTextBoxColumn5.Width = 125;
			// 
			// dataGridViewTextBoxColumn6
			// 
			dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridViewTextBoxColumn6.DataPropertyName = "Precio";
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewTextBoxColumn6.HeaderText = "Precio";
			dataGridViewTextBoxColumn6.MinimumWidth = 6;
			dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			dataGridViewTextBoxColumn6.Width = 85;
			// 
			// FormMostrarBebidas
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(500, 405);
			Controls.Add(dgvFormBebida);
			Controls.Add(btnCrearBebida);
			Controls.Add(btnBuscarBebida);
			Controls.Add(txtBuscarBebida);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			ForeColor = SystemColors.ControlLight;
			Name = "FormMostrarBebidas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Lista de Bebidas";
			Load += FormMostrarBebidas_Load_1;
			((System.ComponentModel.ISupportInitialize)dgvFormBebida).EndInit();
			((System.ComponentModel.ISupportInitialize)gaseosaBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}


		#endregion


		private TextBox txtBuscarBebida;
		private Button btnBuscarBebida;
		private Button btnCrearBebida;

		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
		private BindingSource aguaBindingSource;
		private Button btnAddIngredient;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn CantidadMaxima;
		private DataGridView dgvFormBebida;
		private BindingSource gaseosaBindingSource;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}