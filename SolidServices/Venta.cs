namespace SolidServices
{
	public class Venta : VentaConImpuestos
	{
		public Venta(decimal importe, string consumidor, decimal impuestos)
		{
			this.importe = importe;
			this.consumidor = consumidor;
			this.impuestos = impuestos;
		}

		public override void Generar()
		{
			Console.WriteLine("Venta Generada!");
		}
	}
}
