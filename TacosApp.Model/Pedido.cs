using Model.Interfaces;
namespace Model
{
	public class Pedido : IPedido
	{
		private readonly List<ITaco> _listaTacos;
		private readonly List<IBebida> _listaBebidas;
		public float Importe { get; set; }

		public int Id { get; set; }
		public readonly DateTime CreadoEn;
		public readonly DateTime EntregadEn;

		public Pedido(int id, List<ITaco> listaTacos, List<IBebida> listaBebidas)
		{
			Id = id;
			CreadoEn = DateTime.Now;
			_listaTacos = listaTacos;
			_listaBebidas = listaBebidas;
		}

		public void ConfirmarPedido()
		{
			Importe = ObtenerImporteTotal();
		}

		private float ObtenerImporteTotal()
		{
			Importe = ObtenerImporteTacos() + ObtenerImporteBebidas();
			return Importe;
		}

		private float ObtenerImporteTacos()
		{
			foreach (ITaco taco in _listaTacos)
			{
				Importe += taco.ObtenerPrecio();
			}
			return Importe;
		}

		private float ObtenerImporteBebidas()
		{
			foreach (IBebida bebida in _listaBebidas)
			{
				Importe += bebida.ObtenerPrecio();
			}
			return Importe;
		}
	}
}
