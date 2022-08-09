using FluentValidation;

namespace ProjectLiquid.Domain.Handlers.Product.Create
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {

        }
    }
}
