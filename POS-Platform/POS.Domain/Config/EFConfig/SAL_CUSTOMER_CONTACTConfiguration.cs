using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class SAL_CUSTOMER_CONTACTConfiguration : IEntityTypeConfiguration<SAL_CUSTOMER_CONTACT>
    {
        public void Configure(EntityTypeBuilder<SAL_CUSTOMER_CONTACT> builder)
        {
            // Create Table Description For: Domain 
            // -----------------
            
            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.CREATED_BY)
                   .WithMany(b => b.SAL_CUSTOMER_CONTACT_CREATED_BY)
                   .HasForeignKey(c => c.CREATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.LAST_UPDATED_BY)
                   .WithMany(b => b.SAL_CUSTOMER_CONTACT_LAST_UPDATED_BY)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SAL_CUSTOMER)
                   .WithMany(b => b.SAL_CUSTOMER_CONTACT)
                   .HasForeignKey(c => c.CUSTOMER_ID)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }

}

