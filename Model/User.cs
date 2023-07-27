using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public abstract class User
	{
		public string? Nombre { get; set; }
		public string? Email { get; set; }
		public string? NroContacto { get; set; }
	}
}
