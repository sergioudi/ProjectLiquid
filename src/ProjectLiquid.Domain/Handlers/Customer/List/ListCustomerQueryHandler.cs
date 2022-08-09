using Liquid.Repository;
using MediatR;
using ProjectLiquid.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace ProjectLiquid.Domain.Handlers.Customer.List
{
    public class ListCustomerQueryHandler : IRequestHandler<ListCustomerQuery, ListCustomerQueryResponse>
    {
        private readonly ILiquidRepository<CustomerEntity, int> _repository;

        public ListCustomerQueryHandler(ILiquidRepository<CustomerEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ListCustomerQueryResponse> Handle(ListCustomerQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindAllAsync();

            return new ListCustomerQueryResponse(data);
        }
    }
}
