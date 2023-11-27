namespace Modelo.EntidadesProducto.Bebidas
{
	public class Gaseosa : Bebida
	{
		public Gaseosa(string nombre, float precio)
		{
			Nombre = nombre;
			Precio = precio;
		}

		public Gaseosa(string nombre, float precio, int id) : this(nombre, precio)
		{
			Id = id;
		}

		public int Id { get; }
	}
}
