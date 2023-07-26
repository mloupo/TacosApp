using Model;
using Model.Controllers;
using Model.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Model.Enums;

namespace Views
{
	public partial class FormIngredientDetails : Form
	{
		private string tipoIngrediente;
		private Ingrediente _ingrediente;
		private BusinessLogicLayer _businessLogicLayer;
		private readonly IngredientController _ingredientController;
		private List<Ingrediente> _ingredientes;

		public FormIngredientDetails()
		{
			InitializeComponent();
			_businessLogicLayer = new();
			_ingredientController = IngredientController.GetInstance();
			_ingredientes = new();
		}

		#region EVENTS

		private void BtnCreateIngredient_Click(object sender, EventArgs e)
		{
			GuardarIngrediente();
		}

		private void CmbTipoIngrediente_SelectedIndexChanged(object sender, EventArgs e)
		{
			CleanFields();
			ActualizarGrilla();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void FormIngredientDetails_Load(object sender, EventArgs e)
		{
			cmbTipoIngrediente.DataSource = Enum.GetNames(typeof(Enums.TipoIngrediente));
			tipoIngrediente = cmbTipoIngrediente.SelectedItem.ToString();
			CargarGrilla();
		}
		private void dgvFormIngredienteDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvFormIngredienteDetails.Rows[e.RowIndex].Cells[e.ColumnIndex];
			if (cell.Value.ToString() == "Edit")
			{
				int Id = int.Parse(dgvFormIngredienteDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
				string Nombre = dgvFormIngredienteDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
				double Precio = double.Parse(dgvFormIngredienteDetails.Rows[e.RowIndex].Cells[2].Value.ToString());

				Ingrediente ingrediente = (Ingrediente)_ingredientController.Create(
						tipoIngrediente, Nombre, Precio, Id);

				// Una cagada este metodo porque si mañana quisiera agregar una columna me tengo que acordar de modificar aca

				LoadIngred(ingrediente);
			}
			else if (cell.Value.ToString() == "Delete")
			{
				int Id = int.Parse(dgvFormIngredienteDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
				DeleteIngred(Id);
				ActualizarGrilla();
			}
		}

		#endregion

		#region PRIVATE METHODS
		private void GuardarIngrediente()
		{
			Ingrediente creacion = (Ingrediente)_ingredientController.Create(
				tipoIngrediente,
				txtIngredientName.Text,
				Convert.ToDouble(txtIngredientPrice.Text
				));
			creacion.Id = _ingrediente != null ? _ingrediente.Id : 0;

			CleanFields();
			_businessLogicLayer.SaveIngrediente(creacion, tipoIngrediente);
			ActualizarGrilla();
		}

		private void CleanFields()
		{
			txtIngredientName.Text = String.Empty;
			txtIngredientPrice.Text = String.Empty;
		}

		private void CargarGrilla()
		{
			_ingredientes = _businessLogicLayer.GetIngredientes(tipoIngrediente);
			dgvFormIngredienteDetails.DataSource = _ingredientes;
		}

		private void ActualizarGrilla()
		{
			tipoIngrediente = cmbTipoIngrediente.SelectedItem.ToString();
			_ingredientes = _businessLogicLayer.GetIngredientes(tipoIngrediente);
			dgvFormIngredienteDetails.DataSource = _ingredientes;
		}

		#endregion

		#region PUBLIC METHODS
		public void LoadIngred(Ingrediente ingrediente)
		{
			_ingrediente = ingrediente;

			if (ingrediente != null)
			{
				CleanFields();
				txtIngredientName.Text = ingrediente.Nombre;
				txtIngredientPrice.Text = ingrediente.Precio.ToString();
			}
		}

		public void DeleteIngred(int Id)
		{
			_businessLogicLayer.DeleteIngredient(Id, tipoIngrediente);
		}

		#endregion






	}
}
