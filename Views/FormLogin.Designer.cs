namespace Views
{
	partial class FormLogin
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			btnIngresar = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(107, 30);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(178, 27);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(107, 70);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(178, 27);
			textBox2.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(27, 33);
			label1.Name = "label1";
			label1.Size = new Size(38, 20);
			label1.TabIndex = 2;
			label1.Text = "User";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(27, 73);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 3;
			label2.Text = "Password";
			// 
			// btnIngresar
			// 
			btnIngresar.Location = new Point(191, 122);
			btnIngresar.Name = "btnIngresar";
			btnIngresar.Size = new Size(94, 29);
			btnIngresar.TabIndex = 4;
			btnIngresar.Text = "Ingresar";
			btnIngresar.UseVisualStyleBackColor = true;
			btnIngresar.Click += BtnIngresar_Click;
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(337, 176);
			Controls.Add(btnIngresar);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "FormLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormLogin";
			Load += FormLogin_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Label label1;
		private Label label2;
		private Button btnIngresar;
	}
}