using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class SYS_COLUMNConfiguration : IEntityTypeConfiguration<SYS_COLUMN>
    {
        public void Configure(EntityTypeBuilder<SYS_COLUMN> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.SYS_COLUMN_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.SYS_COLUMN_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_MENU)
                   .WithMany(b => b.SYS_COLUMN)
                   .HasForeignKey(c => c.MENU_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

