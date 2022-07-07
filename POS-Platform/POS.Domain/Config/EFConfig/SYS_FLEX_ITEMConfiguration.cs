using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class SYS_FLEX_ITEMConfiguration : IEntityTypeConfiguration<SYS_FLEX_ITEM>
    {
        public void Configure(EntityTypeBuilder<SYS_FLEX_ITEM> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.FLEX_ID, i.FLEX_ITEM_CODE }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.SYS_FLEX_ITEM_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.SYS_FLEX_ITEM_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_FLEX)
                   .WithMany(b => b.SYS_FLEX_ITEM)
                   .HasForeignKey(c => c.FLEX_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

