using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Customer.Read
{
    public class ReadCustomerQueryResponse
    {
        public CustomerEntity Data { get; set; }

        public ReadCustomerQueryResponse(CustomerEntity data)
        {
            Data = data;
        }
    }
}
