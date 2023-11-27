namespace Contactos
{
	partial class ContactosDetalle
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
			lblNombre = new Label();
			txtNombre = new TextBox();
			txtApellido = new TextBox();
			lblApellido = new Label();
			txtNroContacto = new TextBox();
			lblNroContacto = new Label();
			txtCorreoElectronico = new TextBox();
			lblCorreoElectronico = new Label();
			btnSalvar = new Button();
			btnCancelar = new Button();
			txtDireccionEnvio = new TextBox();
			lblDireccionEnvio = new Label();
			txtContraseña = new TextBox();
			lblContraseña = new Label();
			SuspendLayout();
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Location = new Point(33, 30);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(56, 18);
			lblNombre.TabIndex = 0;
			lblNombre.Text = "Nombre";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(166, 27);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(399, 25);
			txtNombre.TabIndex = 1;
			// 
			// txtApellido
			// 
			txtApellido.Location = new Point(166, 57);
			txtApellido.Name = "txtApellido";
			txtApellido.Size = new Size(399, 25);
			txtApellido.TabIndex = 2;
			// 
			// lblApellido
			// 
			lblApellido.AutoSize = true;
			lblApellido.Location = new Point(33, 59);
			lblApellido.Name = "lblApellido";
			lblApellido.Size = new Size(72, 18);
			lblApellido.TabIndex = 2;
			lblApellido.Text = "Apellido";
			// 
			// txtNroContacto
			// 
			txtNroContacto.Location = new Point(166, 86);
			txtNroContacto.Name = "txtNroContacto";
			txtNroContacto.Size = new Size(399, 25);
			txtNroContacto.TabIndex = 3;
			// 
			// lblNroContacto
			// 
			lblNroContacto.AutoSize = true;
			lblNroContacto.Location = new Point(33, 89);
			lblNroContacto.Name = "lblNroContacto";
			lblNroContacto.Size = new Size(104, 18);
			lblNroContacto.TabIndex = 4;
			lblNroContacto.Text = "Nro Contacto";
			// 
			// txtCorreoElectronico
			// 
			txtCorreoElectronico.Location = new Point(166, 116);
			txtCorreoElectronico.Name = "txtCorreoElectronico";
			txtCorreoElectronico.Size = new Size(399, 25);
			txtCorreoElectronico.TabIndex = 4;
			// 
			// lblCorreoElectronico
			// 
			lblCorreoElectronico.AutoSize = true;
			lblCorreoElectronico.Location = new Point(33, 119);
			lblCorreoElectronico.Name = "lblCorreoElectronico";
			lblCorreoElectronico.Size = new Size(72, 18);
			lblCorreoElectronico.TabIndex = 6;
			lblCorreoElectronico.Text = "Correo @";
			// 
			// btnSalvar
			// 
			btnSalvar.Location = new Point(297, 226);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(94, 26);
			btnSalvar.TabIndex = 7;
			btnSalvar.Text = "Salvar";
			btnSalvar.UseVisualStyleBackColor = true;
			btnSalvar.Click += btnSalvar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(425, 226);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(94, 26);
			btnCancelar.TabIndex = 8;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// txtDireccionEnvio
			// 
			txtDireccionEnvio.Location = new Point(166, 146);
			txtDireccionEnvio.Name = "txtDireccionEnvio";
			txtDireccionEnvio.Size = new Size(399, 25);
			txtDireccionEnvio.TabIndex = 5;
			// 
			// lblDireccionEnvio
			// 
			lblDireccionEnvio.AutoSize = true;
			lblDireccionEnvio.Location = new Point(33, 148);
			lblDireccionEnvio.Name = "lblDireccionEnvio";
			lblDireccionEnvio.Size = new Size(128, 18);
			lblDireccionEnvio.TabIndex = 10;
			lblDireccionEnvio.Text = "Direccion Envio";
			// 
			// txtContraseña
			// 
			txtContraseña.Location = new Point(166, 176);
			txtContraseña.Name = "txtContraseña";
			txtContraseña.Size = new Size(399, 25);
			txtContraseña.TabIndex = 6;
			// 
			// lblContraseña
			// 
			lblContraseña.AutoSize = true;
			lblContraseña.Location = new Point(33, 178);
			lblContraseña.Name = "lblContraseña";
			lblContraseña.Size = new Size(88, 18);
			lblContraseña.TabIndex = 12;
			lblContraseña.Text = "Contraseña";
			// 
			// ContactosDetalle
			// 
			AutoScaleDimensions = new SizeF(8F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(607, 272);
			Controls.Add(txtContraseña);
			Controls.Add(lblContraseña);
			Controls.Add(txtDireccionEnvio);
			Controls.Add(lblDireccionEnvio);
			Controls.Add(btnCancelar);
			Controls.Add(btnSalvar);
			Controls.Add(txtCorreoElectronico);
			Controls.Add(lblCorreoElectronico);
			Controls.Add(txtNroContacto);
			Controls.Add(lblNroContacto);
			Controls.Add(txtApellido);
			Controls.Add(lblApellido);
			Controls.Add(txtNombre);
			Controls.Add(lblNombre);
			Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "ContactosDetalle";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ContactosDetalle";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblNombre;
		private TextBox txtNombre;
		private TextBox txtApellido;
		private Label lblApellido;
		private TextBox txtNroContacto;
		private Label lblNroContacto;
		private TextBox txtCorreoElectronico;
		private Label lblCorreoElectronico;
		private Button btnSalvar;
		private Button btnCancelar;
		private TextBox txtDireccionEnvio;
		private Label lblDireccionEnvio;
		private TextBox txtContraseña;
		private Label lblContraseña;
	}
}