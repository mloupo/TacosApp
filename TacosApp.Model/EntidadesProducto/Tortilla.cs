namespace Model.Productos
{
	public class Tortilla : Ingrediente
	{
		public Tortilla() { }

		public Tortilla(string name, decimal precio)
		{
			CantidadMaxima = 2;
			Nombre = name;
			Precio = precio;
		}

		public Tortilla(string name, decimal precio, int id)
		{
			CantidadMaxima = 2;
			Nombre = name;
			Precio = precio;
			Id = id;
		}
	}
}
