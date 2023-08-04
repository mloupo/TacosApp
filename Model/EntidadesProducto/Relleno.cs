namespace Model.Productos
{
	public class Relleno : Ingrediente
	{
		public Relleno() { }

		public Relleno(string name, decimal precio)
		{
			Nombre = name;
			Precio = precio;
		}

		public Relleno(string name, decimal precio, int id)
		{
			Nombre = name;
			Precio = precio;
			Id = id;
		}
	}
}
