namespace Model.Productos
{
	public partial class Salsa : Ingrediente
	{
		private int cantidadMaxima = 2;
		public Salsa() { }

		public Salsa(string name, float precio)
		{
			CantidadMaxima = cantidadMaxima;
			Nombre = name;
			Precio = precio;
		}

		public Salsa(string name, float precio, int id)
		{
			CantidadMaxima = cantidadMaxima;
			Nombre = name;
			Precio = precio;
			Id = id;
		}
	}
}
