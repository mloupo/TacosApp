namespace SolidServices.Interfaces.Crud
{
	public interface IAccionesEditables<T>
	{
		public void Agregar(T entidad);
		public void Actualizar(T entidad);
		public void Eliminar(T entidad);
	}
}
