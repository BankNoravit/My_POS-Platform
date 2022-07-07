using POS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace POS.Domain.Config.EFConfig
{
    public class SYS_USERConfiguration : IEntityTypeConfiguration<SYS_USER>
    {
        public void Configure(EntityTypeBuilder<SYS_USER> builder)
        {
            // Create Table Description For: Domain 
            // -----------------

            // Create Unique Key & Column Description 
            // -----------------

            // Create Foreign Key
            // ------------------
            builder.HasOne(a => a.ORG_COMPANY)
                   .WithMany(b => b.SYS_USER)
                   .HasForeignKey(c => c.COMPANY_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.ORG_EMPLOYEE)
                   .WithMany(b => b.SYS_USER)
                   .HasForeignKey(c => c.EMPLOYEE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_USER_CREATER)
                    .WithMany(b => b.SYS_USER_CREATED_CHILD)
                    .HasForeignKey(c => c.CREATED_BY_ID)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.SYS_USER_UPDATER)
                   .WithMany(b => b.SYS_USER_UPDATED_CHILD)
                   .HasForeignKey(c => c.LAST_UPDATED_BY_ID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

}

