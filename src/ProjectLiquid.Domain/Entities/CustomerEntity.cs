using Liquid.Repository;
using System;

namespace ProjectLiquid.Domain.Entities
{
    public class CustomerEntity : LiquidEntity<int>
    {
        public string Name { get; set; }
    }
}
