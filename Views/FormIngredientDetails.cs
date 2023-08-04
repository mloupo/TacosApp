using Model;
using Model.Controllers;
using Model.Productos;

namespace Views
{
	public partial class FormIngredientDetails : Form
	{
		private string tipoIngrediente;
		private Ingrediente _ingrediente;
		private readonly BusinessLogicLayer _businessLogicLayer;
		private readonly IngredientController _ingredientController;
		private List<Ingrediente> _ingredientes;

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

				if (!IsValidDecimal(priceStr))
				{
					MessageBox.Show("Invalid price value. Please enter a valid decimal value.");
					return;
				}

				decimal price = decimal.Parse(priceStr);

				Ingrediente ingredient = (Ingrediente)_ingredientController.Create(
						tipoIngrediente, name, price, id);

				CargarIngrediente(ingredient);
			}
			else if (cell.Value.ToString() == "Delete")
			{
				int id = int.Parse(dgvIngredientDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
				EliminarIngrediente(id);
				ActualizarGridView();
			}
		}

		private void GuardarIngrediente()
		{
			decimal price;
			if (!IsValidPositiveDecimal(txtIngredientPrice.Text))
			{
				MessageBox.Show("Invalid price value. Please enter a valid decimal value.");
				return;
			}

			Ingrediente creation = (Ingrediente)_ingredientController.Create(
				tipoIngrediente,
				txtIngredientName.Text,
				decimal.Parse(txtIngredientPrice.Text));
			creation.Id = _ingrediente != null ? _ingrediente.Id : 0;

			LimpiarCampos();
			_businessLogicLayer.SaveIngrediente(creation, tipoIngrediente);
			ActualizarGridView();
		}

		private bool IsValidDecimal(string input)
		{
			decimal result;

			if (!decimal.TryParse(input, out result))
			{
				return false;
			}

			return true;
		}

		private bool IsValidPositiveDecimal(string input)
		{
			decimal result;

			if (!decimal.TryParse(input, out result))
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
			_ingredientes = _businessLogicLayer.GetIngredientes(tipoIngrediente);
			dgvIngredientDetails.DataSource = _ingredientes;
		}

		private void ActualizarGridView()
		{
			tipoIngrediente = CmbIngredientType.SelectedItem.ToString();
			_ingredientes = _businessLogicLayer.GetIngredientes(tipoIngrediente);
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
			_businessLogicLayer.DeleteIngredient(id, tipoIngrediente);
		}
	}
}
