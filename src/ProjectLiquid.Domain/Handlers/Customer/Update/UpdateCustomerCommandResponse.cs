using ProjectLiquid.Domain.Entities;

namespace ProjectLiquid.Domain.Handlers.Customer.Update
{
    public class UpdateCustomerCommandResponse
    {
        public CustomerEntity Data { get; set; }

        public UpdateCustomerCommandResponse(CustomerEntity data)
        {
            Data = data;
        }
    }
}
