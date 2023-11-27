namespace Views
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
			panel1 = new Panel();
			txtBuscarPedido = new TextBox();
			btnBuscarBebidas = new Button();
			btnCrearBebida = new Button();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Location = new Point(11, 89);
			panel1.Name = "panel1";
			panel1.Size = new Size(657, 305);
			panel1.TabIndex = 0;
			// 
			// txtBuscarPedido
			// 
			txtBuscarPedido.Location = new Point(34, 45);
			txtBuscarPedido.Name = "txtBuscarPedido";
			txtBuscarPedido.Size = new Size(366, 25);
			txtBuscarPedido.TabIndex = 1;
			// 
			// btnBuscarBebidas
			// 
			btnBuscarBebidas.ForeColor = SystemColors.ActiveCaptionText;
			btnBuscarBebidas.Location = new Point(406, 44);
			btnBuscarBebidas.Name = "btnBuscarBebidas";
			btnBuscarBebidas.Size = new Size(84, 26);
			btnBuscarBebidas.TabIndex = 2;
			btnBuscarBebidas.Text = "Buscar";
			btnBuscarBebidas.UseVisualStyleBackColor = true;
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
			Controls.Add(btnBuscarBebidas);
			Controls.Add(txtBuscarPedido);
			Controls.Add(panel1);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			ForeColor = SystemColors.ControlLight;
			Name = "FormMostrarBebidas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Lista de Pedidos";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private TextBox txtBuscarPedido;
		private Button btnBuscarBebidas;
		private Button btnCrearBebida;
	}
}