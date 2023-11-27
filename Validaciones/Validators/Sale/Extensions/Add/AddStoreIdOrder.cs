﻿using FluentValidation;

using CA.Domain.DTO;
using CA.Domain.Features;

namespace CA.Application.Validators
{
    public class AddStoreIdOrder : AbstractValidator<CreateSaleDTO>
    {
        public AddStoreIdOrder()
        {
            RuleFor(u => u.StoreId).Cascade(CascadeMode.Stop)
                                    .Must(u => u >= 0).WithMessage("El identificador de la sucursal no puede ser negativo.")
                                    .Must(u => RegexExtensions.VerifyValue(u, @"^\d{1,6}$")).WithMessage("Formato de número entero incorrecto: solo dígitos.");
        }
    }
}
