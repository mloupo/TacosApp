namespace Model.Interfaces
{
	public interface ITaco
	{
		public float ObtenerPrecio();
		public void PrecioToString();
		public void MostrarIngredientes();
		public IEnumerable<IIngrediente> ObtenerIngredientes();
		public void Info();

	}
}
