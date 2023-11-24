using Model.Interfaces;

namespace TacosApp.Model.EntidadesProducto
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

		public string DatosBebida()
		{
			throw new NotImplementedException();
		}

		public float ObtenerPrecio()
		{
			throw new NotImplementedException();
		}

		public void ObtenerPrecioConsola()
		{
			throw new NotImplementedException();
		}
	}
}
