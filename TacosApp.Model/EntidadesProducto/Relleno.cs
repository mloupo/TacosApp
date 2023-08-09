namespace Model.Productos
{
	public class Relleno : Ingrediente
	{	
		public Relleno() { }

		public Relleno(string name, decimal precio)
		{
			CantidadMaxima = 5;	
			Nombre = name;
			Precio = precio;
		}

		public Relleno(string name, decimal precio, int id)
		{
			CantidadMaxima = 5;
			Nombre = name;
			Precio = precio;
			Id = id;
		}
	}
}
