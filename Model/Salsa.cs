using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public partial class Salsa : Ingrediente
	{
		public Salsa() { }

		public Salsa(string name, double precio)
		{
			Nombre = name;
			Precio = precio;
		}

		public Salsa(string name, double precio, int id)
		{
			Nombre = name;
			Precio = precio;
			Id = id;	
		}	
	}
}
