using Model.Interfaces;

namespace Model.Controllers
{
    public class TacoController
	{
		// List<Taco> _listaTacos = new();


		public Taco Create(List<IIngrediente> lista)
		{
			Taco taco = new(lista);
			return taco;
		}

		public List<IIngrediente> GetTacoIngredients(Taco taco)
		{
			return taco.GetIngredientes();
		}
	}
}
