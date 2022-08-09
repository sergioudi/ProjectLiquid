using FluentValidation;

namespace ProjectLiquid.Domain.Handlers.Customer.Create
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {

        }
    }
}
