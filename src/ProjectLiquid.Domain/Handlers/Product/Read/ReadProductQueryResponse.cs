using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Product.Read
{
    public class ReadProductQueryResponse
    {
        public ProductEntity Data { get; set; }

        public ReadProductQueryResponse(ProductEntity data)
        {
            Data = data;
        }
    }
}
