using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_COLUMN")]
    public class SYS_COLUMN
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"COLUMN_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid COLUMN_ID { get; set; } // COLUMN_ID (Primary key)

        [Column(@"MENU_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid MENU_ID { get; set; } // MENU_ID

        [Column(@"SEQ_NO", Order = 3, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SEQ_NO { get; set; } // SEQ_NO

        [Column(@"EXPAND", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? EXPAND { get; set; } // EXPAND (length: 300)

        [Column(@"FIELD", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? FIELD { get; set; } // FIELD (length: 300)

        [Column(@"HEADER_TEXT", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? HEADER_TEXT { get; set; } // HEADER_TEXT (length: 300)

        [Column(@"TEXT_ALIGN", Order = 7, TypeName = SQLSERVER_CONST.INT)]
        public int? TEXT_ALIGN { get; set; } // TEXT_ALIGN

        [Column(@"TYPE", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? TYPE { get; set; } // TYPE (length: 300)

        [Column(@"IS_ALLOW_SEARCHING", Order = 9, TypeName = SQLSERVER_CONST.BIT)]
        public bool? IS_ALLOW_SEARCHING { get; set; } // IS_ALLOW_SEARCHING

        [Column(@"WIDTH", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_10)]
        [MaxLength(10)]
        public string? WIDTH { get; set; } // WIDTH (length: 10)

        [Column(@"IS_PRIMARY_KEY", Order = 11, TypeName = SQLSERVER_CONST.BIT)]
        public bool? IS_PRIMARY_KEY { get; set; } // IS_PRIMARY_KEY

        [Column(@"IS_VISIBLE", Order = 12, TypeName = SQLSERVER_CONST.BIT)]
        public bool? IS_VISIBLE { get; set; } // IS_VISIBLE

        [Column(@"IS_SHOW_IN_COLUMN_CHOOSER", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        public bool? IS_SHOW_IN_COLUMN_CHOOSER { get; set; } // IS_SHOW_IN_COLUMN_CHOOSER

        [Column(@"FORMAT", Order = 14, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? FORMAT { get; set; } // FORMAT (length: 50)

        [Column(@"IS_ORDER_BY", Order = 15, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ORDER_BY { get; set; } // IS_ORDER_BY

        [Column(@"ORDER_BY", Order = 16, TypeName = SQLSERVER_CONST.VARCHAR_5)]
        [MaxLength(5)]
        public string? ORDER_BY { get; set; } // ORDER_BY (length: 5)

        [Column(@"COMMENTS", Order = 17, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 18, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 19, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 20, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 21, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 22, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 23, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<SYS_COLUMN_LANG> SYS_COLUMN_LANG { get; set; } // SYS_COLUMN_LANG.FK_SYS_COLUMN_LANG_COLUMN_ID
        public virtual ICollection<SYS_VIEW_COLUMN_FILTER> SYS_VIEW_COLUMN_FILTER { get; set; } // SYS_VIEW_COLUMN_FILTER.FK_VIEW_COLUMN_FILTER_COLUMN_ID
        public virtual ICollection<SYS_VIEW_COLUMN> SYS_VIEW_COLUMN { get; set; } // SYS_VIEW_COLUMN.FK_SYS_VIEW_COLUMN_COLUMN_ID

        public virtual SYS_MENU SYS_MENU { get; set; } // FK_SYS_COLUMN_MENU_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_COLUMN_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_COLUMN_LAST_UPDATED_BY_ID

        public SYS_COLUMN()
        {
            this.SYS_COLUMN_LANG = new List<SYS_COLUMN_LANG>();
            this.SYS_VIEW_COLUMN = new List<SYS_VIEW_COLUMN>();
            this.SYS_VIEW_COLUMN_FILTER = new List<SYS_VIEW_COLUMN_FILTER>();
        }
    }
}

