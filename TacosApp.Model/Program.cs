using Model.Controllers;
using Model.Interfaces;
using Model.Productos;
using System.Text.RegularExpressions;

namespace Model
{
	internal class Program
	{

		static void Main()
		{

			ControladorTaco controladorTaco = new();
			ControladorIngrediente controladorIngrediente = ControladorIngrediente.ObtenerInstancia();

			IIngrediente Maiz = controladorIngrediente.Crear(Enums.TipoIngrediente.Tortilla.ToString(), "Maiz", 135.50f);
			IIngrediente Trigo = controladorIngrediente.Crear(Enums.TipoIngrediente.Tortilla.ToString(), "Trigo", 120.5f);

			IIngrediente CannabisSativa = controladorIngrediente.Crear(Enums.TipoIngrediente.Relleno.ToString(), "Maria Juana", 905.75f);
			IIngrediente PsilocybeCubensis = controladorIngrediente.Crear(Enums.TipoIngrediente.Relleno.ToString(), "Goomba", 10.5f);
			IIngrediente HericiumErinaceus = controladorIngrediente.Crear(Enums.TipoIngrediente.Relleno.ToString(), "Champicóptero", 905.75f); // https://mario.fandom.com/es/wiki/Champi%C3%B1%C3%B3n#Tipos_de_champi%C3%B1ones
			IIngrediente Carne = controladorIngrediente.Crear(Enums.TipoIngrediente.Relleno.ToString(), "Carne", 150f);
			IIngrediente Pollo = controladorIngrediente.Crear(Enums.TipoIngrediente.Relleno.ToString(), "Pollo", 120f);
			IIngrediente Cerdo = controladorIngrediente.Crear(Enums.TipoIngrediente.Relleno.ToString(), "Cerdo", 140f);
			IIngrediente Queso = controladorIngrediente.Crear(Enums.TipoIngrediente.Relleno.ToString(), "Queso", 100f);

			IIngrediente Wacamole = controladorIngrediente.Crear(Enums.TipoIngrediente.Salsa.ToString(), "Wacamole", 150f);
			IIngrediente Cheddar = controladorIngrediente.Crear(Enums.TipoIngrediente.Salsa.ToString(), "Cheddar", 110.50f);
			IIngrediente Tempura = controladorIngrediente.Crear(Enums.TipoIngrediente.Salsa.ToString(), "Tempura", 135.50f);

			List<IIngrediente> ListaIngredientes = new()
											{
												Maiz, Trigo,
												CannabisSativa,
												PsilocybeCubensis,
												HericiumErinaceus,
												Carne, Pollo, Cerdo,
												Queso, Wacamole,
												Cheddar, Tempura
											};

			var taco1 = controladorTaco.Crear(1, ListaIngredientes);
			var taco2 = controladorTaco.Crear(2, ListaIngredientes);
			var taco3 = controladorTaco.Crear(3, ListaIngredientes);

			List<Taco> ListaTacos = new()
											{
												taco1,
												taco2,
												taco3
											};

			List<Taco> ListaTacosConIdMayorADos = ListaTacos.FindAll(t => t.Id > 2);
			int years = 1;
			string msg = @$"Este evento, ocurrio hace {years} año{(years > 1 ? "s" : "")}"; //interpolation + verbatim + operador ternario
			Console.WriteLine(msg);
			//MostrarListaTacos(ListaTacos);
			//MostrarListaTacos(ListaTacosConIdMayorADos);


			Console.ReadLine();


			string frase = @"
																			Beautiful is better than ugly.
																			Explicit is better than implicit.
																			Simple is better than complex.
																			Complex is better than complicated.
																			Flat is better than nested.
																			Sparse is better than dense.
																			Readability counts.
																			Special cases aren't special enough to break the rules.
																			Although practicality beats purity.
																			Errors should never pass silently.
																			Unless explicitly silenced.\r\nIn the face of ambiguity, refuse the temptation to guess.
																			There should be one-- and preferably only one --obvious way to do it.
																			Although that way may not be obvious at first unless you're Dutch.
																			Now is better than never.
																			Although never is often better than *right* now.
																			If the implementation is hard to explain, it's a bad idea.
																			If the implementation is easy to explain, it may be a good idea.
																			Namespaces are one honking great idea -- let's do more of those!
																		";

			Console.WriteLine(frase);
			string patron = "[better]";
			string patron2 = @"\d{3}";
			Regex miRegex = new Regex(patron2);
			MatchCollection elMatch = miRegex.Matches(frase);
			if (elMatch.Count > 0) Console.WriteLine($"Se ha encontrado ...{patron}");
			if (elMatch.Count > 0) Console.WriteLine($"Se ha encontrado ...{patron2}");
			else Console.WriteLine("No se ha encontrado");
			Console.ReadLine();

		}
	}
}

