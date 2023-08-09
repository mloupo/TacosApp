using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Productos
{
	public partial class Salsa : Ingrediente
	{
		public Salsa() { }

		public Salsa(string name, decimal precio)
		{
			CantidadMaxima = 1;
			Nombre = name;
			Precio = precio;
		}

		public Salsa(string name, decimal precio, int id)
		{
			Nombre = name;
			Precio = precio;
			Id = id;
		}
	}
}
