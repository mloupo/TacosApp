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
			lblNombre.Location = new Point(33, 33);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(64, 20);
			lblNombre.TabIndex = 0;
			lblNombre.Text = "Nombre";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(166, 30);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(399, 27);
			txtNombre.TabIndex = 1;
			// 
			// txtApellido
			// 
			txtApellido.Location = new Point(166, 63);
			txtApellido.Name = "txtApellido";
			txtApellido.Size = new Size(399, 27);
			txtApellido.TabIndex = 2;
			// 
			// lblApellido
			// 
			lblApellido.AutoSize = true;
			lblApellido.Location = new Point(33, 66);
			lblApellido.Name = "lblApellido";
			lblApellido.Size = new Size(66, 20);
			lblApellido.TabIndex = 2;
			lblApellido.Text = "Apellido";
			// 
			// txtNroContacto
			// 
			txtNroContacto.Location = new Point(166, 96);
			txtNroContacto.Name = "txtNroContacto";
			txtNroContacto.Size = new Size(399, 27);
			txtNroContacto.TabIndex = 3;
			// 
			// lblNroContacto
			// 
			lblNroContacto.AutoSize = true;
			lblNroContacto.Location = new Point(33, 99);
			lblNroContacto.Name = "lblNroContacto";
			lblNroContacto.Size = new Size(98, 20);
			lblNroContacto.TabIndex = 4;
			lblNroContacto.Text = "Nro Contacto";
			// 
			// txtCorreoElectronico
			// 
			txtCorreoElectronico.Location = new Point(166, 129);
			txtCorreoElectronico.Name = "txtCorreoElectronico";
			txtCorreoElectronico.Size = new Size(399, 27);
			txtCorreoElectronico.TabIndex = 4;
			// 
			// lblCorreoElectronico
			// 
			lblCorreoElectronico.AutoSize = true;
			lblCorreoElectronico.Location = new Point(33, 132);
			lblCorreoElectronico.Name = "lblCorreoElectronico";
			lblCorreoElectronico.Size = new Size(72, 20);
			lblCorreoElectronico.TabIndex = 6;
			lblCorreoElectronico.Text = "Correo @";
			// 
			// btnSalvar
			// 
			btnSalvar.Location = new Point(297, 251);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(94, 29);
			btnSalvar.TabIndex = 7;
			btnSalvar.Text = "Salvar";
			btnSalvar.UseVisualStyleBackColor = true;
			btnSalvar.Click += btnSalvar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(425, 251);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(94, 29);
			btnCancelar.TabIndex = 8;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// txtDireccionEnvio
			// 
			txtDireccionEnvio.Location = new Point(166, 162);
			txtDireccionEnvio.Name = "txtDireccionEnvio";
			txtDireccionEnvio.Size = new Size(399, 27);
			txtDireccionEnvio.TabIndex = 5;
			// 
			// lblDireccionEnvio
			// 
			lblDireccionEnvio.AutoSize = true;
			lblDireccionEnvio.Location = new Point(33, 165);
			lblDireccionEnvio.Name = "lblDireccionEnvio";
			lblDireccionEnvio.Size = new Size(112, 20);
			lblDireccionEnvio.TabIndex = 10;
			lblDireccionEnvio.Text = "Direccion Envio";
			// 
			// txtContraseña
			// 
			txtContraseña.Location = new Point(166, 195);
			txtContraseña.Name = "txtContraseña";
			txtContraseña.Size = new Size(399, 27);
			txtContraseña.TabIndex = 6;
			// 
			// lblContraseña
			// 
			lblContraseña.AutoSize = true;
			lblContraseña.Location = new Point(33, 198);
			lblContraseña.Name = "lblContraseña";
			lblContraseña.Size = new Size(83, 20);
			lblContraseña.TabIndex = 12;
			lblContraseña.Text = "Contraseña";
			// 
			// ContactosDetalle
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(607, 302);
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