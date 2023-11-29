using Modelo;
using Modelo.EntidadesProducto.Bebidas;
using Modelo.EntidadesProducto.Tacos;

namespace Model.Controllers
{

	public class ControladorPedido
	{
		private Pedido _pedido;
		private List<Taco> _listaTacos;
		private List<Bebida> _listaBebidas;
		private static ControladorPedido? _controladorPedido;
		private static int contadorPedidos = 0;

		private ControladorPedido()
		{
			_listaTacos = new List<Taco>();
			_listaBebidas = new List<Bebida>();
		}

		public static ControladorPedido ObtenerInstancia()
		{
			if (_controladorPedido == null)
			{
				_controladorPedido = new ControladorPedido();
			}
			return _controladorPedido;
		}

		public Pedido CrearNuevoPedido(List<Taco> listaTacos, List<Bebida> listaBebidas)
		{
			contadorPedidos += 1;
			_listaTacos = listaTacos;
			_listaBebidas = listaBebidas;
			_pedido = new(contadorPedidos, _listaTacos, _listaBebidas);

			Console.WriteLine($"Este es el pedido numero: {contadorPedidos}");

			return _pedido;
		}

		public bool AgregarTacoAPedido(Pedido pedido, Taco taco)
		{
			if (EsPedidoValido(pedido) && EsTacoValido(taco))
			{
				pedido.AgregarTaco(taco);
				return true;
			}
			return false;
		}

		public bool AgregarBebidaAPedido(Bebida bebida)
		{

			if (EsPedidoValido(_pedido))
			{
				_pedido.AgregarBebida(bebida);
				return true;
			}
			return false;
		}

		public void AgregarInfoContactoAPedido(Pedido pedido, string datosCliente, string nroContacto, DateTime fechaEntrega)
		{
			// Lógica para agregar información de contacto al pedido
		}

		private bool EsPedidoValido(Pedido pedido)
		{
			if (pedido == null)
			{
				Console.WriteLine("El pedido es nulo.");
				return false;
			}
			return true;
		}

		private bool EsTacoValido(Taco taco)
		{
			if (taco == null)
			{
				Console.WriteLine("El taco es nulo.");
				return false;
			}
			return true;
		}
	}
}
