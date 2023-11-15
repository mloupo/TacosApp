using Model.Interfaces;

namespace Model.Productos
{
	public abstract class Ingrediente : IIngrediente
	{
		public float Precio { get; set; }
		public string? Nombre { get; set; }
		public int Id { get; set; }
		public int CantidadMaxima { get; set; }

		public void ObtenerPrecioConsola()
		{
			Console.WriteLine(Precio);
		}

		public override string? ToString()
		{
			return GetType().Name + DatosIngrediente();
		}

		public string DatosIngrediente()
		{
			return $" Nro: {Id} de {Nombre}, Precio: {Precio}";
		}
	}
}
