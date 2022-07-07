using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_MENU")]
    public class SYS_MENU
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"MENU_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid MENU_ID { get; set; } // MENU_ID (Primary key)

        [Column(@"PARENT_MENU_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PARENT_MENU_ID { get; set; } // PARENT_MENU_ID

        [Column(@"OBJECT_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? OBJECT_ID { get; set; } // OBJECT_ID

        [Column(@"SEQ_NO", Order = 4, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SEQ_NO { get; set; } // SEQ_NO

        [Column(@"MENU_CODE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? MENU_CODE { get; set; } // MENU_CODE (length: 50)

        [Column(@"MENU_NAME", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? MENU_NAME { get; set; } // MENU_NAME (length: 300)

        [Column(@"MENU_TYPE", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? MENU_TYPE { get; set; } // MENU_TYPE (length: 50)

        [Column(@"URL", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? URL { get; set; } // URL (length: 300)

        [Column(@"CSS_CLASS_ICON", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_500)]
        [MaxLength(500)]
        public string? CSS_CLASS_ICON { get; set; } // CSS_CLASS_ICON (length: 500)

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

        public virtual ICollection<SYS_COLUMN> SYS_COLUMN { get; set; } // SYS_COLUMN.FK_SYS_COLUMN_MENU_ID
        public virtual ICollection<SYS_MENU_LANG> SYS_MENU_LANG { get; set; } // SYS_MENU_LANG.FK_SYS_MENU_LANG_MENU_ID
        [InverseProperty("SYS_MENU_PARENT_MENU")]
        public virtual ICollection<SYS_MENU> SYS_MENU_CHILD { get; set; } // SYS_MENU.FK_SYS_MENU_PARENT_MENU_ID
        public virtual ICollection<SYS_VIEW> SYS_VIEW { get; set; } // SYS_VIEW.FK_SYS_VIEW_MENU_ID

        public virtual SYS_MENU SYS_MENU_PARENT_MENU { get; set; } // FK_SYS_MENU_PARENT_MENU_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_MENU_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_MENU_LAST_UPDATED_BY_ID

        public SYS_MENU()
        {
            this.SYS_COLUMN = new List<SYS_COLUMN>();
            this.SYS_MENU_CHILD = new List<SYS_MENU>();
            this.SYS_MENU_LANG = new List<SYS_MENU_LANG>();
            this.SYS_VIEW = new List<SYS_VIEW>();
        }
    }
}

