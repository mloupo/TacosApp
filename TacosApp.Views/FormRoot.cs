using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
	public partial class FormRoot : Form
	{
		public FormRoot()
		{
			InitializeComponent();
		}

		#region EVENTS

		private void BtnManageIngredient_Click(object sender, EventArgs e)
		{
			Helpers.AbrirFormularioHijo(OpenManageIngredientForm(), RootPanel);
		}


		private void BtnCreateOrder_Click(object sender, EventArgs e)
		{
			Helpers.AbrirFormularioHijo(OpenCreateTacoForm(), RootPanel);

		}

		private void BtnMostrarPedido_Click(object sender, EventArgs e)
		{
			Helpers.AbrirFormularioHijo(OpenShowOrderForm(), RootPanel);
		}



		#endregion

		#region PRIVATE METHODS

		private Form OpenCreateTacoForm()
		{
			FormCreateTaco frmTaco = new();
			return frmTaco;
		}

		private Form OpenManageIngredientForm()
		{
			FormIngredient frmIngredient = new();
			return frmIngredient;

		}

		private Form OpenShowOrderForm()
		{
			FormShowOrders frmOrder = new();
			return frmOrder;
		}

		#endregion



	}
}
