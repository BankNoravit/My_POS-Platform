using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class ORG_EMPLOYEEConfiguration : IEntityTypeConfiguration<ORG_EMPLOYEE>
    {
        public void Configure(EntityTypeBuilder<ORG_EMPLOYEE> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.EMPLOYEE_CODE }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.ORG_EMPLOYEE_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.ORG_EMPLOYEE_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_EMPLOYEE_LEADER)
                   .WithMany(b => b.ORG_EMPLOYEE_CHILD)
                   .HasForeignKey(c => c.LEADER_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

