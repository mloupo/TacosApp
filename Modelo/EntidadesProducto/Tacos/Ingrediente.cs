﻿using Modelo.Interfaces;

namespace Modelo.EntidadesProducto.Tacos
{
	public abstract class Ingrediente : IIngrediente
	{
		public float Precio { get; set; }
		public string? Nombre { get; set; }
		public int Id { get; set; }
		public int CantidadMaxima { get; set; }

		public void PrecioConsola()
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
