using Liquid.Repository;
using MediatR;
using ProjectLiquid.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace ProjectLiquid.Domain.Handlers.Product.List
{
    public class ListProductQueryHandler : IRequestHandler<ListProductQuery, ListProductQueryResponse>
    {
        private readonly ILiquidRepository<ProductEntity, int> _repository;

        public ListProductQueryHandler(ILiquidRepository<ProductEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ListProductQueryResponse> Handle(ListProductQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindAllAsync();

            return new ListProductQueryResponse(data);
        }
    }
}
