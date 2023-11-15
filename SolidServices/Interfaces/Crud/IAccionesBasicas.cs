namespace SolidServices.Interfaces.Crud
{
	public interface IAccionesBasicas<T>
	{
		public T Obtener(int id);
		public List<T> ObtenerLista();
	}
}
