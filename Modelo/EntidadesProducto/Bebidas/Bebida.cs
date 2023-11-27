﻿using Modelo.Interfaces;

namespace Modelo.EntidadesProducto.Bebidas
{
	public abstract class Bebida : IBebida
	{
		public string? Nombre { get; set; }
		public float Precio { get; set; }

		public string DatosBebida()
		{
			return $"Nombre: {Nombre} Precio: {Precio}";
		}

		public float ObtenerPrecio()
		{
			return Precio;
		}

		public void ObtenerPrecioConsola()
		{
			Console.WriteLine($"El precio de {Nombre} es {Precio}");
		}
	}
}