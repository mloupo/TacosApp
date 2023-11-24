using Model;
using Model.Controllers;
using Model.Productos;
using Service;

namespace Views
{
	public partial class FormCrearIngrediente : Form
	{
		private string tipoIngrediente;
		private Ingrediente _ingrediente;
		private readonly CapaLogicaNegocio _capaLogicaNegocio;
		private readonly ControladorIngrediente _controladorIngrediente;
		private List<Ingrediente> _ingredientes;

		public FormCrearIngrediente()
		{
			InitializeComponent();
			_capaLogicaNegocio = new();
			_controladorIngrediente = ControladorIngrediente.ObtenerInstancia();
			_ingredientes = new();
		}

		private void BtnCreateIngredient_Click(object sender, EventArgs e)
		{
			GuardarIngrediente();
		}

		private void CmbIngredientType_SelectedIndexChanged(object sender, EventArgs e)
		{
			LimpiarCampos();
			ActualizarGridView();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormIngredientDetails_Load(object sender, EventArgs e)
		{
			CmbIngredientType.DataSource = Enum.GetNames(typeof(Enums.TipoIngrediente));
			tipoIngrediente = CmbIngredientType.SelectedItem.ToString();
			CargarGridView();
		}

		private void DgvIngredientDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvIngredientDetails.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.Value.ToString() == "Edit")
			{
				int id = int.Parse(dgvIngredientDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
				string name = dgvIngredientDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
				string priceStr = dgvIngredientDetails.Rows[e.RowIndex].Cells[2].Value.ToString();

				if (!EsValidoDecimal(priceStr))
				{
					MessageBox.Show("Invalid price value. Please enter a valid decimal value.");
					return;
				}

				float price = float.Parse(priceStr);

				Ingrediente ingredient = (Ingrediente)_controladorIngrediente.Crear(
						tipoIngrediente, name, price, id);

				CargarIngrediente(ingredient);
			}
			else if (cell.Value.ToString() == "Delete")
			{
				string idStr = dgvIngredientDetails.Rows[e.RowIndex].Cells[0].Value?.ToString();
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

				EliminarIngrediente(id);
				ActualizarGridView();
			}
		}

		private void GuardarIngrediente()
		{
			if (String.IsNullOrEmpty(txtIngredientName.Text))
			{
				MessageBox.Show("Por favor ingresa un nombre válido");
				return;
			}

			if (!EsValidoPositivoDecimal(txtIngredientPrice.Text))
			{
				MessageBox.Show("Por favor ingresa un valor decimal válido para el precio.");
				return;
			}

			if (!System.Text.RegularExpressions.Regex.IsMatch(txtIngredientName.Text, "^[a-zA-Z]+$"))
			{
				MessageBox.Show("El nombre del ingrediente solo debe contener letras.");
				return;
			}

			Ingrediente creacion = (Ingrediente)_controladorIngrediente.Crear(
				tipoIngrediente,
				txtIngredientName.Text,
				float.Parse(txtIngredientPrice.Text));
			creacion.Id = _ingrediente != null ? _ingrediente.Id : 0;

			LimpiarCampos();
			_capaLogicaNegocio.AlmacenarIngrediente(creacion, tipoIngrediente);
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
			txtIngredientName.Text = String.Empty;
			txtIngredientPrice.Text = String.Empty;
		}

		private void CargarGridView()
		{
			_ingredientes = _capaLogicaNegocio.ObtenerIngredientes(tipoIngrediente);
			dgvIngredientDetails.DataSource = _ingredientes;
		}

		private void ActualizarGridView()
		{
			tipoIngrediente = CmbIngredientType.SelectedItem.ToString();
			_ingredientes = _capaLogicaNegocio.ObtenerIngredientes(tipoIngrediente);
			dgvIngredientDetails.DataSource = _ingredientes;
		}

		public void CargarIngrediente(Ingrediente ingredient)
		{
			_ingrediente = ingredient;

			if (_ingrediente != null)
			{
				LimpiarCampos();
				txtIngredientName.Text = _ingrediente.Nombre;
				txtIngredientPrice.Text = _ingrediente.Precio.ToString();
			}
		}

		public void EliminarIngrediente(int id)
		{
			_capaLogicaNegocio.EliminarIngrediente(id, tipoIngrediente);
		}
	}
}
