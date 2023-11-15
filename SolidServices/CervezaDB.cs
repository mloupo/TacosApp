namespace SolidServices
{
	public class CervezaDB
	{
		private Cerveza _cerveza;

		public CervezaDB(Cerveza cerveza)
		{
			_cerveza = cerveza;
		}
		public void Almacenar()
		{
			Console.WriteLine($"Guardamos {_cerveza.Nombre} y {_cerveza.Marca} en la base de datos");
		}
	}
}
