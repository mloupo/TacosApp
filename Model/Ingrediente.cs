using Model.Interfaces;

namespace Model
{
    public abstract class Ingrediente : IIngrediente
	{
		public double Precio { get ; set; }
		public string? Nombre { get; set; }
		public int Id { get; set; }

		public void GetPrecioConsole()
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
