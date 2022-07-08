using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SAL_CUSTOMER_BANK_ACCOUNT")]
    public class SAL_CUSTOMER_BANK_ACCOUNT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"CUSTOMER_BANK_ACCOUNT_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid CUSTOMER_BANK_ACCOUNT_ID { get; set; } // CUSTOMER_BANK_ACCOUNT_ID (Primary key)

        [Column(@"CUSTOMER_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CUSTOMER_ID { get; set; } // CUSTOMER_ID

        [Column(@"BANK_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BANK_ID { get; set; } // BANK_ID

        [Column(@"BANK_BRANCH_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BANK_BRANCH_ID { get; set; } // BANK_BRANCH_ID

        [Column(@"BANK_ACCOUNT_NAME", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? BANK_ACCOUNT_NAME { get; set; } // BANK_ACCOUNT_NAME (length: 300)

        [Column(@"BANK_ACCOUNT_NUMBER", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? BANK_ACCOUNT_NUMBER { get; set; } // BANK_ACCOUNT_NUMBER (length: 300)

        [Column(@"IS_DEFALUT", Order = 7, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DEFALUT { get; set; } // IS_DEFALUT

        [Column(@"COMMENTS", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 9, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 10, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 11, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 12, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 14, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual FNA_BANK FNA_BANK { get; set; } // FK_SAL_CUSTOMER_BANK_ACCOUNT_BANK_ID
        public virtual FNA_BANK_BRANCH FNA_BANK_BRANCH { get; set; } // FK_SAL_CUSTOMER_BANK_ACCOUNT_BANK_BRANCH_ID
        public virtual SAL_CUSTOMER SAL_CUSTOMER { get; set; } // FK_SAL_CUSTOMER_BANK_ACCOUNT_CUSTOMER_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SAL_CUSTOMER_BANK_ACCOUNT_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SAL_CUSTOMER_BANK_ACCOUNT_LAST_UPDATED_BY_ID

        public SAL_CUSTOMER_BANK_ACCOUNT()
        {
        }
    }
}

