using MediatR;

namespace ProjectLiquid.Domain.Handlers.Customer.List
{
    public class ListCustomerQuery : IRequest<ListCustomerQueryResponse>
    {
        public ListCustomerQuery()
        {

        }
    }
}
