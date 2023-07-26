using Model.Interfaces;

namespace Model
{
    public class Taco : ITaco
	{
		private static int TotalTacos = 1;
		private readonly int myId;
		private readonly List<IIngrediente> IngredientesTaco = new();
		public readonly DateTime CreatedAt;
	
		public int MyId()
		{
			return myId;
		}

		public Taco() 
		{
		
		}
		public Taco(List<IIngrediente> lista)
		{
			CreatedAt = DateTime.Now;
			myId = TotalTacos;
			TotalTacos++;
			IngredientesTaco = lista;
		}

		public double GetPrecio()
		{
			double PrecioTaco = 0;
			foreach (Ingrediente Ingred in IngredientesTaco.Cast<Ingrediente>())
			{
				PrecioTaco += Ingred.Precio;
			}
			return PrecioTaco;
		}
		public void PrecioToString()
		{
			double PrecioTaco = 0;
			foreach (Ingrediente Ingred in IngredientesTaco.Cast<Ingrediente>())
			{
				PrecioTaco += Ingred.Precio;
			}
			Console.WriteLine($"\nTotal a Pagar: {PrecioTaco,40}");
		}


		public void ShowIngredientes()
		{
			foreach (IIngrediente Ingrediente in IngredientesTaco)
			{
				Console.WriteLine(Ingrediente.ToString());
			}
		}
		public List<IIngrediente> GetIngredientes()
		{
			return this.IngredientesTaco;
		}

		public void Info()
		{
			Console.WriteLine($"\nTaco Nro: {MyId()}");
			Console.WriteLine($"Creado: {CreatedAt,50:D}");
			ShowIngredientes();
			PrecioToString();
		}

	
	}
}
