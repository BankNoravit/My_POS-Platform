using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_VIEW")]
    public class SYS_VIEW
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"VIEW_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid VIEW_ID { get; set; } // VIEW_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"MENU_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid MENU_ID { get; set; } // MENU_ID

        [Column(@"USER_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? USER_ID { get; set; } // USER_ID

        [Column(@"SEQ_NO", Order = 5, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SEQ_NO { get; set; } // SEQ_NO

        [Column(@"VIEW_NAME_THA", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? VIEW_NAME_THA { get; set; } // VIEW_NAME_THA (length: 300)

        [Column(@"VIEW_NAME_ENG", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? VIEW_NAME_ENG { get; set; } // VIEW_NAME_ENG (length: 300)

        [Column(@"IS_STANDARD", Order = 8, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_STANDARD { get; set; } // IS_STANDARD

        [Column(@"IS_DEFAULT", Order = 9, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DEFAULT { get; set; } // IS_DEFAULT

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

        public virtual ICollection<SYS_VIEW_COLUMN_FILTER> SYS_VIEW_COLUMN_FILTER { get; set; } // SYS_VIEW_COLUMN_FILTER.FK_VIEW_COLUMN_FILTER_VIEW_ID
        public virtual ICollection<SYS_VIEW_COLUMN> SYS_VIEW_COLUMN { get; set; } // SYS_VIEW_COLUMN.FK_SYS_VIEW_COLUMN_VIEW_ID

        public virtual SYS_MENU SYS_MENU { get; set; } // FK_SYS_VIEW_MENU_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_VIEW_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_VIEW_LAST_UPDATED_BY_ID

        public SYS_VIEW()
        {
            this.SYS_VIEW_COLUMN = new List<SYS_VIEW_COLUMN>();
            this.SYS_VIEW_COLUMN_FILTER = new List<SYS_VIEW_COLUMN_FILTER>();
        }
    }
}

