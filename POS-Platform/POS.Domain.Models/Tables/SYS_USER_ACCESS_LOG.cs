using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_USER_ACCESS_LOG")]
    public class SYS_USER_ACCESS_LOG
    {
        [Column(@"USER_ACCESS_LOG_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid USER_ACCESS_LOG_ID { get; set; } // USER_ACCESS_LOG_ID

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"USER_ACCESS_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid USER_ACCESS_ID { get; set; } // USER_ACCESS_ID (Primary key)

        [Column(@"COMMENTS", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 5, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 6, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 7, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 8, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 9, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_USER_ACCESS_LOG_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_USER_ACCESS_LOG_LAST_UPDATED_BY_ID
        public virtual SYS_USER_ACCESS SYS_USER_ACCESS { get; set; } // FK_SYS_USER_ACCESS_LOG_USER_ACCESS_ID

        public SYS_USER_ACCESS_LOG()
        {
        }
    }
}

