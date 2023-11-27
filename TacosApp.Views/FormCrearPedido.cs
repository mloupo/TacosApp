using Model;
using Model.Controllers;
using Service.Logica;
using System.ComponentModel;
using TacosApp.Model.EntidadesProducto.Tacos;

namespace Views
{
	public partial class FormCrearPedido : Form
	{
		private string _tipoIngrediente;
		private readonly CapaLogicaNegocio _businessLogicLayer;
		private readonly ControladorTaco _tacoController;
		private Taco taco = new Taco();

		private BindingList<Ingrediente> listaIngredientesTaco = new();
		private List<Taco> listaTacos = new List<Taco>();

		public FormCrearPedido()
		{
			InitializeComponent();
			_businessLogicLayer = new();
		}

		private void btnAgregarIngrediente_Click(object sender, EventArgs e)
		{

			if (cmbIngrediente.SelectedIndex >= 0)
			{
				listaIngredientesTaco.Add(cmbIngrediente.SelectedItem as Ingrediente);
			}
			else
			{
				MessageBox.Show("Debe seleccionar un ingrediente.");
			}
		}

		private void btnCreateTaco_Click(object sender, EventArgs e)
		{


			listaTacos.Add(taco);
			ActualizarListaTacos(listaTacos);
			CalcularValorTacos(listaTacos);
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

		private void CargarIngredientesTaco(List<Ingrediente> list)
		{
			dgvTacoDetails.DataSource = list;
		}

		private void ActualizarListaTacos(List<Taco> listaTacos)
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

		}
		private void CambiarEstadoTextboxesBebidas()
		{
			bool enabled = ckbBebida.Checked;
			txtTipoBebida.Enabled = enabled;
			txtNroContactoCliente.Enabled = enabled;
		}
	}
}