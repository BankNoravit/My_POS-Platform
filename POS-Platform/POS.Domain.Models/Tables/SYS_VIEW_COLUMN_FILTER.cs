using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_VIEW_COLUMN_FILTER")]
    public class SYS_VIEW_COLUMN_FILTER
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"VIEW_COLUMN_FILTER_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid VIEW_COLUMN_FILTER_ID { get; set; } // VIEW_COLUMN_FILTER_ID (Primary key)

        [Column(@"VIEW_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VIEW_ID { get; set; } // VIEW_ID

        [Column(@"COLUMN_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COLUMN_ID { get; set; } // COLUMN_ID

        [Column(@"SEQ_NO", Order = 4, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SEQ_NO { get; set; } // SEQ_NO

        [Column(@"IS_FORCE_FILTER", Order = 5, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_FORCE_FILTER { get; set; } // IS_FORCE_FILTER

        [Column(@"OPERATOR_ID", Order = 6, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid OPERATOR_ID { get; set; } // OPERATOR_ID

        [Column(@"LIMIT_FILTER", Order = 7, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int LIMIT_FILTER { get; set; } // LIMIT_FILTER

        [Column(@"FILTER_VALUE_1", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? FILTER_VALUE_1 { get; set; } // FILTER_VALUE_1 (length: 4000)

        [Column(@"FILTER_VALUE_2", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? FILTER_VALUE_2 { get; set; } // FILTER_VALUE_2 (length: 300)

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

        public virtual SYS_COLUMN SYS_COLUMN { get; set; } // FK_VIEW_COLUMN_FILTER_COLUMN_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_VIEW_COLUMN_FILTER_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_VIEW_COLUMN_FILTER_LAST_UPDATED_BY_ID
        public virtual SYS_VIEW SYS_VIEW { get; set; } // FK_VIEW_COLUMN_FILTER_VIEW_ID

        public SYS_VIEW_COLUMN_FILTER()
        {
        }
    }

}

