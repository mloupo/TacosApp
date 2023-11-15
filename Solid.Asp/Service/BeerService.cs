using Solid.Asp.Db;
using Solid.Asp.Model.ViewModel;
using Solid.Asp.Utils;

namespace Solid.Asp.Service
{
	public class BeerService
	{
		public void Create(BeerViewModel beer)
		{
			var beerDB = new BeerDB();
			var log = new Log();
			beerDB.Save(beer);
			log.Save("Se guardo en DB" + beer.GetInfo());
		}
	}
}
