using Modelo.EntidadesProducto.Tacos;

namespace Modelo.Controladores
{
	public class ControladorTaco
	{
		private static ControladorTaco? _controladorTaco;


		public static ControladorTaco ObtenerInstancia()
		{
			if (_controladorTaco == null)
			{
				_controladorTaco = new();
			}

			return _controladorTaco;
		}

		public Taco Crear(int id, List<Ingrediente> lista)
		{
			Taco taco = new(id, lista);
			return taco;
		}

		public Taco Crear(int id)
		{
			Taco taco = new(id);
			return taco;
		}

		public Taco Crear(List<Ingrediente> lista)
		{
			Taco taco = new(lista);
			return taco;
		}

		public IEnumerable<Ingrediente> GetTacoIngredients(Taco taco)
		{
			return taco.ObtenerIngredientes();
		}
	}
}
