using Modelo.EntidadesProducto.Bebidas;

namespace Modelo.Fabrica
{
	public class FabricaBebida
	{
		private static FabricaBebida? _instancia;
		private FabricaBebida() { }

		public static FabricaBebida ObtenerInstancia()
		{
			_instancia ??= new FabricaBebida();
			return _instancia;
		}

		public static Bebida ObtenerCreacion(string pProducto, string nombre, float precio)
		{
			Bebida? producto = null;
			switch (pProducto)
			{
				case "Agua":
					producto = new Agua(nombre, precio);
					break;

				case "Gaseosa":
					producto = new Gaseosa(nombre, precio);
					break;

				case "Cerveza":
					producto = new Cerveza(nombre, precio);
					break;
			}
			return producto;
		}

		public static Bebida ObtenerCreacion(string pProducto, string nombre, float precio, int id)
		{
			Bebida? producto = null;
			switch (pProducto)
			{
				case "Agua":
					producto = new Agua(nombre, precio, id);
					break;

				case "Gaseosa":
					producto = new Gaseosa(nombre, precio, id);
					break;

				case "Cerveza":
					producto = new Cerveza(nombre, precio, id);
					break;
			}
			return producto;
		}
	}
}