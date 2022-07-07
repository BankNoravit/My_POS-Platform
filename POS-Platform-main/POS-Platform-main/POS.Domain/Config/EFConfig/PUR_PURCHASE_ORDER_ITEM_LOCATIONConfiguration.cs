using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class PUR_PURCHASE_ORDER_ITEM_LOCATIONConfiguration : IEntityTypeConfiguration<PUR_PURCHASE_ORDER_ITEM_LOCATION>
    {
        public void Configure(EntityTypeBuilder<PUR_PURCHASE_ORDER_ITEM_LOCATION> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM_LOCATION_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_PRODUCT)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM_LOCATION)
                   .HasForeignKey(c => c.PRODUCT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM_LOCATION)
                   .HasForeignKey(c => c.WAREHOUSE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE_LOCATION)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM_LOCATION)
                   .HasForeignKey(c => c.WAREHOUSE_LOCATION_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM_LOCATION_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_BRANCH)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM_LOCATION)
                   .HasForeignKey(c => c.BRANCH_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_PURCHASE_ORDER_ITEM)
                   .WithMany(b => b.PUR_PURCHASE_ORDER_ITEM_LOCATION)
                   .HasForeignKey(c => c.PURCHASE_ORDER_ITEM_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

