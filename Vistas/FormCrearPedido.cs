using Modelo;
using Modelo.Controladores;
using Modelo.EntidadesProducto.Tacos;
using Servicio.Logica;

namespace Vistas
{
	public partial class FormCrearPedido : Form
	{
		private string _tipoIngrediente;
		private string _tipoBebida;
		private List<Ingrediente> _ingredientes;
		private Ingrediente _ingrediente;
		private Taco taco;

		private readonly CapaLogicaNegocio _businessLogicLayer;

		private readonly ControladorTaco _tacoController;
		private readonly ControladorIngrediente _ingredienteController;
		private readonly ControladorBebida _bebidaController;

		private List<Taco> listaTacos;

		public FormCrearPedido()
		{
			InitializeComponent();
			_businessLogicLayer = new();
			_tacoController = new();
			_ingredienteController = new();
			_bebidaController = new();
			listaTacos = new();
			_ingredientes = new();
		}

		private void btnAgregarIngrediente_Click(object sender, EventArgs e)
		{
			List<Ingrediente> listaIngredientesTaco = new();
			switch (cmbIngrediente.SelectedItem.ToString())
			{
				case "Salsa":
					listaIngredientesTaco = _businessLogicLayer.ObtenerIngredientes("Salsa").ToList();
					_ingrediente = _ingredientes.Find(ingrediente => ingrediente.Nombre == cmbIngrediente.SelectedItem.ToString());
					break;
				case "Relleno":
					listaIngredientesTaco = _businessLogicLayer.ObtenerIngredientes("Relleno").ToList();
					_ingrediente = _ingredientes.Find(ingrediente => ingrediente.Nombre == cmbIngrediente.SelectedItem.ToString());
					break;
				case "Tortilla":
					listaIngredientesTaco = _businessLogicLayer.ObtenerIngredientes("Tortilla").ToList();
					_ingrediente = _ingredientes.Find(ingrediente => ingrediente.Nombre == cmbIngrediente.SelectedItem.ToString());
					break;
			}
			listaIngredientesTaco.Add(_ingrediente);
			_ingredientes = listaIngredientesTaco;
			ActualizarDgvListaIngredientesTaco(_ingredientes);

		}
		private void ActualizarDgvListaIngredientesTaco(List<Ingrediente> list)
		{
			dgvTacoDetails.DataSource = list;
		}

		private void cmbTipoIngrediente_SelectedIndexChanged(object sender, EventArgs e)
		{
			_tipoIngrediente = cmbTipoIngrediente.SelectedItem.ToString();
			CargarIngredientesCmb();
		}

		private void CargarIngredientesCmb()
		{
			switch (_tipoIngrediente)
			{
				case "Salsa":
					cmbIngrediente.DataSource = _businessLogicLayer.ObtenerIngredientes("Salsa");
					break;
				case "Relleno":
					cmbIngrediente.DataSource = _businessLogicLayer.ObtenerIngredientes("Relleno");
					break;
				case "Tortilla":
					cmbIngrediente.DataSource = _businessLogicLayer.ObtenerIngredientes("Tortilla");
					break;
				default:
					cmbIngrediente.DataSource = null;
					break;
			}

			cmbIngrediente.ValueMember = "Nombre";
			cmbIngrediente.DisplayMember = "Nombre";
			cmbIngrediente.SelectedIndex = 0;
		}

		private void btnCrearTaco_Click(object sender, EventArgs e)
		{
			taco = new Taco(_ingredientes);
			listaTacos.Add(taco);
			ActualizarDgvListaTacos(listaTacos);
			CalcularValorTacos(listaTacos);
		}

		private void ActualizarDgvListaTacos(List<Taco> listaTacos)
		{
			dgvTacoDetails.DataSource = null;
			dgvTacoDetails.DataSource = listaTacos;
			dgvTacoDetails.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void CalcularValorTacos(List<Taco> tacos)
		{
			var precios = tacos.Select(x => x.ObtenerPrecio()).ToArray();
			if (precios.Any())
			{
				var valorMayor = precios.Max();
				var valorMenor = precios.Min();
				var promedio = precios.Average();

				txtMayorValorTaco.Text = $"${valorMayor:0.00}";
				txtMenorValorTaco.Text = $"${valorMenor:0.00}";
				txtPromedioValorTaco.Text = $"${promedio:0.00}";
			}
		}

		private void btnCargaPedido_Click(object sender, EventArgs e)
		{
			GenerarNuevoPedido();
		}

		public void GenerarNuevoPedido()
		{
			// Code to generate a new order 

		}

		private void FormCreateTaco_Load(object sender, EventArgs e)
		{
			cmbTipoIngrediente.DataSource = Enum.GetNames(typeof(Enums.TipoIngrediente));
			txtDatosCliente.Enabled = false;
			txtNroContactoCliente.Enabled = false;
			dtPickerDeliveryRequest.Enabled = false;
			cmbTipoBebida.Enabled = false;
			cmbBebidaSeleccionada.Enabled = false;
		}


		private void ckbDelivery_CheckedChanged(object sender, EventArgs e)
		{
			CambiarEstadoTextboxesDelivery();
		}
		private void CambiarEstadoTextboxesDelivery()
		{
			bool enabled = ckbDelivery.Checked;
			txtDatosCliente.Enabled = enabled;
			txtNroContactoCliente.Enabled = enabled;
			dtPickerDeliveryRequest.Enabled = enabled;
		}

		private void ckbBebida_CheckedChanged(object sender, EventArgs e)
		{
			CambiarEstadoTextboxesBebidas();
		}
		private void CambiarEstadoTextboxesBebidas()
		{
			bool enabled = ckbBebida.Checked;
			cmbTipoBebida.Enabled = enabled;
			cmbBebidaSeleccionada.Enabled = enabled;
		}

		private void cmbTipoBebida_SelectedIndexChanged(object sender, EventArgs e)
		{
			_tipoBebida = cmbTipoIngrediente.SelectedItem.ToString();
			CargarTipoBebidasCmb();
		}

		private void CargarTipoBebidasCmb()
		{
			switch (_tipoIngrediente)
			{
				case "Agua":
					cmbIngrediente.DataSource = _businessLogicLayer.ObtenerBebidas("Agua");
					break;
				case "Gaseosa":
					cmbIngrediente.DataSource = _businessLogicLayer.ObtenerBebidas("Gaseosa");
					break;
				case "Cerveza":
					cmbIngrediente.DataSource = _businessLogicLayer.ObtenerBebidas("Cerveza");
					break;
				default:
					cmbIngrediente.DataSource = null;
					break;
			}

			cmbIngrediente.ValueMember = "Nombre";
			cmbIngrediente.DisplayMember = "Nombre";
			cmbIngrediente.SelectedIndex = 0;
		}

	}
}