namespace Views
{
	partial class FormRoot
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
			btnCreateTaco = new Button();
			btnManageIngredient = new Button();
			button4 = new Button();
			RootPanel = new Panel();
			SuspendLayout();
			// 
			// btnCreateTaco
			// 
			btnCreateTaco.Location = new Point(16, 101);
			btnCreateTaco.Margin = new Padding(4, 3, 4, 3);
			btnCreateTaco.Name = "btnCreateTaco";
			btnCreateTaco.Size = new Size(201, 33);
			btnCreateTaco.TabIndex = 7;
			btnCreateTaco.Text = "Crear Taco";
			btnCreateTaco.UseVisualStyleBackColor = true;
			btnCreateTaco.Click += BtnCreateTaco_Click;
			// 
			// btnManageIngredient
			// 
			btnManageIngredient.Location = new Point(16, 61);
			btnManageIngredient.Margin = new Padding(4, 3, 4, 3);
			btnManageIngredient.Name = "btnManageIngredient";
			btnManageIngredient.Size = new Size(278, 33);
			btnManageIngredient.TabIndex = 8;
			btnManageIngredient.Text = "Gestionar Ingredientes";
			btnManageIngredient.UseVisualStyleBackColor = true;
			btnManageIngredient.Click += BtnManageIngredient_Click;
			// 
			// button4
			// 
			button4.Location = new Point(16, 141);
			button4.Margin = new Padding(4, 3, 4, 3);
			button4.Name = "button4";
			button4.Size = new Size(201, 33);
			button4.TabIndex = 10;
			button4.Text = "Mostrar Pedido";
			button4.UseVisualStyleBackColor = true;
			// 
			// RootPanel
			// 
			RootPanel.Location = new Point(325, 12);
			RootPanel.Name = "RootPanel";
			RootPanel.Size = new Size(1326, 941);
			RootPanel.TabIndex = 11;
			// 
			// FormRoot
			// 
			AutoScaleDimensions = new SizeF(11F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1663, 965);
			Controls.Add(RootPanel);
			Controls.Add(button4);
			Controls.Add(btnManageIngredient);
			Controls.Add(btnCreateTaco);
			Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 3, 4, 3);
			Name = "FormRoot";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Home";
			ResumeLayout(false);
		}

		#endregion
		private Button btnCreateTaco;

		private Button button4;
		private Button btnManageIngredient;
		private Panel RootPanel;
	}
}