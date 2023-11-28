using Modelo.EntidadesProducto.Bebidas;
using Modelo.Fabrica;

namespace Modelo.Controladores
{
	public class ControladorBebida
	{
		private static ControladorBebida? _controladorBebida;


		public static ControladorBebida ObtenerInstancia()
		{
			if (_controladorBebida == null)
			{
				_controladorBebida = new();
			}
			return _controladorBebida;
		}

		public Bebida Crear(string pBebida, string nombre, float precio)
		{
			Bebida creacion = FabricaBebida.ObtenerCreacion(pBebida, nombre, precio);
			Console.WriteLine(creacion.ToString());
			return creacion;
		}

		public Bebida Crear(string pBebida, string nombre, float precio, int Id)
		{
			Bebida creacion = FabricaBebida.ObtenerCreacion(pBebida, nombre, precio, Id);
			Console.WriteLine(creacion.ToString());
			return creacion;
		}
	}
}
