using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class ORG_BRANCHConfiguration : IEntityTypeConfiguration<ORG_BRANCH>
    {
        public void Configure(EntityTypeBuilder<ORG_BRANCH> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.BRANCH_CODE }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.ORG_BRANCH_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.ORG_BRANCH_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LOCATION)
                   .WithMany(b => b.LOCATION)
                   .HasForeignKey(c => c.LOCATION_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.MANAGER)
                   .WithMany(b => b.MANAGER)
                   .HasForeignKey(c => c.MANAGER_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_FRANCHISEE)
                   .WithMany(b => b.ORG_BRANCH)
                   .HasForeignKey(c => c.FRANCHISEE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

