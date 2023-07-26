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
			OpenManageIngredientForm();
		}

		private void BtnCreateTaco_Click(object sender, EventArgs e)
		{
			OpenCreateTacoForm();
		}

		#endregion

		#region PRIVATE METHODS

		private void OpenCreateTacoForm()
		{
			FormCreateTaco frmTaco = new();
			frmTaco.ShowDialog();
		}

		private void OpenManageIngredientForm()
		{
			FormIngredient frmIngredient = new();
			frmIngredient.ShowDialog();
		}

		#endregion
	}
}
