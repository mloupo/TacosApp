using Modelo;
using Modelo.Interfaces;

namespace Model.Controllers
{

	public class ControladorPedido
	{
		private Pedido _pedido;
		private List<ITaco> _listaTacos;
		private List<IBebida> _listaBebidas;
		private static ControladorPedido _controladorPedido;
		private static int contadorPedidos = 0;

		private ControladorPedido()
		{
			// constructor code
		}

		public static ControladorPedido ObtenerInstancia()
		{
			if (_controladorPedido == null)
			{
				_controladorPedido = new ControladorPedido();
			}
			return _controladorPedido;
		}

		public void AgregarNuevoPedido()
		{
			contadorPedidos += 1;
			Console.WriteLine($"Este es el pedido numero: {contadorPedidos}");
			_pedido = new(contadorPedidos, _listaTacos, _listaBebidas);
			// generar metodo para agregar un nuevo pedido
			// generar metodo para evaluar el input
			// manejo de excepciones
		}
	}
}
