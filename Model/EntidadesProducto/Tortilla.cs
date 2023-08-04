namespace Model.Productos
{
	public class Tortilla : Ingrediente
	{
		public Tortilla() { }

		public Tortilla(string name, decimal precio)
		{
			Nombre = name;
			Precio = precio;
		}

		public Tortilla(string name, decimal precio, int id)
		{
			Nombre = name;
			Precio = precio;
			Id = id;
		}
	}
}
