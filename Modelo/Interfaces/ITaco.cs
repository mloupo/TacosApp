using Modelo.EntidadesProducto.Tacos;

namespace Modelo.Interfaces
{
	public interface ITaco
	{
		public float ObtenerPrecio();
		public void PrecioConsola();
		public void MostrarIngredientes();
		public List<Ingrediente> ObtenerIngredientes();
		public void InfoConsola();

	}
}
