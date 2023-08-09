using Model.Controllers;
using Model.Interfaces;
using Model.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Model
{
    public class BusinessLogicLayer
	{
		private DataAccessLayer _dataAccessLayer;

		public BusinessLogicLayer()
		{
			_dataAccessLayer = new();
		}

		public IIngrediente SaveIngrediente(Ingrediente ingrediente, string tipoIngrediente)
		{
			if (ingrediente.Id == 0)
				_dataAccessLayer.InsertIngrediente(ingrediente, tipoIngrediente);
			else
				_dataAccessLayer.UpdateIngrediente(ingrediente, tipoIngrediente);

			return ingrediente;
		}

		public List<Ingrediente> GetIngredientes(string tipoIngrediente)
		{
			return _dataAccessLayer.GetIngredientes(tipoIngrediente);
		}

		public void DeleteIngredient(int id, string tipoIngrediente)
		{
			_dataAccessLayer.DeleteIngrediente(id, tipoIngrediente);
		}
	}
}
