﻿namespace Views
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//MessageBox.Show("Hola Marti");
			Application.Run(new FormRaiz());
		}
	}
}
