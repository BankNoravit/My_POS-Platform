using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class INV_PRODDUCT_SELLING_POINTConfiguration : IEntityTypeConfiguration<INV_PRODDUCT_SELLING_POINT>
    {
        public void Configure(EntityTypeBuilder<INV_PRODDUCT_SELLING_POINT> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.INV_PRODDUCT_SELLING_POINT_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_PRODUCT)
                   .WithMany(b => b.INV_PRODDUCT_SELLING_POINT)
                   .HasForeignKey(c => c.PRODUCT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.INV_PRODDUCT_SELLING_POINT_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

