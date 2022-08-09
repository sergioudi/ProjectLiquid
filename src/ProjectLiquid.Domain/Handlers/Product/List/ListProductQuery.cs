using MediatR;

namespace ProjectLiquid.Domain.Handlers.Product.List
{
    public class ListProductQuery : IRequest<ListProductQueryResponse>
    {
        public ListProductQuery()
        {

        }
    }
}
