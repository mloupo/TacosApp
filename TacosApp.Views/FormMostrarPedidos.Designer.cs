namespace Views
{
	partial class FormMostrarPedidos
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
			btnSearchOrderByClientEmail = new Button();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Location = new Point(12, 145);
			panel1.Name = "panel1";
			panel1.Size = new Size(739, 293);
			panel1.TabIndex = 0;
			// 
			// txtBuscarPedido
			// 
			txtBuscarPedido.Location = new Point(38, 50);
			txtBuscarPedido.Name = "txtBuscarPedido";
			txtBuscarPedido.Size = new Size(524, 27);
			txtBuscarPedido.TabIndex = 1;
			// 
			// btnSearchOrderByClientEmail
			// 
			btnSearchOrderByClientEmail.ForeColor = SystemColors.ActiveCaptionText;
			btnSearchOrderByClientEmail.Location = new Point(606, 48);
			btnSearchOrderByClientEmail.Name = "btnSearchOrderByClientEmail";
			btnSearchOrderByClientEmail.Size = new Size(94, 29);
			btnSearchOrderByClientEmail.TabIndex = 2;
			btnSearchOrderByClientEmail.Text = "Buscar";
			btnSearchOrderByClientEmail.UseVisualStyleBackColor = true;
			btnSearchOrderByClientEmail.Click += btnSearchOrderByClientName_Click;
			// 
			// FormShowOrders
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(763, 450);
			Controls.Add(btnSearchOrderByClientEmail);
			Controls.Add(txtBuscarPedido);
			Controls.Add(panel1);
			Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ForeColor = SystemColors.ControlLight;
			Name = "FormShowOrders";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Lista de Pedidos";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private TextBox txtBuscarPedido;
		private Button btnSearchOrderByClientEmail;
	}
}