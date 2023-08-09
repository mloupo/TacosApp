using Model;
using Model.Productos;
using System.ComponentModel;
using static Model.Enums;

namespace Views
{
	public partial class FormCreateTaco : Form
	{
		private string _tipoIngrediente;
		private List<Ingrediente> listaTortillas = new();
		private List<Ingrediente> listaSalsas = new();
		private List<Ingrediente> listaRellenos = new();
		private BindingList<Ingrediente> listaIngredientesTaco = new();
		private List<Taco> listaTacos = new List<Taco>();

		public FormCreateTaco()
		{
			InitializeComponent();

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
			var taco = new Taco(listaIngredientesTaco);

			listaTacos.Add(taco);
			ActualizarListaTacos(listaTacos);
			CalcularValorTacos(listaTacos);
		}

		private void cmbTipoIngrediente_SelectedIndexChanged(object sender, EventArgs e)
		{
			_tipoIngrediente = cmbTipoIngrediente.SelectedItem.ToString();
			CargarListasIngredientes();

		}

		private void CargarIngredientesCmb()
		{
			switch (_tipoIngrediente)
			{
				case "Salsa":
					cmbIngrediente.DataSource = listaSalsas;
					break;
				case "Relleno":
					cmbIngrediente.DataSource = listaRellenos;
					break;
				case "Tortilla":
					cmbIngrediente.DataSource = listaTortillas;
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
			var precios = tacos.Select(x => x.GetPrecio()).ToArray();
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
			// Code to generate a new order goes here

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
			CambiarEstadoTextboxes();
		}
		private void CambiarEstadoTextboxes()
		{
			bool enabled = ckbDelivery.Checked;
			txtDatosCliente.Enabled = enabled;
			txtNroContactoCliente.Enabled = enabled;
			dtPickerDeliveryRequest.Enabled = enabled;
		}


		private void CargarListasIngredientes()
		{
			var businessLogicLayer = new BusinessLogicLayer();
			var dataAccessLayer = new DataAccessLayer();

			listaRellenos = businessLogicLayer.GetIngredientes("Relleno");
			listaSalsas = businessLogicLayer.GetIngredientes("Salsa");
			listaTortillas = businessLogicLayer.GetIngredientes("Tortilla");

			CargarIngredientesCmb();
		}
	}
}