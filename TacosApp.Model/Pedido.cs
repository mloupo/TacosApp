using Model.Interfaces;
using Model.Productos;

namespace Model
{
	public class Pedido : IPedido
	{
		private readonly List<Taco> _listaTacos;
		public float Importe { get; set; }

		public int Id { get; set; }
		public readonly DateTime CreadoEn;
		public readonly DateTime EntregadEn;

		public Pedido(int id, List<Taco> lista)
		{
			Id = id;
			CreadoEn = DateTime.Now;
			_listaTacos = lista;
			Importe = ObtenerImporteTotal();
		}

		public void ConfirmarPedido()
		{

		}

		private float ObtenerImporteTotal()
		{
			foreach (Taco taco in _listaTacos)
			{
				Importe += taco.ObtenerPrecio();
			}
			return Importe;
		}
	}
}
