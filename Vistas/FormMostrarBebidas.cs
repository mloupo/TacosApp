using Modelo.EntidadesProducto.Bebidas;
using Servicio.Logica;

namespace Vistas
{
	public partial class FormMostrarBebidas : Form
	{
		private readonly List<Bebida> _allBebidas;
		private readonly List<Bebida> _aguas;
		private readonly List<Bebida> _cervezas;
		private readonly List<Bebida> _gaseosas;
		private readonly CapaLogicaNegocio _businessLogicLayer;

		public FormMostrarBebidas()
		{
			InitializeComponent();
			_businessLogicLayer = new CapaLogicaNegocio();
			_allBebidas = new List<Bebida>();
			_aguas = new List<Bebida>();
			_cervezas = new List<Bebida>();
			_gaseosas = new List<Bebida>();
		}

		private void FormMostrarBebida_Activated(object sender, EventArgs e)
		{
			ActualizarGrillaSearch();
		}

		private void ActualizarGrillaSearch()
		{
			dgvFormBebida.DataSource = UnirListas();
		}

		private List<Bebida> UnirListas()
		{
			_aguas.AddRange(_businessLogicLayer.ObtenerBebidas("Agua"));
			_cervezas.AddRange(_businessLogicLayer.ObtenerBebidas("Cerveza"));
			_gaseosas.AddRange(_businessLogicLayer.ObtenerBebidas("Gaseosa"));

			_allBebidas.AddRange(_aguas);
			_allBebidas.AddRange(_cervezas);
			_allBebidas.AddRange(_gaseosas);

			return _allBebidas;
		}

		private void AbrirCrearBebidaForm()
		{
			FormCrearBebida formBebidaDetalles = new();
			formBebidaDetalles.ShowDialog();
		}

		private void FormMostrarBebidas_Load(object sender, EventArgs e)
		{
			ActualizarGrillaSearch();
		}

		private void btnCrearBebida_Click(object sender, EventArgs e)
		{
			AbrirCrearBebidaForm();
			ActualizarGrillaSearch();
		}

		private void btnBuscarBebida_Click(object sender, EventArgs e)
		{

			var filteredBebidas = _allBebidas
				.Where(b => b.Nombre.ToLower().Contains(txtBuscarBebida.Text.ToLower()))
				.ToList();

			dgvFormBebida.DataSource = filteredBebidas;
		}
	}
}
