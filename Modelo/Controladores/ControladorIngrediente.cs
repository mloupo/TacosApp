using Modelo.EntidadesProducto.Tacos;
using Modelo.Fabrica;

namespace Modelo.Controladores
{
	public class ControladorIngrediente
	{
		private static ControladorIngrediente? _controladorIngrediente;


		public static ControladorIngrediente ObtenerInstancia()
		{
			if (_controladorIngrediente == null)
			{
				_controladorIngrediente = new();
			}

			return _controladorIngrediente;
		}

		public Ingrediente Crear(string pIngrediente, string nombre, float precio)
		{
			Ingrediente creacion = FabricaIngrediente.ObtenerCreacion(pIngrediente, nombre, precio);
			Console.WriteLine(creacion.ToString());
			return creacion;
		}

		public Ingrediente Crear(string pIngrediente, string nombre, float precio, int Id)
		{
			Ingrediente creacion = FabricaIngrediente.ObtenerCreacion(pIngrediente, nombre, precio, Id);
			Console.WriteLine(creacion.ToString());
			return creacion;
		}
	}
}
