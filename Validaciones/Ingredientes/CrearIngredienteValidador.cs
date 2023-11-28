using FluentValidation;
using Modelo.EntidadesProducto.Tacos;

namespace Validaciones.Ingredientes
{
	public class CrearIngredienteValidador : AbstractValidator<Ingrediente>
	{
		public CrearIngredienteValidador()
		{
			RuleFor(i => i.Nombre).NotEmpty().WithMessage("El nombre no puede estar vacio");
			RuleFor(i => i.Nombre).MaximumLength(20).WithMessage("El nombre no puede tener mas de 20 caracteres");
			RuleFor(i => i.Precio).NotEmpty().WithMessage("El precio no puede estar vacio");
			RuleFor(i => i.Precio).GreaterThan(0).WithMessage("El precio debe ser mayor a 0");
			RuleFor(i => i.CantidadMaxima).NotEmpty().WithMessage("La cantidad maxima no puede estar vacia");
			RuleFor(i => i.CantidadMaxima).GreaterThan(0).WithMessage("La cantidad maxima debe ser mayor a 0");
		}
	}
}
