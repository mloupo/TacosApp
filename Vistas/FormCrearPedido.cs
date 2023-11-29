using Model.Controllers;
using Modelo;
using Modelo.EntidadesProducto.Bebidas;
using Modelo.EntidadesProducto.Tacos;
using Modelo.EntidadesUsuario;
using Servicio.Logica;

namespace Vistas
{
	public partial class FormCrearPedido : Form
	{
		private string _tipoIngrediente;
		private string _tipoBebida;

		private Ingrediente _ingrediente;
		private Bebida _bebida;
		private Taco _taco;
		private Pedido _pedido;
		private Contacto _contacto;

		private List<Ingrediente> _ingredientesSeleccionados;
		private List<Bebida> _bebidasSeleccionadas;
		private List<Taco> _tacos;


		private readonly CapaLogicaNegocio _businessLogicLayer;
		private readonly ControladorPedido _pedidoController;
		//private readonly AgregarIngredienteValidador _agregarIngredienteValidador;

		public FormCrearPedido()
		{
			InitializeComponent();
			_businessLogicLayer = new CapaLogicaNegocio();
			_pedidoController = ControladorPedido.ObtenerInstancia();
			_ingredientesSeleccionados = new List<Ingrediente>();
			_bebidasSeleccionadas = new List<Bebida>();
			_tacos = new List<Taco>();
		}
		private void FormCreateTaco_Load(object sender, EventArgs e)
		{
			cmbTipoIngrediente.DataSource = Enum.GetNames(typeof(Enums.TipoIngrediente));
			cmbTipoBebida.DataSource = Enum.GetNames(typeof(Enums.TipoBebida));
			cmbNombreCliente.DataSource = _businessLogicLayer.ObtenerContactos();

			cmbNombreCliente.Enabled = false;
			txtNroContactoCliente.Enabled = false;
			dtPickerDeliveryRequest.Enabled = false;

			cmbTipoBebida.Enabled = false;
			cmbBebida.Enabled = false;

			btnAgregarBebida.Enabled = false;
			btnAgregarContactoDelivery.Enabled = false;
		}


		private void cmbTipoIngrediente_SelectedIndexChanged(object sender, EventArgs e)
		{
			_tipoIngrediente = cmbTipoIngrediente.SelectedItem.ToString();
			CargarIngredientesCmb();
		}
		private void cmbTipoBebida_SelectedIndexChanged(object sender, EventArgs e)
		{
			_tipoBebida = cmbTipoBebida.SelectedItem.ToString();
			CargarBebidasCmb();
		}
		private void cmbNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarClientesCmb();
		}

		private void CargarIngredientesCmb()
		{
			cmbIngrediente.DataSource = _businessLogicLayer.ObtenerIngredientes(_tipoIngrediente);
			cmbIngrediente.ValueMember = "Id";
			cmbIngrediente.DisplayMember = "Nombre";
			cmbIngrediente.SelectedIndex = 0;
		}
		private void CargarBebidasCmb()
		{
			cmbBebida.DataSource = _businessLogicLayer.ObtenerBebidas(_tipoBebida);
			cmbBebida.ValueMember = "Id";
			cmbBebida.DisplayMember = "Nombre";
			cmbBebida.SelectedIndex = 0;
		}
		private void CargarClientesCmb()
		{
			var clientes = _businessLogicLayer.ObtenerContactos();
			cmbNombreCliente.DataSource = clientes;
			cmbNombreCliente.ValueMember = "Id";
			cmbNombreCliente.DisplayMember = "Nombre";
			cmbNombreCliente.SelectedIndex = 0;
		}


		private void btnAgregarIngrediente_Click(object sender, EventArgs e)
		{
			_ingredientesSeleccionados = _businessLogicLayer.ObtenerIngredientes(_tipoIngrediente);
			_ingrediente = _ingredientesSeleccionados.FirstOrDefault(i => i.Nombre == cmbIngrediente.SelectedItem.ToString());


			if (_ingrediente != null)
			{
				_ingredientesSeleccionados.Add(_ingrediente);
				ActualizarDgvListaIngredientesTaco(_ingredientesSeleccionados);
			}
		}
		private void btnAgregarBebida_Click(object sender, EventArgs e)
		{
			_bebida = _businessLogicLayer.ObtenerBebidas(_tipoBebida)
				.FirstOrDefault(i => i.Nombre == cmbBebida.SelectedItem.ToString());

			if (_bebida != null)
			{
				_bebidasSeleccionadas.Add(_bebida);
				foreach (var bebida in _bebidasSeleccionadas)
				{
					Console.WriteLine(bebida);
				}
			}
		}
		private void btnAgregarContactoDelivery_Click(object sender, EventArgs e)
		{
			_pedidoController.AgregarInfoContactoAPedido();
		}

		private void btnCrearTaco_Click(object sender, EventArgs e)
		{
			CrearTacoSiIngredientes();
		}

		private void btnCargaPedido_Click(object sender, EventArgs e)
		{
			GenerarNuevoPedido();
		}



		private void ActualizarDgvListaIngredientesTaco(List<Ingrediente> list)
		{
			dgvIngredientesTacoDetalle.DataSource = null;
			dgvIngredientesTacoDetalle.DataSource = list;
		}
		private void ActualizarDgvListaTacos(List<Taco> listaTacos)
		{
			dgvTacoDetails.DataSource = null;
			dgvTacoDetails.DataSource = listaTacos;
		}


		private void ckbDelivery_CheckedChanged(object sender, EventArgs e)
		{
			CambiarEstadoTextboxesDelivery(ckbDelivery.Checked);
		}
		private void ckbBebida_CheckedChanged(object sender, EventArgs e)
		{
			CambiarEstadoTextboxesBebidas(ckbBebida.Checked);
		}


		private void CambiarEstadoTextboxesDelivery(bool enabled)
		{
			cmbNombreCliente.Enabled = enabled;
			txtNroContactoCliente.Enabled = enabled;
			dtPickerDeliveryRequest.Enabled = enabled;
			btnAgregarContactoDelivery.Enabled = enabled;
		}
		private void CambiarEstadoTextboxesBebidas(bool enabled)
		{
			cmbTipoBebida.Enabled = enabled;
			cmbBebida.Enabled = enabled;
			btnAgregarBebida.Enabled = enabled;
		}

		private void CrearTacoSiIngredientes()
		{
			if (_ingredientesSeleccionados != null)
			{
				CrearYAgregarTaco();
			}
			else
			{
				MostrarMensajeErrorIngredientes();
			}
		}

		private void CrearYAgregarTaco()
		{
			_taco = new Taco(_ingredientesSeleccionados);
			_tacos.Add(_taco);
			ActualizarDgvListaTacos(_tacos);
			CalcularValorTacos(_tacos);
		}

		private void MostrarMensajeErrorIngredientes()
		{
			MessageBox.Show("Debe agregar ingredientes al taco");
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

		public void GenerarNuevoPedido()
		{
			Console.WriteLine("Generando nuevo pedido");
			_pedido = _pedidoController.CrearNuevoPedido(_tacos, _bebidasSeleccionadas);
			_pedido.ToString();
		}


	}
}