namespace Model.Productos
{
	public class Tortilla : Ingrediente
	{
		public Tortilla() { }

		public Tortilla(string nombre, float precio)
		{
			CantidadMaxima = 2;
			Nombre = nombre;
			Precio = precio;
		}

		public Tortilla(string nombre, float precio, int id)
		{
			CantidadMaxima = 2;
			Nombre = nombre;
			Precio = precio;
			Id = id;
		}
	}
}
