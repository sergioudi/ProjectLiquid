using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Product.Update
{
    public class UpdateProductCommandResponse
    {
        public ProductEntity Data { get; set; }

        public UpdateProductCommandResponse(ProductEntity data)
        {
            Data = data;
        }
    }
}
