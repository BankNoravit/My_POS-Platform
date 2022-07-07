using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_COLUMN_LANG")]
    public class SYS_COLUMN_LANG
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"COLUMN_LANG_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid COLUMN_LANG_ID { get; set; } // COLUMN_LANG_ID (Primary key)

        [Column(@"COLUMN_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COLUMN_ID { get; set; } // COLUMN_ID

        [Column(@"LANG_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_3)]
        [Required]
        [MaxLength(3)]
        public string? LANG_CODE { get; set; } // LANG_CODE (length: 3)

        [Column(@"DISPLAY_NAME", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? DISPLAY_NAME { get; set; } // DISPLAY_NAME (length: 300)

        [Column(@"COMMENTS", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 6, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 7, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 8, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 9, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 10, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 11, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual SYS_COLUMN SYS_COLUMN { get; set; } // FK_SYS_COLUMN_LANG_COLUMN_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_COLUMN_LANG_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_COLUMN_LANG_LAST_UPDATED_BY_ID

        public SYS_COLUMN_LANG()
        {
        }
    }
}

