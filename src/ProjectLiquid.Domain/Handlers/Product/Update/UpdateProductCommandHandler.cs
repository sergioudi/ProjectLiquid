using Liquid.Repository;
using MediatR;
using ProjectLiquid.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace ProjectLiquid.Domain.Handlers.Product.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdateProductCommandResponse>
    {
        private readonly ILiquidRepository<ProductEntity, int> _repository;

        public UpdateProductCommandHandler(ILiquidRepository<ProductEntity, int> repository)
        {
            _repository = repository;
        }


        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Body.Id);

            if (data != null)
            {
                await _repository.UpdateAsync(request.Body);
            }

            return new UpdateProductCommandResponse(request.Body);
        }
    }
}
