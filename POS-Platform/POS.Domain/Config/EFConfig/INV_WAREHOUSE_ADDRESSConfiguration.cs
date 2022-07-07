using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class INV_WAREHOUSE_ADDRESSConfiguration : IEntityTypeConfiguration<INV_WAREHOUSE_ADDRESS>
    {
        public void Configure(EntityTypeBuilder<INV_WAREHOUSE_ADDRESS> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.INV_WAREHOUSE_ADDRESS_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.INV_WAREHOUSE)
                   .WithMany(b => b.INV_WAREHOUSE_ADDRESS)
                   .HasForeignKey(c => c.WAREHOUSE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.INV_WAREHOUSE_ADDRESS_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_DISTRICT)
                   .WithMany(b => b.INV_WAREHOUSE_ADDRESS)
                   .HasForeignKey(c => c.DISTRICT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_SUB_DISTRICT)
                   .WithMany(b => b.INV_WAREHOUSE_ADDRESS)
                   .HasForeignKey(c => c.SUB_DISTRICT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

