using Model.EntidadesUsuario;
using Service.Logica;

namespace Contactos
{
    public partial class ContactosForm : Form
	{
		private CapaLogicaNegocio _capalogicaNegocio;
		public ContactosForm()
		{
			InitializeComponent();
			_capalogicaNegocio = new();
		}

		#region eventos

		private void btnAgregarContacto_Click(object sender, EventArgs e)
		{
			AbrirDetallesContactoDialogo();
		}

		private void FormContactos_Load(object sender, EventArgs e)
		{
			poblarDataGridView();
		}

		private void gridContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContactos.Rows[e.RowIndex].Cells[e.ColumnIndex];
			if (cell.Value.ToString() == "Editar")
			{
				ContactosDetalle contactosDetalle = new ContactosDetalle();
				contactosDetalle.cargarContacto(new Contacto
				{
					Id = Convert.ToInt32(gridContactos.Rows[e.RowIndex].Cells[0].Value.ToString()),
					Nombre = gridContactos.Rows[e.RowIndex].Cells[1].Value.ToString(),
					Apellido = gridContactos.Rows[e.RowIndex].Cells[2].Value.ToString(),
					NroContacto = gridContactos.Rows[e.RowIndex].Cells[3].Value.ToString(),
					CorreoElectronico = gridContactos.Rows[e.RowIndex].Cells[4].Value.ToString(),
					DireccionEnvio = gridContactos.Rows[e.RowIndex].Cells[5].Value.ToString(),
					Contraseña = gridContactos.Rows[e.RowIndex].Cells[6].Value.ToString()
				});
				contactosDetalle.ShowDialog(this);
			}
			else if (cell.Value.ToString() == "Eliminar")
			{
				eliminarContacto(Convert.ToInt32(gridContactos.Rows[e.RowIndex].Cells[0].Value.ToString()));
				poblarDataGridView();
			}
		}

		private void btnBuscarContacto_Click(object sender, EventArgs e)
		{
			poblarDataGridView(txtBuscar.Text);
			txtBuscar.Text = String.Empty;
		}


		#endregion region eventos

		#region metodos privados

		private void AbrirDetallesContactoDialogo()
		{
			ContactosDetalle contactosDetalle = new ContactosDetalle();
			contactosDetalle.ShowDialog(this);
		}

		private void eliminarContacto(int Id)
		{
			_capalogicaNegocio.EliminarContacto(Id);
			poblarDataGridView();
		}


		#endregion

		#region metodos publicos

		public void poblarDataGridView(string textoObjetivo = null)
		{
			List<Contacto> contactos = _capalogicaNegocio.ObtenerContactos(textoObjetivo);
			gridContactos.DataSource = contactos;
		}

		#endregion

	}
}