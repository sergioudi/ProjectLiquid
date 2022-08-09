using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Customer.Remove
{
    public class RemoveCustomerCommandResponse
    {
        public CustomerEntity Data { get; set; }

        public RemoveCustomerCommandResponse(CustomerEntity data)
        {
            Data = data;
        }
    }
}
