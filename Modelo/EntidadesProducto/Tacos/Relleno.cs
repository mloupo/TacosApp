namespace Modelo.EntidadesProducto.Tacos
{
	public class Relleno : Ingrediente
	{
		private int cantidadMaxima = 5;
		public Relleno() { }

		public Relleno(string nombre, float precio)
		{
			CantidadMaxima = cantidadMaxima;
			Nombre = nombre;
			Precio = precio;
		}

		public Relleno(string nombre, float precio, int id)
		{
			CantidadMaxima = cantidadMaxima;
			Nombre = nombre;
			Precio = precio;
			Id = id;
		}
	}
}
