using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class INV_WAREHOUSE_LOCATIONConfiguration : IEntityTypeConfiguration<INV_WAREHOUSE_LOCATION>
    {
        public void Configure(EntityTypeBuilder<INV_WAREHOUSE_LOCATION> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.WAREHOUSE_ID, i.WAREHOUSE_LOCATION_CODE }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.INV_WAREHOUSE_LOCATION_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE)
                   .WithMany(b => b.INV_WAREHOUSE_LOCATION)
                   .HasForeignKey(c => c.WAREHOUSE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.INV_WAREHOUSE_LOCATION_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

