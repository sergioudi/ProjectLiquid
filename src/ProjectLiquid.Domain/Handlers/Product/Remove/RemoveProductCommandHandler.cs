using Liquid.Repository;
using MediatR;
using ProjectLiquid.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace ProjectLiquid.Domain.Handlers.Product.Remove
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand, RemoveProductCommandResponse>
    {
        private readonly ILiquidRepository<ProductEntity, int> _repository;

        public RemoveProductCommandHandler(ILiquidRepository<ProductEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<RemoveProductCommandResponse> Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            if (data != null)
            {
                await _repository.RemoveByIdAsync(request.Id);
                //await _mediator.Publish(new GenericEntityRemovedNotification<TEntity, TIdentifier>(entity));
            }

            return new RemoveProductCommandResponse(data);
        }
    }
}
