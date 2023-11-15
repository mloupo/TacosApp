namespace Model.Productos
{
	public partial class Salsa : Ingrediente
	{
		public Salsa() { }

		public Salsa(string name, float precio)
		{
			CantidadMaxima = 1;
			Nombre = name;
			Precio = precio;
		}

		public Salsa(string name, float precio, int id)
		{
			Nombre = name;
			Precio = precio;
			Id = id;
		}
	}
}
