using Model.Factory;
using Model.Interfaces;

namespace Model.Controllers
{
	public class ControladorIngrediente
	{
		private static ControladorIngrediente? _controladorIngrediente;

		private FabricaIngrediente _fabrica;

		private ControladorIngrediente()
		{
			_fabrica = FabricaIngrediente.ObtenerInstancia();
		}

		public static ControladorIngrediente ObtenerInstancia()
		{
			_controladorIngrediente ??= new ControladorIngrediente();
			return _controladorIngrediente;
		}

		public IIngrediente Crear(string pIngrediente, string nombre, float precio)
		{
			IIngrediente creacion = FabricaIngrediente.ObtenerCreacion(pIngrediente, nombre, precio);
			Console.WriteLine(creacion.ToString());
			return creacion;
		}

		public IIngrediente Crear(string pIngrediente, string nombre, float precio, int Id)
		{
			IIngrediente creacion = FabricaIngrediente.ObtenerCreacion(pIngrediente, nombre, precio, Id);
			return creacion;
		}
	}
}
