using Modelo.EntidadesProducto.Bebidas;
using Modelo.EntidadesProducto.Tacos;
using Modelo.Interfaces;
namespace Modelo
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


		public void AgregarTaco(Taco taco)
		{
			if (taco != null)
			{
				_listaTacos.Add(taco);
				Console.WriteLine($"Taco agregado al pedido #{Id}: {taco}");
			}
			else
			{
				Console.WriteLine("No se puede agregar un taco nulo al pedido.");
			}
		}
		public void AgregarBebida(Bebida bebida)
		{
			if (bebida != null)
			{
				_listaBebidas.Add(bebida);
				Console.WriteLine($"Bebida agregada al pedido #{Id}: {bebida}");
			}
			else
			{
				Console.WriteLine("No se puede agregar una bebida nula al pedido.");
			}
		}


		public float ObtenerImporteTacos()
		{
			foreach (Taco taco in _listaTacos)
			{
				Importe += taco.ObtenerPrecio();
			}
			return Importe;
		}
		public float ObtenerImporteBebidas()
		{
			foreach (Bebida bebida in _listaBebidas)
			{
				Importe += bebida.Precio;
			}
			return Importe;
		}
		public float ObtenerImporteTotal()
		{
			Importe = ObtenerImporteTacos() + ObtenerImporteBebidas();
			return Importe;
		}


		public void ConfirmarPedido()
		{
			Importe = ObtenerImporteTotal();
		}

		public override string ToString()
		{
			return $"Pedido #{Id} - Importe: ${Importe:0.00}";
		}
	}
}
