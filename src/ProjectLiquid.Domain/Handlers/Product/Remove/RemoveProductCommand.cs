using MediatR;
using System;

namespace ProjectLiquid.Domain.Handlers.Product.Remove
{
    public class RemoveProductCommand : IRequest<RemoveProductCommandResponse>
    {
        public int Id { get; set; }

        public RemoveProductCommand(int id)
        {
            Id = id;
        }
    }
}
