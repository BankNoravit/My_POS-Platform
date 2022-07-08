using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class ORG_DEPARTMENTConfiguration : IEntityTypeConfiguration<ORG_DEPARTMENT>
    {
        public void Configure(EntityTypeBuilder<ORG_DEPARTMENT> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.DEPARTMENT_CODE }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.ORG_DEPARTMENT_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.DEPARTMENT_TYPE)
                   .WithMany(b => b.DEPARTMENT_TYPE)
                   .HasForeignKey(c => c.DEPARTMENT_TYPE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.ORG_DEPARTMENT_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_BRANCH)
                   .WithMany(b => b.ORG_DEPARTMENT)
                   .HasForeignKey(c => c.BRANCH_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.ORG_DEPARTMENT)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

