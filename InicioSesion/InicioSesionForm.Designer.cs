namespace InicioSesion
{
	partial class InicioSesionForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesionForm));
			this.ServerTB = new System.Windows.Forms.TextBox();
			this.UserTB = new System.Windows.Forms.TextBox();
			this.PasswordTB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ConnectBT = new System.Windows.Forms.Button();
			this.ErrorLB = new System.Windows.Forms.Label();
			this.RememberCB = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblKaizen = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ServerTB
			// 
			this.ServerTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ServerTB.Location = new System.Drawing.Point(11, 29);
			this.ServerTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ServerTB.Name = "ServerTB";
			this.ServerTB.Size = new System.Drawing.Size(461, 22);
			this.ServerTB.TabIndex = 0;
			// 
			// UserTB
			// 
			this.UserTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.UserTB.Location = new System.Drawing.Point(11, 74);
			this.UserTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.UserTB.Name = "UserTB";
			this.UserTB.Size = new System.Drawing.Size(461, 22);
			this.UserTB.TabIndex = 1;
			// 
			// PasswordTB
			// 
			this.PasswordTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.PasswordTB.Location = new System.Drawing.Point(11, 118);
			this.PasswordTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PasswordTB.Name = "PasswordTB";
			this.PasswordTB.Size = new System.Drawing.Size(461, 22);
			this.PasswordTB.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Server";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "User";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password";
			// 
			// ConnectBT
			// 
			this.ConnectBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ConnectBT.Location = new System.Drawing.Point(11, 270);
			this.ConnectBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ConnectBT.Name = "ConnectBT";
			this.ConnectBT.Size = new System.Drawing.Size(460, 26);
			this.ConnectBT.TabIndex = 6;
			this.ConnectBT.Text = "Connect";
			this.ConnectBT.UseVisualStyleBackColor = true;
			this.ConnectBT.Click += new System.EventHandler(this.ConnectBT_Click);
			// 
			// ErrorLB
			// 
			this.ErrorLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ErrorLB.AutoSize = true;
			this.ErrorLB.ForeColor = System.Drawing.Color.Coral;
			this.ErrorLB.Location = new System.Drawing.Point(12, 166);
			this.ErrorLB.Name = "ErrorLB";
			this.ErrorLB.Size = new System.Drawing.Size(0, 16);
			this.ErrorLB.TabIndex = 7;
			// 
			// RememberCB
			// 
			this.RememberCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RememberCB.AutoSize = true;
			this.RememberCB.Location = new System.Drawing.Point(18, 144);
			this.RememberCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RememberCB.Name = "RememberCB";
			this.RememberCB.Size = new System.Drawing.Size(166, 20);
			this.RememberCB.TabIndex = 8;
			this.RememberCB.Text = "Remember credentials";
			this.RememberCB.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::NachoDTOMaker.Properties.Resources._361_3611823_image_nacho_png_object_shows_community_fandom_triangle;
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(308, 145);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(163, 121);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// lblKaizen
			// 
			this.lblKaizen.AutoSize = true;
			this.lblKaizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKaizen.Location = new System.Drawing.Point(11, 236);
			this.lblKaizen.Name = "lblKaizen";
			this.lblKaizen.Size = new System.Drawing.Size(272, 31);
			this.lblKaizen.TabIndex = 10;
			this.lblKaizen.Text = "KaiZenCreadorDTO";
			// 
			// LoginFRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 310);
			this.Controls.Add(this.lblKaizen);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.RememberCB);
			this.Controls.Add(this.ErrorLB);
			this.Controls.Add(this.ConnectBT);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PasswordTB);
			this.Controls.Add(this.UserTB);
			this.Controls.Add(this.ServerTB);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LoginFRM";
			this.Text = "login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFRM_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ServerTB;
		private System.Windows.Forms.TextBox UserTB;
		private System.Windows.Forms.TextBox PasswordTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ConnectBT;
		private System.Windows.Forms.Label ErrorLB;
		private System.Windows.Forms.CheckBox RememberCB;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblKaizen;
	}
}

