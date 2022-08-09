using ProjectLiquid.Domain.Entities;
using System.Collections.Generic;

namespace ProjectLiquid.Domain.Handlers.Product.List
{
    public class ListProductQueryResponse
    {
        public IEnumerable<ProductEntity> Data { get; set; }

        public ListProductQueryResponse(IEnumerable<ProductEntity> data)
        {
            Data = data;
        }
    }
}
