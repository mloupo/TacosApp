namespace Model.Interfaces
{
	public interface IPedido
	{

		public void ConfirmarPedido();

		public float ObtenerImporteTotal();

		public float ObtenerImporteTacos();

		public float ObtenerImporteBebidas();

	}
}