using Model.Factory;
using Model.Interfaces;

namespace Model.Controllers
{
    /// <summary>
    /// Controller class for managing ingredients.
    /// </summary>
    public class IngredientController
	{		
		private static IngredientController? _ingredientController;

		private IngredientFactory _factory;

		private IngredientController()
		{
			_factory = IngredientFactory.GetInstance();
		}

		/// <summary>
		/// Gets the singleton instance of the IngredientController.
		/// </summary>
		/// <returns>The IngredientController instance.</returns>
		public static IngredientController GetInstance()
		{
			_ingredientController ??= new IngredientController();
			return _ingredientController;
		}

		/// <summary>
		/// Creates a new ingredient with the given name and price.
		/// </summary>
		/// <param name="pIngrediente">The type of ingredient to create.</param>
		/// <param name="nombre">The name of the ingredient.</param>
		/// <param name="precio">The price of the ingredient.</param>
		/// <returns>The newly created ingredient.</returns>
		public IIngrediente Create(string pIngrediente, string nombre, decimal precio)
		{
			IIngrediente creacion = IngredientFactory.GetCreation(pIngrediente, nombre, precio);
			Console.WriteLine(creacion.ToString());
			return creacion;
		}

		/// <summary>
		/// Creates a new ingredient with the given name, price and ID.
		/// </summary>
		/// <param name="pIngrediente">The type of ingredient to create.</param>
		/// <param name="nombre">The name of the ingredient.</param>
		/// <param name="precio">The price of the ingredient.</param>
		/// <param name="Id">The ID of the ingredient.</param>
		/// <returns>The newly created ingredient.</returns>
		public IIngrediente Create(string pIngrediente, string nombre, decimal precio, int Id)
		{
			IIngrediente creacion = IngredientFactory.GetCreation(pIngrediente, nombre, precio, Id);
			return creacion;
		}		
	}
}
