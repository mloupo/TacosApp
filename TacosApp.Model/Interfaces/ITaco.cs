namespace Model.Interfaces
{
	public interface ITaco
	{
		public float ObtenerPrecio();
		public void PrecioConsola();
		public void MostrarIngredientes();
		public IEnumerable<IIngrediente> ObtenerIngredientes();
		public void InfoConsola();

	}
}
