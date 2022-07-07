using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_VIEW_COLUMN")]
    public class SYS_VIEW_COLUMN
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"VIEW_COLUMN_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid VIEW_COLUMN_ID { get; set; } // VIEW_COLUMN_ID (Primary key)

        [Column(@"VIEW_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VIEW_ID { get; set; } // VIEW_ID

        [Column(@"COLUMN_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COLUMN_ID { get; set; } // COLUMN_ID

        [Column(@"SEQ_NO", Order = 4, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SEQ_NO { get; set; } // SEQ_NO

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

        public virtual SYS_COLUMN SYS_COLUMN { get; set; } // FK_SYS_VIEW_COLUMN_COLUMN_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_VIEW_COLUMN_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_VIEW_COLUMN_LAST_UPDATED_BY_ID
        public virtual SYS_VIEW SYS_VIEW { get; set; } // FK_SYS_VIEW_COLUMN_VIEW_ID

        public SYS_VIEW_COLUMN()
        {
        }
    }
}

