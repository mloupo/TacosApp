namespace SolidServices
{
	public class Agua : IBebida

	{
		public string? Nombre { get; set; }
		public decimal Precio { get; set; }
		public decimal Cantidad { get; set; }

		public decimal ObtenerPrecio()
		{
			return Precio * Cantidad;
		}
	}
}
