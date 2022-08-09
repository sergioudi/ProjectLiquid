using MediatR;
using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Product.Update
{
    public class UpdateProductCommand : IRequest<UpdateProductCommandResponse>
    {
        public ProductEntity Body { get; set; }

        public UpdateProductCommand(ProductEntity body)
        {
            Body = body;
        }
    }
}
