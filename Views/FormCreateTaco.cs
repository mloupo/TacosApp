using Model;
using Model.Controllers;
using Model.Interfaces;
using Model.Productos;

namespace Views
{
	public partial class FormCreateTaco : Form
	{
		private List<IIngrediente> ListaTortillas;
		private List<IIngrediente> ListaSalsas;
		private List<IIngrediente> ListaRellenos;
		private List<IIngrediente> AllIngredientList;
		private List<IIngrediente> ListaIngredientesTaco;
		private List<Taco> listaTacos;

		public FormCreateTaco()
		{
			InitializeComponent();
			cmbTipoIngrediente.DataSource = Enum.GetNames(typeof(Enums.TipoIngrediente)); //Ir a buscar a la base de datos

			ListaTortillas = new();
			ListaRellenos = new();
			ListaSalsas = new();
			AllIngredientList = new();
			ListaIngredientesTaco = new();
			OrdenarIngredientesBD(AllIngredientList);
			CargarIngredientesCmb();
		}

		private void BtnCreateTaco_Click(object sender, EventArgs e)
		{

			ActualizarListaTacos(listaTacos);
			//Aca ademas de cargar el taco recien creado a la lista de tacos del pedido,
			//hay que llamar una funcion que calcule taco valor menor, mayor y promedio
		}

		private void BtnAgregarIngrediente_Click(object sender, EventArgs e)
		{
			ListaIngredientesTaco.Add((IIngrediente)cmbIngrediente.SelectedItem);

		}

		private void CmbTipoIngrediente_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarIngredientesCmb();
		}

		private void CargarIngredientesCmb()
		{
			switch (cmbTipoIngrediente.Text)
			{
				case "Salsa":
					cmbIngrediente.DataSource = ListaSalsas;
					break;

				case "Relleno":
					cmbIngrediente.DataSource = ListaRellenos;
					break;

				case "Tortilla":
					cmbIngrediente.DataSource = ListaTortillas;
					break;
			}
		}

		private void CargarIngredientesTaco(List<IIngrediente> lista)
		{
			// Cargar el ingrediente selecionado en el datagrid
			OrdenarIngredientesBD(AllIngredientList);
		}

		private void OrdenarIngredientesBD(List<IIngrediente> AllIngredientList)
		{
			foreach (IIngrediente ingrediente in AllIngredientList)
			{
				switch (ingrediente.GetType().Name)
				{
					case "Salsa":
						ListaSalsas.Add(ingrediente);
						break;

					case "Relleno":
						ListaRellenos.Add(ingrediente);
						break;

					case "Tortilla":
						ListaTortillas.Add(ingrediente);
						break;
				}
			}
		}

		private void ActualizarListaTacos(List<Taco> listaTacos)
		{
			dgvTacoDetails.Rows.Clear();
			dgvTacoDetails.Refresh();

			foreach (var taco in listaTacos)
			{
				Console.WriteLine("\n-----------------------------------------------------------");
				taco.Info();
			}
		}
	}
}
