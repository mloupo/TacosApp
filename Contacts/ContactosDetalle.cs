using Model.EntidadesUsuario;
using Service;

namespace Contactos
{
	public partial class ContactosDetalle : Form
	{
		private CapaLogicaNegocio _capalogicaNegocio;
		private Contacto _contacto;
		public ContactosDetalle()
		{
			InitializeComponent();
			_capalogicaNegocio = new();
		}

		#region eventos

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			SalvarContacto();
			this.Close();
			((Contactos)this.Owner).poblarDataGridView();
		}



		#endregion


		#region metodos privados
		private void SalvarContacto()
		{

			Contacto contacto = new()
			{
				Nombre = txtNombre.Text,
				Apellido = txtApellido.Text,
				NroContacto = txtNroContacto.Text,
				CorreoElectronico = txtCorreoElectronico.Text,
				DireccionEnvio = txtDireccionEnvio.Text,
				Contraseña = txtContraseña.Text
			};
			contacto.Id = _contacto != null ? _contacto.Id : 0;

			_capalogicaNegocio.AgregarContacto(contacto);
		}

		public void cargarContacto(Contacto contacto)
		{
			_contacto = contacto;
			if (contacto != null)
			{
				limpiarCampos();
				txtNombre.Text = contacto.Nombre;
				txtApellido.Text = contacto.Apellido;
				txtNroContacto.Text = contacto.NroContacto;
				txtCorreoElectronico.Text = contacto.CorreoElectronico;
				txtDireccionEnvio.Text = contacto.DireccionEnvio;
				txtContraseña.Text = contacto.Contraseña;
			}
		}

		private void limpiarCampos()
		{
			txtNombre.Text = String.Empty;
			txtApellido.Text = String.Empty;
			txtNroContacto.Text = String.Empty;
			txtCorreoElectronico.Text = String.Empty;
			txtContraseña.Text = String.Empty;
		}

		#endregion

		#region metodos publicos



		#endregion
	}
}
