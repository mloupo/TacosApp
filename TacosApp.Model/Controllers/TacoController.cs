using Model.Productos;

namespace Model.Controllers
{
	public class TacoController
	{
		// List<Taco> _listaTacos = new();


		public Taco Create(int id, List<Ingrediente> lista)
		{
			Taco taco = new(id, lista);
			return taco;
		}

		public Taco Create(int id)
		{
			Taco taco = new(id);
			return taco;
		}

		public IEnumerable<Ingrediente> GetTacoIngredients(Taco taco)
		{
			return taco.GetIngredientes();
		}
	}
}
