using Model.Interfaces;
using Model.Productos;
using TacosApp.Model.EntidadesProducto;

namespace Model
{
	public class Pedido : IPedido
	{
		private readonly List<Taco> _listaTacos;
		private readonly List<Bebida> _listaBebidas;
		public float Importe { get; set; }

		public int Id { get; set; }
		public readonly DateTime CreadoEn;
		public readonly DateTime EntregadEn;

		public Pedido(int id, List<Taco> listaTacos, List<Bebida> listaBebidas)
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
			foreach (Taco taco in _listaTacos)
			{
				Importe += taco.ObtenerPrecio();
			}
			return Importe;
		}

		private float ObtenerImporteBebidas()
		{
			foreach (Bebida bebida in _listaBebidas)
			{
				Importe += bebida.ObtenerPrecio();
			}
			return Importe;
		}
	}
}
