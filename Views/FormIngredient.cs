using Model;
using Model.Productos;

namespace Views
{
	public partial class FormIngredient : Form
	{
		private List<Ingrediente> _AllIngredientes;
		private List<Ingrediente> _Tortillas;
		private List<Ingrediente> _Rellenos;
		private List<Ingrediente> _Salsas;
		private string _tipoIngrediente;
		private BusinessLogicLayer _businessLogicLayer;
		public FormIngredient()
		{
			InitializeComponent();
			_businessLogicLayer = new();
			_AllIngredientes = new();
			_Tortillas = new();
			_Rellenos = new();
			_Salsas = new();
		}

		#region EVENTS

		private void FormIngredient_Load(object sender, EventArgs e)
		{
			ActualizarGrillaSearch();
		}
		private void BtnAddIngredient_Click(object sender, EventArgs e)
		{
			OpenIngredientDetails();
		}

		#endregion

		#region PRIVATE METHODS
		private void BtnSeacrhIngredient_Click(object sender, EventArgs e)
		{

		}
		private void OpenIngredientDetails()
		{
			FormIngredientDetails formIngredientDetails = new();
			formIngredientDetails.Show(this);
		}

		#endregion

		#region PUBLIC METHODS

		public void ActualizarGrillaSearch(string searchText = null)
		{
			UnirListas();
			dgvFormIngredient.DataSource = _AllIngredientes;
		}

		public void UnirListas()
		{
			_tipoIngrediente = "Tortilla";
			_Tortillas = _businessLogicLayer.GetIngredientes(_tipoIngrediente);
			_tipoIngrediente = "Relleno";
			_Rellenos = _businessLogicLayer.GetIngredientes(_tipoIngrediente);
			_tipoIngrediente = "Salsa";
			_Salsas = _businessLogicLayer.GetIngredientes(_tipoIngrediente);
			_AllIngredientes = _Tortillas.Concat(_Rellenos).Concat(_Salsas).ToList();
		}

		#endregion

		private void FormIngredient_Activated(object sender, EventArgs e)
		{
			ActualizarGrillaSearch();
		}
	}
}
