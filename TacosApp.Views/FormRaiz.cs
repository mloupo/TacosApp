namespace Views
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
			Helpers.AbrirFormularioHijo(AbrirFormularioGestorElementos(), RootPanel);
		}



		private void BtnCrearPedido_Click(object sender, EventArgs e)
		{
			Helpers.AbrirFormularioHijo(AbrirFormularioCrearPedido(), RootPanel);
		}

		private void BtnMostrarPedido_Click(object sender, EventArgs e)
		{
			Helpers.AbrirFormularioHijo(AbrirFormularioBuscarPedidos(), RootPanel);
		}



		#endregion

		#region PRIVATE METHODS

		private Form AbrirFormularioCrearPedido()
		{
			FormCrearPedido frmTaco = new();
			return frmTaco;
		}

		private Form AbrirFormularioGestorElementos()
		{
			FormMostrarIngrediente frmIngredient = new();
			return frmIngredient;
		}

		private Form AbrirFormularioBuscarPedidos()
		{
			FormMostrarPedidos frmOrder = new();
			return frmOrder;
		}

		#endregion





	}
}
