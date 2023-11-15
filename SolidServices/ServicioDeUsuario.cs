using SolidServices.Interfaces.Crud;

namespace SolidServices
{
	public class ServicioDeUsuario : IAccionesBasicas<Usuario>, IAccionesEditables<Usuario>
	{
		public Usuario Obtener(int id)
		{
			Console.WriteLine("Usuario obtenido");
			return new Usuario();
		}

		public List<Usuario> ObtenerLista()
		{
			return new List<Usuario>();
		}

		public void Agregar(Usuario entidad)
		{
			Console.WriteLine("Usuario Creado");
		}

		public void Actualizar(Usuario entidad)
		{
			Console.WriteLine("Usuario Actualizado");
		}

		public void Eliminar(Usuario entidad)
		{
			Console.WriteLine("Usuario Eliminado");
		}
	}
}
