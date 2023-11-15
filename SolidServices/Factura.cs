namespace SolidServices
{
	public class Factura
	{
		public decimal ObtenerTotal(IEnumerable<IBebida> lstBebidas)
		{
			decimal total = 0;
			foreach (var bebida in lstBebidas)
			{
				total += bebida.ObtenerPrecio();
			}
			return total;
		}
	}
}
