using MediatR;
using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Customer.Create
{
    public class CreateCustomerCommand : IRequest
    {
        public CustomerEntity Body { get; set; }

        public CreateCustomerCommand(CustomerEntity body)
        {
            Body = body;
        }
    }
}
