using Model.EntidadesUsuario;
using Model.Interfaces;
using Model.Productos;

namespace Service
{
	public class CapaLogicaNegocio
	{
		private CapaAccesoDatos _capaAccesoDatos;

		public CapaLogicaNegocio()
		{
			_capaAccesoDatos = new();
		}

		#region ingredientes
		public IIngrediente AlmacenarIngrediente(Ingrediente ingrediente, string tipoIngrediente)
		{
			if (ingrediente.Id == 0)
				_capaAccesoDatos.InsertarIngrediente(ingrediente, tipoIngrediente);
			else
				_capaAccesoDatos.ActualizarIngrediente(ingrediente, tipoIngrediente);

			return ingrediente;
		}

		public List<Ingrediente> ObtenerIngredientes(string tipoIngrediente)
		{
			return _capaAccesoDatos.ObtenerIngredientes(tipoIngrediente);
		}

		public void EliminarIngrediente(int id, string tipoIngrediente)
		{
			_capaAccesoDatos.EliminarIngrediente(id, tipoIngrediente);
		}

		#endregion

		#region contactos
		public Contacto AgregarContacto(Contacto contacto)
		{
			if (contacto.Id == 0)
				_capaAccesoDatos.InsertarContacto(contacto);
			else
				_capaAccesoDatos.ActualizarContacto(contacto);
			return contacto;
		}

		public List<Contacto> ObtenerContactos(string textoObjetivo = null)
		{
			return _capaAccesoDatos.ObtenerContactos();
		}

		public void EliminarContacto(int idContacto)
		{
			_capaAccesoDatos.EliminarContacto(idContacto);
		}

		#endregion
	}
}
