using Model.Interfaces;
using Model.Productos;

namespace Model.Factory
{
	public class FabricaIngrediente
	{
		private static FabricaIngrediente? _instancia;
		private FabricaIngrediente() { }

		public static FabricaIngrediente ObtenerInstancia()
		{
			_instancia ??= new FabricaIngrediente();
			return _instancia;
		}

		public static IIngrediente ObtenerCreacion(string pProducto, string nombre, float precio)
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

		public static IIngrediente ObtenerCreacion(string pProducto, string nombre, float precio, int id)
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
