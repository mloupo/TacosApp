using Model.Controllers;
using Modelo;
using Modelo.EntidadesProducto.Bebidas;
using Modelo.EntidadesProducto.Tacos;
using Servicio.Logica;
using Validaciones.Ingredientes;

namespace Vistas
{
	public partial class FormCrearPedido : Form
	{
		private string _tipoIngrediente;
		private string _tipoBebida;

		private Ingrediente _ingrediente;
		private Bebida _bebida;
		private Taco _taco;

		private List<Ingrediente> _listaIngredientes;
		private List<Bebida> _listaBebidas;
		private List<Taco> _listaTacos;

		private Pedido _pedido;

		private readonly CapaLogicaNegocio _businessLogicLayer;
		private readonly ControladorPedido _pedidoController;
		//private readonly ControladorTaco _tacoController;
		//private readonly ControladorIngrediente _ingredienteController;
		//private readonly ControladorBebida _bebidaController;
		private readonly AgregarIngredienteValidador _agregarIngredienteValidador;

		public FormCrearPedido()
		{
			InitializeComponent();
			_businessLogicLayer = new CapaLogicaNegocio();
			_pedidoController = ControladorPedido.ObtenerInstancia();
			//_tacoController = new ControladorTaco();
			//_ingredienteController = new ControladorIngrediente();
			//_bebidaController = new ControladorBebida();
			_listaTacos = new List<Taco>();
			_listaIngredientes = new List<Ingrediente>();
		}

		private void cmbTipoIngrediente_SelectedIndexChanged(object sender, EventArgs e)
		{
			_tipoIngrediente = cmbTipoIngrediente.SelectedItem.ToString();
			CargarIngredientesCmb();
		}

		private void CargarIngredientesCmb()
		{
			cmbIngrediente.DataSource = _businessLogicLayer.ObtenerIngredientes(_tipoIngrediente);
			cmbIngrediente.ValueMember = "Nombre";
			cmbIngrediente.DisplayMember = "Nombre";
			cmbIngrediente.SelectedIndex = 0;
		}

		private void btnAgregarIngrediente_Click(object sender, EventArgs e)
		{

			_ingrediente = _businessLogicLayer.ObtenerIngredientes(cmbTipoIngrediente.SelectedItem.ToString())
				.FirstOrDefault(i => i.Nombre == cmbIngrediente.SelectedItem.ToString());
			Console.WriteLine(cmbIngrediente.SelectedItem.ToString());
			Console.WriteLine(_ingrediente);
			Console.ReadLine();
			var validationResults = _agregarIngredienteValidador.Validate(_ingrediente);

			if (validationResults.IsValid)
			{
				_listaIngredientes.Add(_ingrediente);
				ActualizarDgvListaIngredientesTaco(_listaIngredientes);
			}
		}

		private void ActualizarDgvListaIngredientesTaco(List<Ingrediente> list)
		{
			dgvIngredientesTacoDetalle.DataSource = null;
			dgvIngredientesTacoDetalle.DataSource = list;
		}

		private void btnCrearTaco_Click(object sender, EventArgs e)
		{
			if (_listaIngredientes.Any())
			{
				_taco = new Taco(_listaIngredientes);
				_listaTacos.Add(_taco);
				ActualizarDgvListaTacos(_listaTacos);
				CalcularValorTacos(_listaTacos);
			}
			else
			{
				MessageBox.Show("Debe agregar ingredientes al taco");
			}
		}

		private void ActualizarDgvListaTacos(List<Taco> listaTacos)
		{
			dgvTacoDetails.DataSource = null;
			dgvTacoDetails.DataSource = listaTacos;
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
			_pedidoController.AgregarNuevoPedido(_listaTacos, _listaBebidas);
		}

		private void FormCreateTaco_Load(object sender, EventArgs e)
		{
			cmbTipoIngrediente.DataSource = Enum.GetNames(typeof(Enums.TipoIngrediente));
			txtDatosCliente.Enabled = false;
			txtNroContactoCliente.Enabled = false;
			dtPickerDeliveryRequest.Enabled = false;
			cmbTipoBebida.DataSource = Enum.GetNames(typeof(Enums.TipoBebida));
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
			_tipoBebida = cmbTipoBebida.SelectedItem.ToString();
			CargarTipoBebidasCmb();
		}

		private void CargarTipoBebidasCmb()
		{
			cmbBebidaSeleccionada.DataSource = _businessLogicLayer.ObtenerBebidas(_tipoBebida);
			cmbBebidaSeleccionada.ValueMember = "Nombre";
			cmbBebidaSeleccionada.DisplayMember = "Nombre";
			cmbBebidaSeleccionada.SelectedIndex = 0;
		}
	}
}