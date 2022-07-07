using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class ORG_BRANCH_GROUPConfiguration : IEntityTypeConfiguration<ORG_BRANCH_GROUP>
    {
        public void Configure(EntityTypeBuilder<ORG_BRANCH_GROUP> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------
            builder.HasIndex(i => new { i.COMPANY_ID, i.BRANCH_GROUP_CODE }).IsUnique();

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.BRANCH_GROUP_OWNER)
                   .WithMany(b => b.BRANCH_GROUP_OWNER)
                   .HasForeignKey(c => c.BRANCH_GROUP_OWNER_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.ORG_BRANCH_GROUP_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.ORG_BRANCH_GROUP_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

