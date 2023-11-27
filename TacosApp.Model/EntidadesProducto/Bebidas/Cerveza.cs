using Model.Interfaces;

namespace TacosApp.Model.EntidadesProducto.Bebidas
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
	}
}
