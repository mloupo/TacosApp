using Model.Factory;
using Model.Interfaces;

namespace Model.Controllers
{
    public class IngredientController
	{		
		private static IngredientController? _ingredientController;

		private IngredientFactory _factory;

		private IngredientController()
		{
			_factory = IngredientFactory.GetInstance();
		}

		public static IngredientController GetInstance()
		{
			_ingredientController ??= new IngredientController();
			return _ingredientController;
		}


		public IIngrediente Create(string pIngrediente, string nombre, decimal precio)
		{
			IIngrediente creacion = IngredientFactory.GetCreation(pIngrediente, nombre, precio);
			Console.WriteLine(creacion.ToString());
			return creacion;
		}

		public IIngrediente Create(string pIngrediente, string nombre, decimal precio, int Id)
		{
			IIngrediente creacion = IngredientFactory.GetCreation(pIngrediente, nombre, precio, Id);
			return creacion;
		}

		
	}
}
