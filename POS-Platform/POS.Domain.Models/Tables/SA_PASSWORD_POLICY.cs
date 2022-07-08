using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SA_PASSWORD_POLICY")]
    public class SA_PASSWORD_POLICY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"PASSWORD_POLICY_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid PASSWORD_POLICY_ID { get; set; } // PASSWORD_POLICY_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"IS_SIGNON_PASSWORD_CASE", Order = 3, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_SIGNON_PASSWORD_CASE { get; set; } // IS_SIGNON_PASSWORD_CASE

        [Column(@"SIGNON_PASSWORD_FAILURE_LIMIT", Order = 4, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SIGNON_PASSWORD_FAILURE_LIMIT { get; set; } // SIGNON_PASSWORD_FAILURE_LIMIT

        [Column(@"IS_SIGNON_PASSWORD_HARD_TO_GUESS", Order = 5, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_SIGNON_PASSWORD_HARD_TO_GUESS { get; set; } // IS_SIGNON_PASSWORD_HARD_TO_GUESS

        [Column(@"SIGNON_PASSWORD_LENGTH", Order = 6, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SIGNON_PASSWORD_LENGTH { get; set; } // SIGNON_PASSWORD_LENGTH

        [Column(@"SIGNON_PASSWORD_NO_REUSE_DAYS", Order = 7, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SIGNON_PASSWORD_NO_REUSE_DAYS { get; set; } // SIGNON_PASSWORD_NO_REUSE_DAYS

        [Column(@"IS_SIGNON_PASSWORD_EXPIRED", Order = 8, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_SIGNON_PASSWORD_EXPIRED { get; set; } // IS_SIGNON_PASSWORD_EXPIRED

        [Column(@"SIGNON_PASSWORD_EXPIRED_DAYS", Order = 9, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SIGNON_PASSWORD_EXPIRED_DAYS { get; set; } // SIGNON_PASSWORD_EXPIRED_DAYS

        [Column(@"COMMENTS", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 11, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 12, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 13, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 14, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 15, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 16, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_SYS_PASSWORD_POLICY_COMPANY_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SA_PASSWORD_POLICY_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SA_PASSWORD_POLICY_LAST_UPDATED_BY_ID

        public SA_PASSWORD_POLICY()
        {
        }
    }
}

