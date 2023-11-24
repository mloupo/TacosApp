namespace Views
{
	partial class FormRaiz
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
			BtnCrearPedido = new Button();
			BtnGestionarElementos = new Button();
			btnBuscarPedido = new Button();
			RootPanel = new Panel();
			SuspendLayout();
			// 
			// BtnCrearPedido
			// 
			BtnCrearPedido.Location = new Point(16, 101);
			BtnCrearPedido.Margin = new Padding(4, 3, 4, 3);
			BtnCrearPedido.Name = "BtnCrearPedido";
			BtnCrearPedido.Size = new Size(201, 33);
			BtnCrearPedido.TabIndex = 2;
			BtnCrearPedido.Text = "Crear Pedido";
			BtnCrearPedido.UseVisualStyleBackColor = true;
			BtnCrearPedido.Click += BtnCrearPedido_Click;
			// 
			// BtnGestionarElementos
			// 
			BtnGestionarElementos.Location = new Point(16, 61);
			BtnGestionarElementos.Margin = new Padding(4, 3, 4, 3);
			BtnGestionarElementos.Name = "BtnGestionarElementos";
			BtnGestionarElementos.Size = new Size(201, 33);
			BtnGestionarElementos.TabIndex = 1;
			BtnGestionarElementos.Text = "Administración";
			BtnGestionarElementos.UseVisualStyleBackColor = true;
			BtnGestionarElementos.Click += BtnGestionarElementos_Click;
			// 
			// btnBuscarPedido
			// 
			btnBuscarPedido.Location = new Point(16, 141);
			btnBuscarPedido.Margin = new Padding(4, 3, 4, 3);
			btnBuscarPedido.Name = "btnBuscarPedido";
			btnBuscarPedido.Size = new Size(201, 33);
			btnBuscarPedido.TabIndex = 3;
			btnBuscarPedido.Text = "Buscar Pedido";
			btnBuscarPedido.UseVisualStyleBackColor = true;
			btnBuscarPedido.Click += BtnMostrarPedido_Click;
			// 
			// RootPanel
			// 
			RootPanel.Location = new Point(244, 12);
			RootPanel.Name = "RootPanel";
			RootPanel.Size = new Size(911, 443);
			RootPanel.TabIndex = 11;
			// 
			// FormRaiz
			// 
			AutoScaleDimensions = new SizeF(11F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1167, 463);
			Controls.Add(RootPanel);
			Controls.Add(btnBuscarPedido);
			Controls.Add(BtnGestionarElementos);
			Controls.Add(BtnCrearPedido);
			Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			IsMdiContainer = true;
			Margin = new Padding(4, 3, 4, 3);
			Name = "FormRaiz";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Home";
			ResumeLayout(false);
		}

		#endregion
		private Button BtnCrearPedido;

		private Button btnBuscarPedido;
		private Button BtnGestionarElementos;
		private Panel RootPanel;
	}
}