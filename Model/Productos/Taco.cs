using Model.Interfaces;

namespace Model.Productos
{
	public class Taco : ITaco
	{
		public int Id { get; set; }
		private readonly List<Ingrediente> IngredientesTaco = new();
		public readonly DateTime CreatedAt;


		public Taco(int id)
		{
			CreatedAt = DateTime.Now;
			Id = id;
		}

		public Taco(int id, List<Ingrediente> lista)
		{
			Id = id;
			CreatedAt = DateTime.Now;
			IngredientesTaco = lista;
		}

		public double GetPrecio()
		{
			double PrecioTaco = 0;
			foreach (Ingrediente Ingred in IngredientesTaco)
			{
				PrecioTaco += Ingred.Precio;
			}
			return PrecioTaco;
		}

		public void PrecioToString()
		{
			double PrecioTaco = 0;
			foreach (Ingrediente Ingred in IngredientesTaco)
			{
				PrecioTaco += Ingred.Precio;
			}
			Console.WriteLine($"\nTotal a Pagar: {PrecioTaco,40}");
		}


		public void ShowIngredientes()
		{
			foreach (Ingrediente Ingrediente in IngredientesTaco)
			{
				Console.WriteLine(Ingrediente.ToString());
			}
		}

		public List<Ingrediente> GetIngredientes()
		{
			return IngredientesTaco;
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
