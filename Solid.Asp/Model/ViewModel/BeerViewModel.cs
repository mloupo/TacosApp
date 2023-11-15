namespace Solid.Asp.Model.ViewModel
{
	public class BeerViewModel
	{
		public string Name { get; set; }
		public string Brewery { get; set; }
		public string Country { get; set; }
		public double Alcohol { get; set; }
		public double Price { get; set; }
		public int Stock { get; set; }
		public int Sold { get; set; }
		public int Rating { get; set; }
		public string Comments { get; set; }
		public object Brand { get; set; }

		public string GetInfo() => Name + " " + Brand;
	}
}
