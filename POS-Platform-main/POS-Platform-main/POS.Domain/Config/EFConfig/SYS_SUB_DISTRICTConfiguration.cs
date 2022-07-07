using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class SYS_SUB_DISTRICTConfiguration : IEntityTypeConfiguration<SYS_SUB_DISTRICT>
    {
        public void Configure(EntityTypeBuilder<SYS_SUB_DISTRICT> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.SYS_SUB_DISTRICT_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.SYS_SUB_DISTRICT_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_DISTRICT)
                   .WithMany(b => b.SYS_SUB_DISTRICT)
                   .HasForeignKey(c => c.DISTRICT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

