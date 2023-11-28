using Modelo.EntidadesProducto.Bebidas;
using Modelo.EntidadesProducto.Tacos;
using Modelo.EntidadesUsuario;
using Modelo.Interfaces;
using Servicio.Datos;

namespace Servicio.Logica
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

		#region bebidas
		public List<Bebida> ObtenerBebidas(string tipoBebida)
		{
			return _capaAccesoDatos.ObtenerBebidas(tipoBebida);
		}

		public IBebida AlmacenarBebida(Bebida bebida, string tipoBebida)
		{
			if (bebida.Id == 0)
				_capaAccesoDatos.InsertarBebida(bebida, tipoBebida);
			else
				_capaAccesoDatos.ActualizarBebida(bebida, tipoBebida);

			return bebida;

		}

		public void EliminarBebida(int id, string tipoBebida)
		{
			_capaAccesoDatos.EliminarBebida(id, tipoBebida);
		}

		#endregion
	}
}
