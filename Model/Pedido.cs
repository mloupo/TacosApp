using Model.Interfaces;
using Model.Productos;

namespace Model
{
	public class Pedido : IPedido
	{
		private readonly List<Taco> _listaTacos;
		public double Importe { get; set; }

		public int Id { get; set; }
		public readonly DateTime CreatedAt;
		public readonly DateTime DeliveredAt;

		public Pedido(int id, List<Taco> lista)
		{
			Id = id;
			CreatedAt = DateTime.Now;
			_listaTacos =lista ;
			Importe = GetImporteTotal();
		}

		public void ConfirmarPedido()
		{

		}

		private double GetImporteTotal()
		{
			foreach (Taco taco in _listaTacos)
			{
				Importe += taco.GetPrecio();
			}
			return Importe;
		}
	}
}
