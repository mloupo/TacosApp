using Contactos;

namespace Vistas
{
	public partial class FormRaiz : Form
	{
		public FormRaiz()
		{
			InitializeComponent();
			Helpers.AbrirFormularioHijo(AbrirFormularioCrearPedido(), RootPanel);
		}

		#region EVENTS
		private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirFormularioMostrarIngrediente();
		}

		private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirFormularioMostrarBebidas();
		}

		private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirFormularioMostrarContacto();
		}
		#endregion

		#region PRIVATE METHODS

		private Form AbrirFormularioCrearPedido()
		{
			FormCrearPedido frmPedido = new();
			return frmPedido;
		}

		private void AbrirFormularioMostrarIngrediente()
		{
			FormMostrarIngrediente frmIngrediente = new();
			frmIngrediente.ShowDialog();
		}

		private void AbrirFormularioMostrarBebidas()
		{
			FormMostrarBebidas frmBebida = new();
			frmBebida.ShowDialog(); ;
		}

		private void AbrirFormularioMostrarContacto()
		{
			ContactosForm frmContacto = new();
			frmContacto.ShowDialog();
		}

		#endregion
	}
}
