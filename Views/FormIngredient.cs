﻿using Model;
using Model.Productos;

namespace Views
{
	public partial class FormIngredient : Form
	{
		private readonly List<Ingrediente> _allIngredientes;
		private readonly List<Ingrediente> _tortillas;
		private readonly List<Ingrediente> _rellenos;
		private readonly List<Ingrediente> _salsas;
		private readonly string _tipoIngrediente;
		private readonly BusinessLogicLayer _businessLogicLayer;

		public FormIngredient()
		{
			InitializeComponent();
			_businessLogicLayer = new BusinessLogicLayer();
			_allIngredientes = new List<Ingrediente>();
			_tortillas = new List<Ingrediente>();
			_rellenos = new List<Ingrediente>();
			_salsas = new List<Ingrediente>();
			_tipoIngrediente = "";
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
			_tortillas.AddRange(_businessLogicLayer.GetIngredientes("Tortilla"));
			_rellenos.AddRange(_businessLogicLayer.GetIngredientes("Relleno"));
			_salsas.AddRange(_businessLogicLayer.GetIngredientes("Salsa"));

			_allIngredientes.AddRange(_tortillas);
			_allIngredientes.AddRange(_rellenos);
			_allIngredientes.AddRange(_salsas);

			return _allIngredientes;
		}


		private void OpenIngredientDetails()
		{
			FormIngredientDetails formIngredientDetails = new FormIngredientDetails();
			formIngredientDetails.ShowDialog();
		}

		private void FormIngredient_Load(object sender, EventArgs e)
		{
			ActualizarGrillaSearch();
		}

		private void btnAddIngredient_Click(object sender, EventArgs e)
		{
			OpenIngredientDetails();
			ActualizarGrillaSearch();
		}
	}
}
