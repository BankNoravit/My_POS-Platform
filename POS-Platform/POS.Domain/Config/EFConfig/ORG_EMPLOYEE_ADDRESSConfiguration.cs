using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class ORG_EMPLOYEE_ADDRESSConfiguration : IEntityTypeConfiguration<ORG_EMPLOYEE_ADDRESS>
    {
        public void Configure(EntityTypeBuilder<ORG_EMPLOYEE_ADDRESS> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.ORG_EMPLOYEE_ADDRESS_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.ORG_EMPLOYEE_ADDRESS_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_EMPLOYEE)
                   .WithMany(b => b.ORG_EMPLOYEE_ADDRESS)
                   .HasForeignKey(c => c.EMPLOYEE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_DISTRICT)
                   .WithMany(b => b.ORG_EMPLOYEE_ADDRESS)
                   .HasForeignKey(c => c.DISTRICT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_SUB_DISTRICT)
                   .WithMany(b => b.ORG_EMPLOYEE_ADDRESS)
                   .HasForeignKey(c => c.SUB_DISTRICT_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

