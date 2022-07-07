using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class PUR_VENDOR_BANK_ACCOUNTConfiguration : IEntityTypeConfiguration<PUR_VENDOR_BANK_ACCOUNT>
    {
        public void Configure(EntityTypeBuilder<PUR_VENDOR_BANK_ACCOUNT> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.PUR_VENDOR_BANK_ACCOUNT_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_BANK)
                   .WithMany(b => b.PUR_VENDOR_BANK_ACCOUNT)
                   .HasForeignKey(c => c.BANK_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.FNA_BANK_BRANCH)
                   .WithMany(b => b.PUR_VENDOR_BANK_ACCOUNT)
                   .HasForeignKey(c => c.BANK_BRANCH_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.PUR_VENDOR_BANK_ACCOUNT_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.PUR_VENDOR_BANK_ACCOUNT)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.PUR_VENDOR)
                   .WithMany(b => b.PUR_VENDOR_BANK_ACCOUNT)
                   .HasForeignKey(c => c.VENDOR_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

