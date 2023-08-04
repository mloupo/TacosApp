using Model.Interfaces;

namespace Model.Productos
{
	public class Taco : ITaco
	{
		public int Id { get; private set; }
		private readonly IEnumerable<Ingrediente> _ingredientesTaco;
		public readonly DateTime CreatedAt;

		public Taco(int id)
		{ 
			CreatedAt = DateTime.Now;
			Id = id;
		}

		public Taco(int id, IEnumerable<Ingrediente> lista)
		{
			Id = id;
			CreatedAt = DateTime.Now;
			_ingredientesTaco = lista;
		}

		public decimal GetPrecio()
		{
			decimal precioTaco = 0;
			foreach (var ingred in _ingredientesTaco)
			{
				precioTaco += ingred.Precio;
			}
			return precioTaco;
		}

		public void PrecioToString()
		{
			decimal precioTaco = GetPrecio();
			Console.WriteLine(string.Format("\nTotal a Pagar: {0,40:C}", precioTaco));
		}

		public void ShowIngredientes()
		{
			foreach (var ingrediente in _ingredientesTaco)
			{
				Console.WriteLine(ingrediente.ToString());
			}
		}

		public IEnumerable<Ingrediente> GetIngredientes()
		{
			return _ingredientesTaco;
		}

		public void Info()
		{
			Console.WriteLine($"\nTaco Nro: {Id}");
			Console.WriteLine($"Creado: {CreatedAt,50:D}");
			ShowIngredientes();
			PrecioToString();
		}
	}
}
