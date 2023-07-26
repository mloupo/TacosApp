namespace Model

{
	public static class Enums
	{
		public enum TipoIngrediente { Tortilla, Relleno, Salsa }
		public enum TipoCreacion { Ingrediente, Taco, Bebida, Postre }

		public enum StatusStates { SUCCESS, FAILED }


		public enum ArticuloSuper { Azucar, Cafe, Queso, Rollo, Cocina, PapelHigienico, Arroz, CaldoVerduras, Jugos, Alcohol, Prepizza, CarnePicada, MilanesasPollo, Pechugas, Morron, Hamburguesas }

		[Flags]
		public enum Condimentos { nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8 }
		public enum Condimentos2
		{
			nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8,
			Basica = Tomate | Lechuga,
			Completa = Tomate | Lechuga | Cebolla | Queso
		}
	}
}
