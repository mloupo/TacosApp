using FluentValidation;
using Modelo.EntidadesProducto.Bebidas;

namespace Validaciones.Bebidas
{
	public class BebidaValidador : AbstractValidator<Bebida>
	{
		public BebidaValidador()
		{
			RuleFor(b => b.Nombre).NotEmpty().WithMessage("El nombre no puede estar vacio");
			RuleFor(b => b.Nombre).MaximumLength(20).WithMessage("El nombre no puede tener mas de 20 caracteres");
			RuleFor(b => b.Precio).NotEmpty().WithMessage("El precio no puede estar vacio");
			RuleFor(b => b.Precio).GreaterThan(0).WithMessage("El precio debe ser mayor a 0");
		}
	}
}
