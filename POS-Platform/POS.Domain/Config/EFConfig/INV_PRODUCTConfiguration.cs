using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class INV_PRODUCTConfiguration : IEntityTypeConfiguration<INV_PRODUCT>
    {
        public void Configure(EntityTypeBuilder<INV_PRODUCT> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.INV_PRODUCT_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_SUB_CATEGORY)
                   .WithMany(b => b.INV_PRODUCT)
                   .HasForeignKey(c => c.SUB_CATEGORY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_UOM)
                   .WithMany(b => b.INV_PRODUCT)
                   .HasForeignKey(c => c.UOM_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.INV_PRODUCT_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

