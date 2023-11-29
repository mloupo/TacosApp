using Modelo.EntidadesProducto.Tacos;
using Servicio.Logica;

namespace Vistas
{
	public partial class FormMostrarIngrediente : Form
	{
		private readonly List<Ingrediente> _allIngredientes;
		private readonly List<Ingrediente> _tortillas;
		private readonly List<Ingrediente> _rellenos;
		private readonly List<Ingrediente> _salsas;
		private readonly CapaLogicaNegocio _businessLogicLayer;

		public FormMostrarIngrediente()
		{
			InitializeComponent();
			_businessLogicLayer = new CapaLogicaNegocio();
			_allIngredientes = new List<Ingrediente>();
			_tortillas = new List<Ingrediente>();
			_rellenos = new List<Ingrediente>();
			_salsas = new List<Ingrediente>();
		}

		private void FormIngredient_Activated(object sender, EventArgs e)
		{
			ActualizarGrillaSearch();
		}

		private void ActualizarGrillaSearch()
		{
			dgvFormIngredient.DataSource = UnirListas();
		}

		private List<Ingrediente> UnirListas()
		{
			_tortillas.AddRange(_businessLogicLayer.ObtenerIngredientes("Tortilla"));
			_rellenos.AddRange(_businessLogicLayer.ObtenerIngredientes("Relleno"));
			_salsas.AddRange(_businessLogicLayer.ObtenerIngredientes("Salsa"));

			_allIngredientes.AddRange(_tortillas);
			_allIngredientes.AddRange(_rellenos);
			_allIngredientes.AddRange(_salsas);

			return _allIngredientes;
		}

		private void OpenIngredientDetails()
		{
			FormCrearIngrediente formIngredientDetails = new();
			formIngredientDetails.ShowDialog();
		}

		private void FormIngredient_Load(object sender, EventArgs e)
		{
			ActualizarGrillaSearch();
		}

		private void BtnAddIngredient_Click(object sender, EventArgs e)
		{
			OpenIngredientDetails();
			ActualizarGrillaSearch();
		}

		private void btnSearchIngredient_Click(object sender, EventArgs e)
		{
			var filteredIngredients = _allIngredientes
				.Where(i => i.Nombre.ToLower().Contains(txtSearchIngredient.Text.ToLower()))
				.ToList();

			dgvFormIngredient.DataSource = filteredIngredients;
		}
	}
}
