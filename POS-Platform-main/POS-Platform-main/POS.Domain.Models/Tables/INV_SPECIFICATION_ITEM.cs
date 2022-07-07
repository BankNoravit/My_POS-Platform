using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("INV_SPECIFICATION_ITEM")]
    public class INV_SPECIFICATION_ITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"SPECIFICATION_ITEM_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid SPECIFICATION_ITEM_ID { get; set; } // SPECIFICATION_ITEM_ID (Primary key)

        [Column(@"SPECIFICATION_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid SPECIFICATION_ID { get; set; } // SPECIFICATION_ID

        [Column(@"SEQ_NO", Order = 3, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SEQ_NO { get; set; } // SEQ_NO

        [Column(@"SPECIFICATION_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? SPECIFICATION_NAME_THA { get; set; } // SPECIFICATION_NAME_THA (length: 300)

        [Column(@"SPECIFICATION_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? SPECIFICATION_NAME_ENG { get; set; } // SPECIFICATION_NAME_ENG (length: 300)

        [Column(@"COMMENTS", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 8, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 9, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 10, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 11, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 12, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual INV_SPECIFICATION INV_SPECIFICATION { get; set; } // FK_INV_SPECIFICATION_ITEM_SPECIFICATION_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_INV_SPECIFICATION_ITEM_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_INV_SPECIFICATION_ITEM_LAST_UPDATED_BY_ID

        public INV_SPECIFICATION_ITEM()
        {
        }
    }
}

