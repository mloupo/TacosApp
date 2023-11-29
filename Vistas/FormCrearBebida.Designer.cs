using Modelo.EntidadesProducto.Bebidas;
using Modelo.EntidadesProducto.Tacos;
using System.Windows.Forms;

namespace Vistas
{
	partial class FormCrearBebida
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
			lblTipoBebida = new Label();
			cmbTipoBebida = new ComboBox();
			lblNombreBebida = new Label();
			txtNombreBebida = new TextBox();
			lblPrecioBebida = new Label();
			txtPrecioBebida = new TextBox();
			aguaBindingSource = new BindingSource(components);
			btnCancelarCreacion = new Button();
			btnCrearBebida = new Button();
			dgvBebidaDetalles = new DataGridView();
			idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			nombreDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			precioDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			Edit = new DataGridViewLinkColumn();
			Delete = new DataGridViewLinkColumn();
			gaseosaBindingSource = new BindingSource(components);
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)aguaBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvBebidaDetalles).BeginInit();
			((System.ComponentModel.ISupportInitialize)gaseosaBindingSource).BeginInit();
			SuspendLayout();
			// 
			// lblTipoBebida
			// 
			lblTipoBebida.AutoSize = true;
			lblTipoBebida.Location = new Point(12, 47);
			lblTipoBebida.Name = "lblTipoBebida";
			lblTipoBebida.Size = new Size(40, 18);
			lblTipoBebida.TabIndex = 5;
			lblTipoBebida.Text = "Tipo";
			// 
			// cmbTipoBebida
			// 
			cmbTipoBebida.FormattingEnabled = true;
			cmbTipoBebida.Location = new Point(90, 44);
			cmbTipoBebida.Name = "cmbTipoBebida";
			cmbTipoBebida.Size = new Size(265, 26);
			cmbTipoBebida.TabIndex = 4;
			cmbTipoBebida.SelectedIndexChanged += cmbTipoBebida_SelectedIndexChanged;
			// 
			// lblNombreBebida
			// 
			lblNombreBebida.AutoSize = true;
			lblNombreBebida.Location = new Point(12, 78);
			lblNombreBebida.Name = "lblNombreBebida";
			lblNombreBebida.Size = new Size(56, 18);
			lblNombreBebida.TabIndex = 0;
			lblNombreBebida.Text = "Nombre";
			// 
			// txtNombreBebida
			// 
			txtNombreBebida.Location = new Point(90, 76);
			txtNombreBebida.Name = "txtNombreBebida";
			txtNombreBebida.Size = new Size(265, 25);
			txtNombreBebida.TabIndex = 2;
			// 
			// lblPrecioBebida
			// 
			lblPrecioBebida.AutoSize = true;
			lblPrecioBebida.Location = new Point(12, 109);
			lblPrecioBebida.Name = "lblPrecioBebida";
			lblPrecioBebida.Size = new Size(56, 18);
			lblPrecioBebida.TabIndex = 1;
			lblPrecioBebida.Text = "Precio";
			// 
			// txtPrecioBebida
			// 
			txtPrecioBebida.Location = new Point(90, 107);
			txtPrecioBebida.Name = "txtPrecioBebida";
			txtPrecioBebida.Size = new Size(265, 25);
			txtPrecioBebida.TabIndex = 3;
			// 
			// btnCancelarCreacion
			// 
			btnCancelarCreacion.Location = new Point(390, 105);
			btnCancelarCreacion.Name = "btnCancelarCreacion";
			btnCancelarCreacion.Size = new Size(94, 26);
			btnCancelarCreacion.TabIndex = 6;
			btnCancelarCreacion.Text = "Cancelar";
			btnCancelarCreacion.UseVisualStyleBackColor = true;
			btnCancelarCreacion.Click += btnCancelarCreacion_Click_1;
			// 
			// btnCrearBebida
			// 
			btnCrearBebida.Location = new Point(390, 70);
			btnCrearBebida.Name = "btnCrearBebida";
			btnCrearBebida.Size = new Size(94, 26);
			btnCrearBebida.TabIndex = 7;
			btnCrearBebida.Text = "Crear";
			btnCrearBebida.UseVisualStyleBackColor = true;
			btnCrearBebida.Click += btnCrearBebida_Click;
			// 
			// dgvBebidaDetalles
			// 
			dgvBebidaDetalles.AllowUserToOrderColumns = true;
			dgvBebidaDetalles.AutoGenerateColumns = false;
			dgvBebidaDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBebidaDetalles.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, nombreDataGridViewTextBoxColumn2, precioDataGridViewTextBoxColumn2, Edit, Delete });
			dgvBebidaDetalles.DataSource = gaseosaBindingSource;
			dgvBebidaDetalles.Location = new Point(12, 203);
			dgvBebidaDetalles.Margin = new Padding(2);
			dgvBebidaDetalles.Name = "dgvBebidaDetalles";
			dgvBebidaDetalles.RowHeadersWidth = 51;
			dgvBebidaDetalles.RowTemplate.Height = 29;
			dgvBebidaDetalles.Size = new Size(472, 333);
			dgvBebidaDetalles.TabIndex = 13;
			dgvBebidaDetalles.CellContentClick += dgvBebidaDetalles_CellContentClick;
			// 
			// idDataGridViewTextBoxColumn2
			// 
			idDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn2.HeaderText = "Id";
			idDataGridViewTextBoxColumn2.MinimumWidth = 6;
			idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
			idDataGridViewTextBoxColumn2.Width = 53;
			// 
			// nombreDataGridViewTextBoxColumn2
			// 
			nombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
			nombreDataGridViewTextBoxColumn2.HeaderText = "Nombre";
			nombreDataGridViewTextBoxColumn2.MinimumWidth = 6;
			nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
			nombreDataGridViewTextBoxColumn2.Width = 125;
			// 
			// precioDataGridViewTextBoxColumn2
			// 
			precioDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			precioDataGridViewTextBoxColumn2.DataPropertyName = "Precio";
			precioDataGridViewTextBoxColumn2.HeaderText = "Precio";
			precioDataGridViewTextBoxColumn2.MinimumWidth = 6;
			precioDataGridViewTextBoxColumn2.Name = "precioDataGridViewTextBoxColumn2";
			precioDataGridViewTextBoxColumn2.Width = 85;
			// 
			// Edit
			// 
			Edit.HeaderText = "Editar";
			Edit.MinimumWidth = 6;
			Edit.Name = "Edit";
			Edit.ReadOnly = true;
			Edit.Text = "Edit";
			Edit.UseColumnTextForLinkValue = true;
			Edit.Width = 60;
			// 
			// Delete
			// 
			Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			Delete.HeaderText = "Eliminar";
			Delete.MinimumWidth = 6;
			Delete.Name = "Delete";
			Delete.ReadOnly = true;
			Delete.Text = "Delete";
			Delete.UseColumnTextForLinkValue = true;
			Delete.Width = 78;
			// 
			// gaseosaBindingSource
			// 
			gaseosaBindingSource.DataSource = typeof(Gaseosa);
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.MinimumWidth = 6;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.Width = 125;
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
			nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			nombreDataGridViewTextBoxColumn.Width = 125;
			// 
			// precioDataGridViewTextBoxColumn
			// 
			precioDataGridViewTextBoxColumn.MinimumWidth = 6;
			precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
			precioDataGridViewTextBoxColumn.Width = 125;
			// 
			// FormCrearBebida
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(491, 538);
			Controls.Add(dgvBebidaDetalles);
			Controls.Add(btnCrearBebida);
			Controls.Add(btnCancelarCreacion);
			Controls.Add(lblTipoBebida);
			Controls.Add(cmbTipoBebida);
			Controls.Add(txtPrecioBebida);
			Controls.Add(txtNombreBebida);
			Controls.Add(lblPrecioBebida);
			Controls.Add(lblNombreBebida);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(3, 2, 3, 2);
			Name = "FormCrearBebida";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Crear Ingrediente";
			Load += FormCrearBebida_Load;
			((System.ComponentModel.ISupportInitialize)aguaBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvBebidaDetalles).EndInit();
			((System.ComponentModel.ISupportInitialize)gaseosaBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ComboBox cmbTipoBebida;
		private Label lblTipoBebida;
		private TextBox txtNombreBebida;
		private TextBox txtPrecioBebida;
		private Label lblNombreBebida;
		private Label lblPrecioBebida;
		private Button btnCrearBebida;
		private Button btnCancelarCreacion;
		private DataGridViewTextBoxColumn preciounitarioDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private BindingSource aguaBindingSource;
		private DataGridView dgvBebidaDetalles;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
		private BindingSource rellenoBindingSource;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
		private BindingSource gaseosaBindingSource;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn2;
		private DataGridViewLinkColumn Edit;
		private DataGridViewLinkColumn Delete;
	}
}