using Liquid.Repository;
using MediatR;
using ProjectLiquid.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace ProjectLiquid.Domain.Handlers.Product.Read
{
    public class ReadProductQueryHandler : IRequestHandler<ReadProductQuery, ReadProductQueryResponse>
    {
        private readonly ILiquidRepository<ProductEntity, int> _repository;

        public ReadProductQueryHandler(ILiquidRepository<ProductEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ReadProductQueryResponse> Handle(ReadProductQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            return new ReadProductQueryResponse(data);
        }
    }
}
