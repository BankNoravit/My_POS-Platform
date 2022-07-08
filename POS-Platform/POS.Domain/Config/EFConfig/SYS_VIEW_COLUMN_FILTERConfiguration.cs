using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class SYS_VIEW_COLUMN_FILTERConfiguration : IEntityTypeConfiguration<SYS_VIEW_COLUMN_FILTER>
    {
        public void Configure(EntityTypeBuilder<SYS_VIEW_COLUMN_FILTER> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.SYS_VIEW_COLUMN_FILTER_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.SYS_VIEW_COLUMN_FILTER_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_COLUMN)
                   .WithMany(b => b.SYS_VIEW_COLUMN_FILTER)
                   .HasForeignKey(c => c.COLUMN_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_VIEW)
                   .WithMany(b => b.SYS_VIEW_COLUMN_FILTER)
                   .HasForeignKey(c => c.VIEW_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}

