using MediatR;
using System;

namespace ProjectLiquid.Domain.Handlers.Customer.Read
{
    public class ReadCustomerQuery : IRequest<ReadCustomerQueryResponse>
    {
        public int Id { get; set; }

        public ReadCustomerQuery(int id)
        {
            Id = id;
        }
    }
}
