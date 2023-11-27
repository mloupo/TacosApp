using FluentValidation;
using Modelo.EntidadesUsuario;

namespace Validaciones.Contactos
{
	public class ContactoValidador : AbstractValidator<Contacto>
	{
		public ContactoValidador()
		{
			RuleFor(c => c.Nombre).NotEmpty().WithMessage("El nombre no puede estar vacio");
			RuleFor(c => c.Nombre).MaximumLength(20).WithMessage("El nombre no puede tener mas de 20 caracteres");
			RuleFor(c => c.Apellido).NotEmpty().WithMessage("El apellido no puede estar vacio");
			RuleFor(c => c.Apellido).MaximumLength(20).WithMessage("El apellido no puede tener mas de 20 caracteres");
			RuleFor(c => c.NroContacto).NotEmpty().WithMessage("El telefono no puede estar vacio");
			RuleFor(c => c.NroContacto).MaximumLength(20).WithMessage("El telefono no puede tener mas de 20 caracteres");
			RuleFor(c => c.CorreoElectronico).NotEmpty().WithMessage("La direccion no puede estar vacia");
			RuleFor(c => c.CorreoElectronico).MaximumLength(20).WithMessage("La direccion no puede tener mas de 20 caracteres");
			RuleFor(c => c.DireccionEnvio).NotEmpty().WithMessage("El email no puede estar vacio");
			RuleFor(c => c.DireccionEnvio).MaximumLength(20).WithMessage("El email no puede tener mas de 20 caracteres");
			RuleFor(c => c.Contraseña).NotEmpty().WithMessage("La contraseña no puede estar vacia");
			RuleFor(c => c.Contraseña).MaximumLength(20).WithMessage("La contraseña no puede tener mas de 20 caracteres");
		}
	}
}
