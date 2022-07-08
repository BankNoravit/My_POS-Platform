using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class INV_STOCK_REQUISITIONConfiguration : IEntityTypeConfiguration<INV_STOCK_REQUISITION>
    {
        public void Configure(EntityTypeBuilder<INV_STOCK_REQUISITION> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.STOCK_REQUISITION_NO }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.APPROVAL_STATUS)
                   .WithMany(b => b.APPROVAL_STATUS)
                   .HasForeignKey(c => c.APPROVAL_STATUS_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.BRANCH)
                   .WithMany(b => b.INV_STOCK_REQUISITION_BRANCH)
                   .HasForeignKey(c => c.BRANCH_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.BRANCH_TO)
                   .WithMany(b => b.BRANCH_TO)
                   .HasForeignKey(c => c.BRANCH_TO_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.INV_STOCK_REQUISITION_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.DOCUMENT_STATUS)
                   .WithMany(b => b.DOCUMENT_STATUS)
                   .HasForeignKey(c => c.DOCUMENT_STATUS_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.INV_STOCK_REQUISITION_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.INV_STOCK_REQUISITION)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.REQUISITION_BY)
                   .WithMany(b => b.REQUISITION_BY)
                   .HasForeignKey(c => c.REQUISITION_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.WAREHOUSE_LOCATION_TO)
                   .WithMany(b => b.WAREHOUSE_LOCATION_TO)
                   .HasForeignKey(c => c.WAREHOUSE_LOCATION_TO_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.WAREHOUSE_TO)
                   .WithMany(b => b.WAREHOUSE_TO)
                   .HasForeignKey(c => c.WAREHOUSE_TO_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

