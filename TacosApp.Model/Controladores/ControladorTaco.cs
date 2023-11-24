using Model.Interfaces;
using TacosApp.Model.EntidadesProducto;

namespace Model.Controllers
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

		public Taco Crear(int id, List<IIngrediente> lista)
		{
			Taco taco = new(id, lista);
			return taco;
		}

		public Taco Crear(int id)
		{
			Taco taco = new(id);
			return taco;
		}

		public Taco Crear(List<IIngrediente> lista)
		{
			Taco taco = new(lista);
			return taco;
		}

		public IEnumerable<IIngrediente> GetTacoIngredients(Taco taco)
		{
			return taco.ObtenerIngredientes();
		}
	}
}
