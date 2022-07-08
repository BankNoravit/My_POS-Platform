using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class ORG_BRANCH_GROUP_ITEMConfiguration : IEntityTypeConfiguration<ORG_BRANCH_GROUP_ITEM>
    {
        public void Configure(EntityTypeBuilder<ORG_BRANCH_GROUP_ITEM> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.ORG_BRANCH_GROUP_ITEM_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.ORG_BRANCH_GROUP_ITEM_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_BRANCH)
                   .WithMany(b => b.ORG_BRANCH_GROUP_ITEM)
                   .HasForeignKey(c => c.BRANCH_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_BRANCH_GROUP)
                   .WithMany(b => b.ORG_BRANCH_GROUP_ITEM)
                   .HasForeignKey(c => c.BRANCH_GROUP_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

