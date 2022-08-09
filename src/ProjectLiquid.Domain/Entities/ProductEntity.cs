using Liquid.Repository;
using System;

namespace ProjectLiquid.Domain.Entities
{
    public class ProductEntity : LiquidEntity<int>
    {
        public string Description { get; set; }
    }
}
