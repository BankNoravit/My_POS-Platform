using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class PUR_GOODS_RECEIPTConfiguration : IEntityTypeConfiguration<PUR_GOODS_RECEIPT>
    {
        public void Configure(EntityTypeBuilder<PUR_GOODS_RECEIPT> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.GOODS_RECEIPT_NO }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.PUR_GOODS_RECEIPT_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.DOCUMENT_STATUS)
                   .WithMany(b => b.PUR_GOODS_RECEIPT_DOCUMENT_STATUS)
                   .HasForeignKey(c => c.DOCUMENT_STATUS_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_CURRENCY)
                   .WithMany(b => b.PUR_GOODS_RECEIPT)
                   .HasForeignKey(c => c.CURRENCY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_TAX_VAT)
                   .WithMany(b => b.VAT)
                   .HasForeignKey(c => c.VAT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE)
                   .WithMany(b => b.PUR_GOODS_RECEIPT)
                   .HasForeignKey(c => c.WAREHOUSE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE_LOCATION)
                   .WithMany(b => b.PUR_GOODS_RECEIPT)
                   .HasForeignKey(c => c.WAREHOUSE_LOCATION_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.PUR_GOODS_RECEIPT_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_BRANCH)
                   .WithMany(b => b.PUR_GOODS_RECEIPT)
                   .HasForeignKey(c => c.BRANCH_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.PUR_GOODS_RECEIPT)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_PURCHASE_ORDER)
                   .WithMany(b => b.PUR_GOODS_RECEIPT)
                   .HasForeignKey(c => c.PURCHASE_ORDER_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_VENDOR)
                   .WithMany(b => b.PUR_GOODS_RECEIPT)
                   .HasForeignKey(c => c.VENDOR_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.RECEIPT_BY)
                   .WithMany(b => b.RECEIPT_BY)
                   .HasForeignKey(c => c.RECEIPT_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

