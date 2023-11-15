using Model.Interfaces;

namespace Model.Productos
{
	public class Taco : ITaco
	{
		public int Id { get; private set; }
		private List<IIngrediente>? _ingredientesTaco;
		public readonly DateTime CreadoEn;

		public Taco() { }

		public Taco(int id)
		{
			CreadoEn = DateTime.Now;
			Id = id;
		}

		public Taco(int id, IEnumerable<IIngrediente> lista)
		{
			Id = id;
			CreadoEn = DateTime.Now;
			_ingredientesTaco = new List<IIngrediente>(lista);
		}
		public Taco(IEnumerable<IIngrediente> lista)
		{
			CreadoEn = DateTime.Now;
			_ingredientesTaco = new List<IIngrediente>(lista);
		}

		public float ObtenerPrecio()
		{
			float precioTaco = 0;
			foreach (Ingrediente ingred in _ingredientesTaco)
			{
				precioTaco += ingred.Precio;
			}
			return precioTaco;
		}

		public void PrecioToString()
		{
			float precioTaco = ObtenerPrecio();
			Console.WriteLine(string.Format("\nTotal a Pagar: {0,40:C}", precioTaco));
		}

		public void MostrarIngredientes()
		{
			foreach (Ingrediente ingrediente in _ingredientesTaco)
			{
				Console.WriteLine(ingrediente.ToString());
			}
		}

		public IEnumerable<IIngrediente> ObtenerIngredientes()
		{
			return _ingredientesTaco;
		}

		public void Info()
		{
			Console.WriteLine($"\nTaco Nro: {Id}");
			Console.WriteLine($"Creado: {CreadoEn,50:D}");
			MostrarIngredientes();
			PrecioToString();
		}


		/*		public void AddIngrediente(Ingrediente ingrediente)
				{
					if (_ingredientesTaco == null)
					{
						_ingredientesTaco = new List<Ingrediente>();
					}

					var ingredientesCount = _ingredientesTaco.Count(i => i.GetType().Name == ingrediente.GetType().Name);

					if (ingredientesCount >= ingrediente.CantidadMaxima)
						throw new Exception($"No se puede agregar más de {ingrediente.CantidadMaxima} elementos del tipo {ingrediente.GetType().Name}");

					if (_ingredientesTaco.Any(i => i.Id == ingrediente.Id))
						throw new Exception($"Ya existe un elemento del tipo {ingrediente.Nombre}");

					_ingredientesTaco.Add(ingrediente);
				}

		*/
	}
}
