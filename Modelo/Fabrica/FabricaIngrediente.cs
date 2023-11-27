using Modelo.EntidadesProducto.Tacos;

namespace Modelo.Fabrica
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

		public static Ingrediente ObtenerCreacion(string pProducto, string nombre, float precio)
		{
			Ingrediente? producto = null;
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

		public static Ingrediente ObtenerCreacion(string pProducto, string nombre, float precio, int id)
		{
			Ingrediente? producto = null;
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
