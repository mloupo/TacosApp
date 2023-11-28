using Modelo.Interfaces;

namespace Modelo.EntidadesProducto.Bebidas
{
	public class Cerveza : Bebida, IBebida
	{
		public string? Marca { get; set; }
		public string? Cerveceria { get; set; }
		public string? Pais { get; set; }
		public float Alcohol { get; set; }

		// public int Vendido { get; set; }

		public int Clasificacion { get; set; }

		// public string Comentarios { get; set; }


		public Cerveza()
		{

		}

		public Cerveza(string nombre, float precio)
		{
			Nombre = nombre;
			Precio = precio;
		}

		public Cerveza(string nombre, float precio, int id)
		{
			Id = id;
			Nombre = nombre;
			Precio = precio;
		}
	}
}
