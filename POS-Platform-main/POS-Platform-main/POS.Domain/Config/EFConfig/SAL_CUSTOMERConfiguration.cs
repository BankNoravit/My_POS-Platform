using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class SAL_CUSTOMERConfiguration : IEntityTypeConfiguration<SAL_CUSTOMER>
    {
        public void Configure(EntityTypeBuilder<SAL_CUSTOMER> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.CUSTOMER_CODE }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.BILLING)
                   .WithMany(b => b.SAL_CUSTOMER_BILLING)
                   .HasForeignKey(c => c.BILLING_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.COLLECT)
                   .WithMany(b => b.SAL_CUSTOMER_COLLECT)
                   .HasForeignKey(c => c.COLLECT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.SAL_CUSTOMER_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.CUSTOMER_TYPE)
                   .WithMany(b => b.CUSTOMER_TYPE)
                   .HasForeignKey(c => c.CUSTOMER_TYPE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_TAX)
                   .WithMany(b => b.SAL_CUSTOMER)
                   .HasForeignKey(c => c.TAX_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.SAL_CUSTOMER_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.SAL_CUSTOMER)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PROSPECT)
                   .WithMany(b => b.SAL_CUSTOMER_PROSPECT)
                   .HasForeignKey(c => c.PROSPECT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SAL_CUSTOMER_GROUP)
                   .WithMany(b => b.SAL_CUSTOMER)
                   .HasForeignKey(c => c.CUSTOMER_GROUP_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.TITLE)
                   .WithMany(b => b.SAL_CUSTOMER_TITLE)
                   .HasForeignKey(c => c.TITLE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

