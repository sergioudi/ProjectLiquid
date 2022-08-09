using MediatR;
using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Product.Create
{
    public class CreateProductCommand : IRequest
    {
        public ProductEntity Body { get; set; }

        public CreateProductCommand(ProductEntity body)
        {
            Body = body;
        }
    }
}
