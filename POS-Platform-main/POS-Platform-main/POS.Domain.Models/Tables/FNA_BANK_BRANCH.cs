using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("FNA_BANK_BRANCH")]
    public class FNA_BANK_BRANCH
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"BANK_BRANCH_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid BANK_BRANCH_ID { get; set; } // BANK_BRANCH_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"BANK_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BANK_ID { get; set; } // BANK_ID

        [Column(@"BANK_BRANCH_CODE", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? BANK_BRANCH_CODE { get; set; } // BANK_BRANCH_CODE (length: 50)

        [Column(@"BANK_BRANCH_NAME_THA", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? BANK_BRANCH_NAME_THA { get; set; } // BANK_BRANCH_NAME_THA (length: 300)

        [Column(@"BANK_BRANCH_NAME_ENG", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? BANK_BRANCH_NAME_ENG { get; set; } // BANK_BRANCH_NAME_ENG (length: 300)

        [Column(@"COMMENTS", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 8, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 9, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 10, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 11, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 12, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<FNA_BANK_ACCOUNT> FNA_BANK_ACCOUNT { get; set; } // FNA_BANK_ACCOUNT.FK_FNA_BANK_ACCOUNT_BANK_BRANCH_ID
        public virtual ICollection<PUR_VENDOR_BANK_ACCOUNT> PUR_VENDOR_BANK_ACCOUNT { get; set; } // PUR_VENDOR_BANK_ACCOUNT.FK_PUR_VENDOR_BANK_ACCOUNT_BANK_BRANCH_ID
        public virtual ICollection<SAL_CUSTOMER_BANK_ACCOUNT> SAL_CUSTOMER_BANK_ACCOUNT { get; set; } // SAL_CUSTOMER_BANK_ACCOUNT.FK_SAL_CUSTOMER_BANK_ACCOUNT_BANK_BRANCH_ID

        public virtual FNA_BANK FNA_BANK { get; set; } // FK_FNA_BANK_BRANCH_BANK_ID
        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_FNA_BANK_BRANCH_COMPANY_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_FNA_BANK_BRANCH_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_FNA_BANK_BRANCH_LAST_UPDATED_BY_ID

        public FNA_BANK_BRANCH()
        {
            this.FNA_BANK_ACCOUNT = new List<FNA_BANK_ACCOUNT>();
            this.PUR_VENDOR_BANK_ACCOUNT = new List<PUR_VENDOR_BANK_ACCOUNT>();
            this.SAL_CUSTOMER_BANK_ACCOUNT = new List<SAL_CUSTOMER_BANK_ACCOUNT>();
        }
    }
}

