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

		public Pedido AgregarNuevoPedido(List<Taco> listaTacos, List<Bebida> listaBebidas)
		{
			contadorPedidos += 1;
			_listaTacos = listaTacos;
			_listaBebidas = listaBebidas;
			_pedido = new(contadorPedidos, _listaTacos, _listaBebidas);

			Console.WriteLine($"Este es el pedido numero: {contadorPedidos}");

			// generar metodo para agregar un nuevo pedido
			// generar metodo para evaluar el input
			// manejo de excepciones
			return _pedido;
		}

		public void AgregarIngredienteATaco(Taco taco, Ingrediente ingrediente)
		{
			// Lógica para agregar un ingrediente a un taco
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

		public void AgregarBebidaAPedido(Pedido pedido, Bebida bebida)
		{
			// Lógica para agregar una bebida al pedido
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
