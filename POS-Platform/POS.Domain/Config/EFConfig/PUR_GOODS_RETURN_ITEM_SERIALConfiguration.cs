using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class PUR_GOODS_RETURN_ITEM_SERIALConfiguration : IEntityTypeConfiguration<PUR_GOODS_RETURN_ITEM_SERIAL>
    {
        public void Configure(EntityTypeBuilder<PUR_GOODS_RETURN_ITEM_SERIAL> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.PUR_GOODS_RETURN_ITEM_SERIAL_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_PRODUCT)
                   .WithMany(b => b.PUR_GOODS_RETURN_ITEM_SERIAL)
                   .HasForeignKey(c => c.PRODUCT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.PUR_GOODS_RETURN_ITEM_SERIAL_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_GOODS_RETURN_ITEM)
                   .WithMany(b => b.PUR_GOODS_RETURN_ITEM_SERIAL)
                   .HasForeignKey(c => c.GOODS_RETURN_ITEM_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

