using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("FNA_BANK_ACCOUNT")]
    public class FNA_BANK_ACCOUNT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"BANK_ACCOUNT_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid BANK_ACCOUNT_ID { get; set; } // BANK_ACCOUNT_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"BANK_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BANK_ID { get; set; } // BANK_ID

        [Column(@"BANK_BRANCH_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BANK_BRANCH_ID { get; set; } // BANK_BRANCH_ID

        [Column(@"BANK_ACCOUNT_CODE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? BANK_ACCOUNT_CODE { get; set; } // BANK_ACCOUNT_CODE (length: 50)

        [Column(@"BANK_ACCOUNT_NAME_THA", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? BANK_ACCOUNT_NAME_THA { get; set; } // BANK_ACCOUNT_NAME_THA (length: 300)

        [Column(@"BANK_ACCOUNT_NAME_ENG", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? BANK_ACCOUNT_NAME_ENG { get; set; } // BANK_ACCOUNT_NAME_ENG (length: 300)

        [Column(@"BANK_ACCOUNT_NUMBER", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? BANK_ACCOUNT_NUMBER { get; set; } // BANK_ACCOUNT_NUMBER (length: 300)

        [Column(@"BALANCE_AMOUNT", Order = 9, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal BALANCE_AMOUNT { get; set; } // BALANCE_AMOUNT

        [Column(@"BALANCE_AS_OF_DATE", Order = 10, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime BALANCE_AS_OF_DATE { get; set; } // BALANCE_AS_OF_DATE

        [Column(@"COMMENTS", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 12, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 13, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 14, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 15, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 16, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 17, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual FNA_BANK FNA_BANK { get; set; } // FK_FNA_BANK_ACCOUNT_BANK_ID
        public virtual FNA_BANK_BRANCH FNA_BANK_BRANCH { get; set; } // FK_FNA_BANK_ACCOUNT_BANK_BRANCH_ID
        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_FNA_BANK_ACCOUNT_COMPANY_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_FNA_BANK_ACCOUNT_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_FNA_BANK_ACCOUNT_LAST_UPDATED_BY_ID

        public FNA_BANK_ACCOUNT()
        {
        }
    }
}

