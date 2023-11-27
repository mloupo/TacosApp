using Contactos;

namespace Vistas
{
	public partial class FormRaiz : Form
	{
		public FormRaiz()
		{
			InitializeComponent();
			BtnCrearPedido_Click(null, null);
		}

		#region EVENTS

		private void BtnGestionarElementos_Click(object sender, EventArgs e)
		{
			Helpers.AbrirFormularioHijo(AbrirFormularioGestorElementos(), RootPanel);
		}


		private void BtnCrearPedido_Click(object sender, EventArgs e)
		{
			Helpers.AbrirFormularioHijo(AbrirFormularioCrearPedido(), RootPanel);
		}

		private void BtnMostrarBebida_Click(object sender, EventArgs e)
		{
			Helpers.AbrirFormularioHijo(AbrirFormularioCrearBebidas(), RootPanel);
		}



		#endregion

		#region PRIVATE METHODS

		private Form AbrirFormularioCrearPedido()
		{
			FormCrearPedido frmPedido = new();
			return frmPedido;
		}

		private Form AbrirFormularioGestorElementos()
		{
			FormMostrarIngrediente frmIngrediente = new();
			return frmIngrediente;
		}

		private Form AbrirFormularioCrearBebidas()
		{
			FormMostrarBebidas frmOrder = new();
			return frmOrder;
		}

		#endregion



		#region Eventos Menu

		private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMostrarIngrediente ingredientes = new();
			ingredientes.ShowDialog();
		}

		private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ContactosForm contactos = new();
			contactos.ShowDialog();
		}

		#endregion
	}
}
