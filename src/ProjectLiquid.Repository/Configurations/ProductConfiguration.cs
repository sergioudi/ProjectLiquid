using ProjectLiquid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectLiquid.Repository.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.Property(o => o.Id).ValueGeneratedOnAdd();

            builder.HasKey(o => o.Id);
        }
    }
}
