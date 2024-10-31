using ClothingStore.Application.Extensions;
using ClothingStore.Application.Features.Command;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Validators.FluentValidations
{
    public class AddProductCommandValidator: AbstractValidator<AddProductCommand>
    {
        public AddProductCommandValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty()
                .CheckNull();

            RuleFor(x => x.Price)
                 .GreaterThan(5)
                 .WithMessage("Price must be greater than 5");

            RuleFor(x => x.Description)
                .NotEmpty()
                .CheckNull();
        }
    }
}
