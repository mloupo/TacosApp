
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
			txtBuscarBebida = new TextBox();
			btnBuscarBebida = new Button();
			btnCrearBebida = new Button();
			SuspendLayout();
			// 
			// txtBuscarPedido
			// 
			txtBuscarBebida.Location = new Point(34, 45);
			txtBuscarBebida.Name = "txtBuscarPedido";
			txtBuscarBebida.Size = new Size(366, 25);
			txtBuscarBebida.TabIndex = 1;
			// 
			// btnBuscarBebidas
			// 
			btnBuscarBebida.ForeColor = SystemColors.ActiveCaptionText;
			btnBuscarBebida.Location = new Point(406, 44);
			btnBuscarBebida.Name = "btnBuscarBebidas";
			btnBuscarBebida.Size = new Size(84, 26);
			btnBuscarBebida.TabIndex = 2;
			btnBuscarBebida.Text = "Buscar";
			btnBuscarBebida.UseVisualStyleBackColor = true;
			// 
			// btnCrearBebida
			// 
			btnCrearBebida.ForeColor = SystemColors.ActiveCaptionText;
			btnCrearBebida.Location = new Point(496, 44);
			btnCrearBebida.Name = "btnCrearBebida";
			btnCrearBebida.Size = new Size(84, 26);
			btnCrearBebida.TabIndex = 3;
			btnCrearBebida.Text = "Agregar";
			btnCrearBebida.UseVisualStyleBackColor = true;
			btnCrearBebida.Click += btnCrearBebida_Click;
			// 
			// FormMostrarBebidas
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 405);
			Controls.Add(btnCrearBebida);
			Controls.Add(btnBuscarBebida);
			Controls.Add(txtBuscarBebida);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			ForeColor = SystemColors.ControlLight;
			Name = "FormMostrarBebidas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Lista de Bebidas";
			ResumeLayout(false);
			PerformLayout();
		}


		#endregion

		private DataGridView dgvFormBebida;
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
	}
}