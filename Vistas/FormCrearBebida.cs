

using Modelo;
using Modelo.Controladores;
using Modelo.EntidadesProducto.Bebidas;
using Servicio.Logica;

namespace Vistas
{
	public partial class FormCrearBebida : Form
	{
		private string? _tipoBebida;
		private Bebida? _bebida;
		private readonly CapaLogicaNegocio _capaLogicaNegocio;
		private readonly ControladorBebida _controladorBebida;
		private List<Bebida> _listaBebidas;

		public FormCrearBebida()
		{
			InitializeComponent();
			_capaLogicaNegocio = new();
			_controladorBebida = ControladorBebida.ObtenerInstancia();
			_listaBebidas = new();
		}

		private void btnCrearBebida_Click(object sender, EventArgs e)
		{
			GuardarBebida();
		}

		private void cmbTipoBebida_SelectedIndexChanged(object sender, EventArgs e)
		{
			LimpiarCampos();
			ActualizarGridView();
		}

		private void btnCancelarCreacion_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormCrearBebida_Load(object sender, EventArgs e)
		{
			cmbTipoBebida.DataSource = Enum.GetNames(typeof(Enums.TipoBebida));
			_tipoBebida = cmbTipoBebida.SelectedItem.ToString();
			CargarGridView();
		}

		private void dgvBebidaDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvBebidaDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.Value.ToString() == "Edit")
			{
				int id = int.Parse(dgvBebidaDetalles.Rows[e.RowIndex].Cells[0].Value.ToString());
				string name = dgvBebidaDetalles.Rows[e.RowIndex].Cells[1].Value.ToString();
				string priceStr = dgvBebidaDetalles.Rows[e.RowIndex].Cells[2].Value.ToString();

				if (!EsValidoDecimal(priceStr))
				{
					MessageBox.Show("Invalid price value. Please enter a valid decimal value.");
					return;
				}

				float price = float.Parse(priceStr);

				Bebida bebida = (Bebida)_controladorBebida.Crear(
						_tipoBebida, name, price, id);

				CargarBebida(bebida);
			}
			else if (cell.Value.ToString() == "Delete")
			{
				string idStr = dgvBebidaDetalles.Rows[e.RowIndex].Cells[0].Value?.ToString();
				if (string.IsNullOrEmpty(idStr))
				{
					MessageBox.Show("Invalid ID value. Please enter a valid ID value.");
					return;
				}

				if (!int.TryParse(idStr, out int id))
				{
					MessageBox.Show("Invalid ID value. Please enter a valid ID value.");
					return;
				}

				EliminarBebida(id);
				ActualizarGridView();
			}
		}

		private void GuardarBebida()
		{
			if (String.IsNullOrEmpty(txtNombreBebida.Text))
			{
				MessageBox.Show("Por favor ingresa un nombre válido");
				return;
			}

			if (!EsValidoPositivoDecimal(txtPrecioBebida.Text))
			{
				MessageBox.Show("Por favor ingresa un valor decimal válido para el precio.");
				return;
			}

			if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombreBebida.Text, "^[a-zA-Z]+$"))
			{
				MessageBox.Show("El nombre del ingrediente solo debe contener letras.");
				return;
			}

			Bebida creacion = (Bebida)_controladorBebida.Crear(
				_tipoBebida,
				txtNombreBebida.Text,
				float.Parse(txtPrecioBebida.Text));
			creacion.Id = _bebida != null ? _bebida.Id : 0;

			LimpiarCampos();
			_capaLogicaNegocio.AlmacenarBebida(creacion, _tipoBebida);
			ActualizarGridView();
		}

		private bool EsValidoDecimal(string input)
		{
			float result;

			if (!float.TryParse(input, out result))
			{
				return false;
			}
			return true;
		}

		private bool EsValidoPositivoDecimal(string input)
		{
			float result;

			if (!float.TryParse(input, out result))
			{
				return false;
			}

			return result > 0;
		}

		private void LimpiarCampos()
		{
			txtNombreBebida.Text = String.Empty;
			txtPrecioBebida.Text = String.Empty;
		}

		private void CargarGridView()
		{
			dgvBebidaDetalles.DataSource = null;
			_listaBebidas = _capaLogicaNegocio.ObtenerBebidas(_tipoBebida);
			dgvBebidaDetalles.DataSource = _listaBebidas;
		}

		private void ActualizarGridView()
		{
			_tipoBebida = cmbTipoBebida.SelectedItem.ToString();
			_listaBebidas = _capaLogicaNegocio.ObtenerBebidas(_tipoBebida);
			dgvBebidaDetalles.DataSource = _listaBebidas;
		}

		public void CargarBebida(Bebida bebida)
		{
			_bebida = bebida;

			if (_bebida != null)
			{
				LimpiarCampos();
				txtNombreBebida.Text = _bebida.Nombre;
				txtPrecioBebida.Text = _bebida.Precio.ToString();
			}
		}

		public void EliminarBebida(int id)
		{
			_capaLogicaNegocio.EliminarBebida(id, _tipoBebida);
		}
	}
}
