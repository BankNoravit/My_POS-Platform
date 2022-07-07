using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class PUR_PURCHASE_REQUISITIONConfiguration : IEntityTypeConfiguration<PUR_PURCHASE_REQUISITION>
    {
        public void Configure(EntityTypeBuilder<PUR_PURCHASE_REQUISITION> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.PURCHASE_REQUISITION_NO }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.APPROVAL_STATUS)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION_APPROVAL_STATUS)
                   .HasForeignKey(c => c.APPROVAL_STATUS_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.DOCUMENT_STATUS)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION_DOCUMENT_STATUS)
                   .HasForeignKey(c => c.DOCUMENT_STATUS_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_CURRENCY)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION)
                   .HasForeignKey(c => c.CURRENCY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_TAX_VAT)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION_VAT)
                   .HasForeignKey(c => c.VAT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_BRANCH)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION)
                   .HasForeignKey(c => c.BRANCH_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_DEPARTMENT)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION)
                   .HasForeignKey(c => c.DEPARTMENT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_EMPLOYEE)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION)
                   .HasForeignKey(c => c.EMPLOYEE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_POSITION)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION)
                   .HasForeignKey(c => c.POSITION_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_VENDOR)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION)
                   .HasForeignKey(c => c.VENDOR_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_VENDOR_CONTACT)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION)
                   .HasForeignKey(c => c.VENDOR_CONTACT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PURCHASE_REQUISITION_TYPE)
                   .WithMany(b => b.PURCHASE_REQUISITION_TYPE)
                   .HasForeignKey(c => c.PURCHASE_REQUISITION_TYPE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SHIPPING_METHOD)
                   .WithMany(b => b.PUR_PURCHASE_REQUISITION_SHIPPING_METHOD)
                   .HasForeignKey(c => c.SHIPPING_METHOD_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

