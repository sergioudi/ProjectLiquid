using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Product.Remove
{
    public class RemoveProductCommandResponse
    {
        public ProductEntity Data { get; set; }

        public RemoveProductCommandResponse(ProductEntity data)
        {
            Data = data;
        }
    }
}
