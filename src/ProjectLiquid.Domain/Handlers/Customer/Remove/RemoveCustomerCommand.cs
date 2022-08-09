using MediatR;
using System;

namespace ProjectLiquid.Domain.Handlers.Customer.Remove
{
    public class RemoveCustomerCommand : IRequest<RemoveCustomerCommandResponse>
    {
        public int Id { get; set; }

        public RemoveCustomerCommand(int id)
        {
            Id = id;
        }
    }
}
