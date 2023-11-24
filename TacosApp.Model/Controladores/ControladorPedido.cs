using TacosApp.Model.EntidadesProducto;

namespace Model.Controllers
{

	public class ControladorPedido
	{
		private Pedido _pedido;
		private List<Taco> _listaTacos;
		private List<Bebida> _listaBebidas;
		private static ControladorPedido _controladorPedido;
		private int contadorPedidos;

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
			int id = 0;
			_pedido = new(id, _listaTacos, _listaBebidas);
			// generar metodo para agregar un nuevo pedido
			// generar metodo para evaluar el input
			// manejo de excepciones

		}
	}
}
