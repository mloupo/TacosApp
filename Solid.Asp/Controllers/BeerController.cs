using Microsoft.AspNetCore.Mvc;
using Solid.Asp.Model.ViewModel;
using Solid.Asp.Service;

namespace Solid.Asp.Controllers
{
	public class BeerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Add(BeerViewModel beer)
		{
			if (!ModelState.IsValid)
			{
				return View(beer);
			}
			var beerService = new BeerService();
			beerService.Create(beer);

			return Ok();
		}
	}
}
