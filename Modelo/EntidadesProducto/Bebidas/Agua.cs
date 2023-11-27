namespace Modelo.EntidadesProducto.Bebidas
{
	public class Agua : Bebida
	{
		public Agua(string nombre, float precio)
		{
			Nombre = nombre;
			Precio = precio;
		}

		public Agua(string nombre, float precio, int id) : this(nombre, precio)
		{
			Id = id;
		}

		public int Id { get; }
	}
}
