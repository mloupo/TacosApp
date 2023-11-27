using Modelo.Interfaces;

namespace Modelo.EntidadesProducto.Bebidas
{
	public class Cerveza : Bebida, IBebida
	{
		public string? Cerveceria { get; set; }
		public string? Pais { get; set; }
		public float Alcohol { get; set; }

		// public int Vendido { get; set; }
		public int Clasificacion { get; set; }

		// public string Comentarios { get; set; }
		public string? Marca { get; set; }
		public int Id { get; }

		public Cerveza()
		{

		}

		public Cerveza(string nombre, float precio)
		{
			Nombre = nombre;
			Precio = precio;
		}

		public Cerveza(string nombre, float precio, int id) : this(nombre, precio)
		{
			Id = id;
		}
	}
}
