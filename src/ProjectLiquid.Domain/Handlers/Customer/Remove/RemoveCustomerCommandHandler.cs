using Liquid.Repository;
using MediatR;
using ProjectLiquid.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace ProjectLiquid.Domain.Handlers.Customer.Remove
{
    public class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand, RemoveCustomerCommandResponse>
    {
        private readonly ILiquidRepository<CustomerEntity, int> _repository;

        public RemoveCustomerCommandHandler(ILiquidRepository<CustomerEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<RemoveCustomerCommandResponse> Handle(RemoveCustomerCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            if (data != null)
            {
                await _repository.RemoveByIdAsync(request.Id);
            }

            return new RemoveCustomerCommandResponse(data);
        }
    }
}
