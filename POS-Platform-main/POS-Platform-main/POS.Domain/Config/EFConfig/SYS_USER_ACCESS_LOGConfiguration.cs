using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class SYS_USER_ACCESS_LOGConfiguration : IEntityTypeConfiguration<SYS_USER_ACCESS_LOG>
    {
        public void Configure(EntityTypeBuilder<SYS_USER_ACCESS_LOG> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.SYS_USER_ACCESS_LOG_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.SYS_USER_ACCESS_LOG_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_USER_ACCESS)
                   .WithOne(b => b.SYS_USER_ACCESS_LOG)
                   .HasForeignKey<SYS_USER_ACCESS_LOG>(c => c.USER_ACCESS_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

