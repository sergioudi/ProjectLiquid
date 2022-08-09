using MediatR;
using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Customer.Update
{
    public class UpdateCustomerCommand : IRequest<UpdateCustomerCommandResponse>
    {
        public CustomerEntity Body { get; set; }

        public UpdateCustomerCommand(CustomerEntity body)
        {
            Body = body;
        }
    }
}
