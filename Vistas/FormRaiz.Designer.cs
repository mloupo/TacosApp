namespace Vistas
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
			RootPanel = new Panel();
			menuStrip1 = new MenuStrip();
			administracionToolStripMenuItem = new ToolStripMenuItem();
			ingredientesToolStripMenuItem = new ToolStripMenuItem();
			bebidasToolStripMenuItem = new ToolStripMenuItem();
			contactosToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// RootPanel
			// 
			RootPanel.Dock = DockStyle.Fill;
			RootPanel.Location = new Point(0, 28);
			RootPanel.Margin = new Padding(2);
			RootPanel.Name = "RootPanel";
			RootPanel.Size = new Size(1160, 628);
			RootPanel.TabIndex = 11;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { administracionToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(4, 2, 0, 2);
			menuStrip1.Size = new Size(1160, 28);
			menuStrip1.TabIndex = 13;
			menuStrip1.Text = "menuStrip1";
			// 
			// administracionToolStripMenuItem
			// 
			administracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingredientesToolStripMenuItem, bebidasToolStripMenuItem, contactosToolStripMenuItem });
			administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
			administracionToolStripMenuItem.Size = new Size(123, 24);
			administracionToolStripMenuItem.Text = "Administracion";
			// 
			// ingredientesToolStripMenuItem
			// 
			ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
			ingredientesToolStripMenuItem.Size = new Size(174, 26);
			ingredientesToolStripMenuItem.Text = "Ingredientes";
			ingredientesToolStripMenuItem.Click += ingredientesToolStripMenuItem_Click;
			// 
			// bebidasToolStripMenuItem
			// 
			bebidasToolStripMenuItem.Name = "bebidasToolStripMenuItem";
			bebidasToolStripMenuItem.Size = new Size(174, 26);
			bebidasToolStripMenuItem.Text = "Bebidas";
			bebidasToolStripMenuItem.Click += bebidasToolStripMenuItem_Click;
			// 
			// contactosToolStripMenuItem
			// 
			contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
			contactosToolStripMenuItem.Size = new Size(174, 26);
			contactosToolStripMenuItem.Text = "Contactos";
			contactosToolStripMenuItem.Click += contactosToolStripMenuItem_Click;
			// 
			// FormRaiz
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1160, 656);
			Controls.Add(RootPanel);
			Controls.Add(menuStrip1);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Margin = new Padding(3, 2, 3, 2);
			Name = "FormRaiz";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Raiz";
			Load += FormRaiz_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel RootPanel;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem administracionToolStripMenuItem;
		private ToolStripMenuItem ingredientesToolStripMenuItem;
		private ToolStripMenuItem bebidasToolStripMenuItem;
		private ToolStripMenuItem contactosToolStripMenuItem;
	}
}