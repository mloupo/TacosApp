using Contactos;

namespace Vistas
{
	public partial class FormRaiz : Form
	{
		public FormRaiz()
		{
			InitializeComponent();

		}

		#region EVENTS

		private void BtnGestionarElementos_Click(object sender, EventArgs e)
		{
			AbrirFormularioGestorElementos();
		}




		private void BtnCrearBebida_Click(object sender, EventArgs e)
		{
			AbrirFormularioCrearBebidas();
		}



		#endregion

		#region PRIVATE METHODS

		private Form AbrirFormularioCrearPedido()
		{
			FormCrearPedido frmPedido = new();
			return frmPedido;
		}

		private void AbrirFormularioGestorElementos()
		{
			FormMostrarIngrediente frmIngrediente = new();
			frmIngrediente.ShowDialog();
		}

		private void AbrirFormularioCrearBebidas()
		{
			FormMostrarBebidas frmBebida = new();
			frmBebida.ShowDialog(); ;
		}

		private void AbrirFormularioCrearContacto()
		{
			ContactosDetalle frmContacto = new();
			frmContacto.ShowDialog();
		}

		#endregion



		#region Eventos Menu

		private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirFormularioGestorElementos();
		}

		private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirFormularioCrearBebidas();
		}

		private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirFormularioCrearContacto();
		}

		#endregion
	}
}
