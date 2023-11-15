using Model.Interfaces;
using Model.Productos;

namespace Model.Controllers
{
	public class ControladorTaco
	{
		// List<Taco> _listaTacos = new();


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
