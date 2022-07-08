using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class FNA_CURRENCYConfiguration : IEntityTypeConfiguration<FNA_CURRENCY>
    {
        public void Configure(EntityTypeBuilder<FNA_CURRENCY> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.CURRENCY_ID, i.CURRENCY_CODE }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.FNA_CURRENCY_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.FNA_CURRENCY_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.FNA_CURRENCY)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

