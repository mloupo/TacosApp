using Model.Factory;
using Model.Interfaces;

namespace Model.Controllers
{
	public class ControladorIngrediente
	{
		private static ControladorIngrediente? _controladorIngrediente;


		public static ControladorIngrediente ObtenerInstancia()
		{
			if (_controladorIngrediente == null)
			{
				_controladorIngrediente = new();
			}

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
			Console.WriteLine(creacion.ToString());
			return creacion;
		}
	}
}
