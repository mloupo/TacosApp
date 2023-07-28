namespace Model.Productos
{
	public class Relleno : Ingrediente
	{
		public Relleno() { }

		public Relleno(string name, double precio)
		{
			Nombre = name;
			Precio = precio;
		}

		public Relleno(string name, double precio, int id)
		{
			Nombre = name;
			Precio = precio;
			Id = id;
		}
	}
}
