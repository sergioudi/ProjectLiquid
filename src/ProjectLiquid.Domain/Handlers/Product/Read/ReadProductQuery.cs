using MediatR;
using System;

namespace ProjectLiquid.Domain.Handlers.Product.Read
{
    public class ReadProductQuery : IRequest<ReadProductQueryResponse>
    {
        public int Id { get; set; }

        public ReadProductQuery(int id)
        {
            Id = id;
        }
    }
}
