namespace SolidServices
{
	public class Alcohol : IBebida
	{
		public string? Nombre { get; set; }
		public decimal Precio { get; set; }
		public decimal Cantidad { get; set; }
		public decimal Promo { get; set; }
		public decimal ObtenerPrecio()
		{
			return (Precio * Cantidad) - Promo;
		}
	}
}
