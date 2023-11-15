﻿namespace SolidServices
{
	public class Usuario
	{
		public string? Nombre { get; set; }
		public string? Apellido { get; set; }
		public string? CorreoDigital { get; set; }
		public string? Contraseña { get; set; }
		public string? Rol { get; set; }
		public string? Estado { get; set; }
		public DateTime? CreadoEn { get; set; }
		public DateTime? ModificadoEn { get; set; }
		public DateTime? EliminadoEn { get; set; }
	}
}
