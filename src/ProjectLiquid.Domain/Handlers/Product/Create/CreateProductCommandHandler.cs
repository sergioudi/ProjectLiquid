using Liquid.Repository;
using MediatR;
using ProjectLiquid.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace ProjectLiquid.Domain.Handlers.Product.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly ILiquidRepository<ProductEntity, int> _repository;

        public CreateProductCommandHandler(ILiquidRepository<ProductEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(request.Body);

            return new Unit();
        }
    }
}
