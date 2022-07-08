using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_USER_ACCESS")]
    public class SYS_USER_ACCESS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"USER_ACCESS_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid USER_ACCESS_ID { get; set; } // USER_ACCESS_ID (Primary key)

        [Column(@"USER_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid USER_ID { get; set; } // USER_ID

        [Column(@"REMOTE_ADDR", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? REMOTE_ADDR { get; set; } // REMOTE_ADDR (length: 50)

        [Column(@"USER_AGENT", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_500)]
        [MaxLength(500)]
        public string? USER_AGENT { get; set; } // USER_AGENT (length: 500)

        [Column(@"IS_ACCESS_TOKEN_REVOKED", Order = 5, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACCESS_TOKEN_REVOKED { get; set; } // IS_ACCESS_TOKEN_REVOKED

        [Column(@"ACCESS_TOKEN", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_2000)]
        [MaxLength(2000)]
        public string? ACCESS_TOKEN { get; set; } // ACCESS_TOKEN (length: 2000)

        [Column(@"ACCESS_TOKEN_EXPIRED_DATE", Order = 7, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? ACCESS_TOKEN_EXPIRED_DATE { get; set; } // ACCESS_TOKEN_EXPIRED_DATE

        [Column(@"IS_REFRESH_TOKEN_REVOKED", Order = 8, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_REFRESH_TOKEN_REVOKED { get; set; } // IS_REFRESH_TOKEN_REVOKED

        [Column(@"REFRESH_TOKEN", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_2000)]
        [MaxLength(2000)]
        public string? REFRESH_TOKEN { get; set; } // REFRESH_TOKEN (length: 2000)

        [Column(@"REFRESH_TOKEN_EXPIRED_DATE", Order = 10, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? REFRESH_TOKEN_EXPIRED_DATE { get; set; } // REFRESH_TOKEN_EXPIRED_DATE

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

        public virtual SYS_USER_ACCESS_LOG SYS_USER_ACCESS_LOG { get; set; } // SYS_USER_ACCESS_LOG.FK_SYS_USER_ACCESS_LOG_USER_ACCESS_ID

        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_USER_ACCESS_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_USER_ACCESS_LAST_UPDATED_BY_ID
        public virtual SYS_USER SYS_USER { get; set; } // FK_SYS_USER_ACCESS_USER_ID

        public SYS_USER_ACCESS()
        {
        }
    }
}

