namespace Model.Productos
{
	public class Relleno : Ingrediente
	{
		public Relleno() { }

		public Relleno(string nombre, float precio)
		{
			CantidadMaxima = 5;
			Nombre = nombre;
			Precio = precio;
		}

		public Relleno(string nombre, float precio, int id)
		{
			CantidadMaxima = 5;
			Nombre = nombre;
			Precio = precio;
			Id = id;
		}
	}
}
