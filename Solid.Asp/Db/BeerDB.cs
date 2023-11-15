using Solid.Asp.Model.ViewModel;

namespace Solid.Asp.Db
{
	public class BeerDB
	{
		public void Save(BeerViewModel beer)
		{
			Console.WriteLine("Guardado en DB" + beer.Name);
		}
	}
}
