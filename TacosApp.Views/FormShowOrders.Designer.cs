namespace Views
{
	partial class FormShowOrders
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
			textBox1 = new TextBox();
			btnSearchOrderByClientName = new Button();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Location = new Point(12, 145);
			panel1.Name = "panel1";
			panel1.Size = new Size(739, 293);
			panel1.TabIndex = 0;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(38, 50);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(524, 27);
			textBox1.TabIndex = 1;
			// 
			// btnSearchOrderByClientName
			// 
			btnSearchOrderByClientName.ForeColor = SystemColors.ActiveCaptionText;
			btnSearchOrderByClientName.Location = new Point(606, 48);
			btnSearchOrderByClientName.Name = "btnSearchOrderByClientName";
			btnSearchOrderByClientName.Size = new Size(94, 29);
			btnSearchOrderByClientName.TabIndex = 2;
			btnSearchOrderByClientName.Text = "Search";
			btnSearchOrderByClientName.UseVisualStyleBackColor = true;
			btnSearchOrderByClientName.Click += btnSearchOrderByClientName_Click;
			// 
			// FormShowOrders
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(763, 450);
			Controls.Add(btnSearchOrderByClientName);
			Controls.Add(textBox1);
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
		private TextBox textBox1;
		private Button btnSearchOrderByClientName;
	}
}