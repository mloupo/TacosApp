using FluentValidation;
using Modelo.EntidadesProducto.Tacos;

namespace Validaciones.Ingredientes
{
	public class AgregarIngredienteValidador : AbstractValidator<Ingrediente>
	{
		public AgregarIngredienteValidador(int cantidadMaxima)
		{
			RuleFor(i => i.CantidadMaxima)
				.GreaterThan(0)
				.LessThanOrEqualTo(cantidadMaxima)
				.WithMessage("Superaste el limite maximo de ingredientes de este tipo");
		}
	}
}
