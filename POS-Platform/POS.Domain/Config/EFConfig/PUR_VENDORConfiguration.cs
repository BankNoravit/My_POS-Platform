using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class PUR_VENDORConfiguration : IEntityTypeConfiguration<PUR_VENDOR>
    {
        public void Configure(EntityTypeBuilder<PUR_VENDOR> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.VENDOR_CODE }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.BILLING)
                   .WithMany(b => b.BILLING)
                   .HasForeignKey(c => c.BILLING_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.COLLECT)
                   .WithMany(b => b.COLLECT)
                   .HasForeignKey(c => c.COLLECT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.PUR_VENDOR_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_TAX)
                   .WithMany(b => b.PUR_VENDOR)
                   .HasForeignKey(c => c.TAX_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.PUR_VENDOR_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.PUR_VENDOR)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PROSPECT)
                   .WithMany(b => b.PROSPECT)
                   .HasForeignKey(c => c.PROSPECT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_VENDOR_GROUP)
                   .WithMany(b => b.PUR_VENDOR)
                   .HasForeignKey(c => c.VENDOR_GROUP_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_VENDOR_TYPE)
                   .WithMany(b => b.PUR_VENDOR)
                   .HasForeignKey(c => c.VENDOR_TYPE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.TITLE)
                   .WithMany(b => b.TITLE)
                   .HasForeignKey(c => c.TITLE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

