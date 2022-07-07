using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class INV_STOCK_REQUISITION_ITEMConfiguration : IEntityTypeConfiguration<INV_STOCK_REQUISITION_ITEM>
    {
        public void Configure(EntityTypeBuilder<INV_STOCK_REQUISITION_ITEM> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.INV_STOCK_REQUISITION_ITEM_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_PRODUCT)
                   .WithMany(b => b.INV_STOCK_REQUISITION_ITEM)
                   .HasForeignKey(c => c.PRODUCT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_STOCK_REQUISITION)
                   .WithMany(b => b.INV_STOCK_REQUISITION_ITEM)
                   .HasForeignKey(c => c.STOCK_REQUISITION_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_UOM)
                   .WithMany(b => b.INV_STOCK_REQUISITION_ITEM)
                   .HasForeignKey(c => c.UOM_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE)
                   .WithMany(b => b.INV_STOCK_REQUISITION_ITEM)
                   .HasForeignKey(c => c.WAREHOUSE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE_LOCATION)
                   .WithMany(b => b.INV_STOCK_REQUISITION_ITEM)
                   .HasForeignKey(c => c.WAREHOUSE_LOCATION_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.INV_STOCK_REQUISITION_ITEM_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

