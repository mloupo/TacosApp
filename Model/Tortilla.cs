namespace Model
{
	internal class Tortilla : Ingrediente
	{
		public Tortilla() { }

		public Tortilla(string name, double precio)
		{
			Nombre = name;
			Precio = precio;			
		}

		public Tortilla(string name, double precio, int id)
		{
			Nombre = name;
			Precio = precio;
			Id = id;
		}		
	}
}
