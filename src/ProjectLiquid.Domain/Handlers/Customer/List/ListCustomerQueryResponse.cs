using ProjectLiquid.Domain.Entities;
using System.Collections.Generic;

namespace ProjectLiquid.Domain.Handlers.Customer.List
{
    public class ListCustomerQueryResponse
    {
        public IEnumerable<CustomerEntity> Data { get; set; }

        public ListCustomerQueryResponse(IEnumerable<CustomerEntity> data)
        {
            Data = data;
        }
    }
}
