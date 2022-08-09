using Liquid.Repository;
using MediatR;
using ProjectLiquid.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace ProjectLiquid.Domain.Handlers.Customer.Read
{
    public class ReadCustomerQueryHandler : IRequestHandler<ReadCustomerQuery, ReadCustomerQueryResponse>
    {
        private readonly ILiquidRepository<CustomerEntity, int> _repository;

        public ReadCustomerQueryHandler(ILiquidRepository<CustomerEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ReadCustomerQueryResponse> Handle(ReadCustomerQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            return new ReadCustomerQueryResponse(data);
        }
    }
}
