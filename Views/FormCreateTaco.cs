using Model;
using Model.Controllers;
using Model.Interfaces;
using Model.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FormCreateTaco : Form
    {
        private readonly List<Ingrediente> listaTortillas = new();
        private readonly List<Ingrediente> listaSalsas = new();
        private readonly List<Ingrediente> listaRellenos = new();
        private readonly List<Ingrediente> allIngredientList = new();
        private readonly List<Taco> listaTacos = new List<Taco>();
        private readonly BindingList<Ingrediente> listaIngredientesTaco = new();

        public FormCreateTaco()
        {
            InitializeComponent();
            cmbTipoIngrediente.DataSource = Enum.GetNames(typeof(Enums.TipoIngrediente));

            OrdenarIngredientesBD(allIngredientList);
            CargarIngredientesCmb();
        }

/*		private void btnCreateTaco_Click(object sender, EventArgs e)
		{
			if (!listaIngredientesTaco.Any())
			{
				MessageBox.Show("Primero debe agregar ingredientes al taco.");
				return;
			}

			var taco = new Taco();
			foreach (var ingrediente in listaIngredientesTaco)
			{
				taco.AddIngrediente(ingrediente);
			}
			listaTacos.Add(taco);
			ActualizarListaTacos(listaTacos);
			// Fixed a mistake in the code block before to call the CalcularValorTacos() method
			CalcularValorTacos(listaTacos);
		}*/

		private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            if (cmbIngrediente.SelectedIndex >= 0) {
                listaIngredientesTaco.Add(cmbIngrediente.SelectedItem as Ingrediente);
            } else {
                MessageBox.Show("Debe seleccionar un ingrediente.");
            }
        }

        private void cmbTipoIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarIngredientesCmb();
        }

        private void CargarIngredientesCmb()
        {
            switch (cmbTipoIngrediente.Text)
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
            cmbIngrediente.SelectedIndex = -1;
        }

        private void CargarIngredientesTaco(List<Ingrediente> list)
        {
            dgvTacoDetails.DataSource = list;
        }


        private void OrdenarIngredientesBD(List<Ingrediente> allIngredientList)
        {
            listaSalsas.Clear();
            listaTortillas.Clear();
            listaRellenos.Clear();

            if (allIngredientList.Any()) {
                foreach (var ingrediente in allIngredientList)
                {
                    switch (ingrediente.GetType().Name)
                    {
                        case nameof(Salsa):
                            listaSalsas.Add(ingrediente);
                            break;
                        case nameof(Relleno):
                            listaRellenos.Add(ingrediente);
                            break;
                        case nameof(Tortilla):
                            listaTortillas.Add(ingrediente);
                            break;
                    }
                }
            }
        }

        private void ActualizarListaTacos(List<Taco> listaTacos)
        {
            dgvTacoDetails.DataSource = null;
            dgvTacoDetails.DataSource = listaTacos;
            dgvTacoDetails.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

      /*  private void CalcularValorTacos(List<Taco> tacos)
        {
            var precios = tacos.Select(x => x.GetPrecio).ToArray();
            if (precios.Any()) {
                var valorMayor = precios.Max();
                var valorMenor = precios.Min();
                var promedio = precios.Average();

                txtMayorValorTaco.Text = $"${valorMayor:0.00}";
                txtMenorValorTaco.Text = $"${valorMenor:0.00}";
                txtPromedioValorTaco.Text = $"${promedio:0.00}";
            }
        }*/
    }
}