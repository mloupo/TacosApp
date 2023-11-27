// See https://aka.ms/new-console-template for more information
using FluentValidation.Results;
using Modelo.EntidadesProducto.Tacos;
using Validaciones.Ingredientes;

Console.WriteLine("Hello, World!");
Ingrediente ingrediente = new Tortilla();
IngredienteValidador validadorIngrediente = new IngredienteValidador();
ValidationResult res = validadorIngrediente.Validate(ingrediente);

if (!res.IsValid)
{
	foreach (ValidationFailure failure in res.Errors)
	{
		Console.WriteLine($"Error: {failure.ErrorMessage}");
	}
}
else
{
	Console.WriteLine("El ingrediente es valido");
}