using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class PUR_GOODS_RETURNConfiguration : IEntityTypeConfiguration<PUR_GOODS_RETURN>
    {
        public void Configure(EntityTypeBuilder<PUR_GOODS_RETURN> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.GOODS_RETURN_NO }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.PUR_GOODS_RETURN_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.DOCUMENT_STATUS)
                   .WithMany(b => b.PUR_GOODS_RETURN_DOCUMENT_STATUS)
                   .HasForeignKey(c => c.DOCUMENT_STATUS_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_CURRENCY)
                   .WithMany(b => b.PUR_GOODS_RETURN)
                   .HasForeignKey(c => c.CURRENCY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_TAX_VAT)
                   .WithMany(b => b.PUR_GOODS_RETURN_VAT)
                   .HasForeignKey(c => c.VAT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE)
                   .WithMany(b => b.PUR_GOODS_RETURN)
                   .HasForeignKey(c => c.WAREHOUSE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE_LOCATION)
                   .WithMany(b => b.PUR_GOODS_RETURN)
                   .HasForeignKey(c => c.WAREHOUSE_LOCATION_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.PUR_GOODS_RETURN_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_BRANCH)
                   .WithMany(b => b.PUR_GOODS_RETURN)
                   .HasForeignKey(c => c.BRANCH_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.PUR_GOODS_RETURN)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_PURCHASE_ORDER)
                   .WithMany(b => b.PUR_GOODS_RETURN)
                   .HasForeignKey(c => c.PURCHASE_ORDER_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_VENDOR)
                   .WithMany(b => b.PUR_GOODS_RETURN)
                   .HasForeignKey(c => c.VENDOR_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.RETURN_BY)
                   .WithMany(b => b.RETURN_BY)
                   .HasForeignKey(c => c.RETURN_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

