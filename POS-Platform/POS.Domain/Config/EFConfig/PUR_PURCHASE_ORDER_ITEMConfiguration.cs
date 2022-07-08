using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class PUR_PURCHASE_ORDER_ITEMConfiguration : IEntityTypeConfiguration<PUR_PURCHASE_ORDER_ITEM>
    {
        public void Configure(EntityTypeBuilder<PUR_PURCHASE_ORDER_ITEM> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_PRODUCT)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM)
                   .HasForeignKey(c => c.PRODUCT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_UOM)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM)
                   .HasForeignKey(c => c.UOM_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_PURCHASE_ORDER)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM)
                   .HasForeignKey(c => c.PURCHASE_ORDER_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

