using Model.Interfaces;
using Model.Productos;

namespace Model.Factory
{
    public class IngredientFactory
	{
		private static IngredientFactory?  _instance;
		private IngredientFactory() { }

		public static IngredientFactory GetInstance ()
			{
			_instance ??= new IngredientFactory();
				return _instance;
			}

		public static IIngrediente GetCreation(string pProducto, string nombre, double precio)
		{
			IIngrediente? producto = null;
			switch (pProducto)
			{
				case "Salsa":
					producto = new Salsa(nombre, precio);					
					break;

				case "Relleno":
					producto = new Relleno(nombre, precio);					
					break;

				case "Tortilla":
					producto = new Tortilla(nombre, precio);
					break;
			}
			return producto;
		}

		public static IIngrediente GetCreation(string pProducto, string nombre, double precio, int id)
		{
			IIngrediente? producto = null;
			switch (pProducto)
			{
				case "Salsa":
					producto = new Salsa(nombre, precio, id);
					break;

				case "Relleno":
					producto = new Relleno(nombre, precio, id);
					break;

				case "Tortilla":
					producto = new Tortilla(nombre, precio, id);
					break;
			}
			return producto;
		}

	}
}
