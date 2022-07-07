using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_FLEX")]
    public class SYS_FLEX
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"FLEX_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid FLEX_ID { get; set; } // FLEX_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"FLEX_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? FLEX_CODE { get; set; } // FLEX_CODE (length: 50)

        [Column(@"FLEX_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? FLEX_NAME_THA { get; set; } // FLEX_NAME_THA (length: 300)

        [Column(@"FLEX_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? FLEX_NAME_ENG { get; set; } // FLEX_NAME_ENG (length: 300)

        [Column(@"IS_ENABLED", Order = 6, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ENABLED { get; set; } // IS_ENABLED

        [Column(@"COMMENTS", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 8, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 9, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 10, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 11, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 12, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<SYS_FLEX_ITEM> SYS_FLEX_ITEM { get; set; } // SYS_FLEX_ITEM.FK_SYS_FLEX_ITEM_FLEX_ID

        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_SYS_FLEX_COMPANY_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_FLEX_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_FLEX_LAST_UPDATED_BY_ID

        public SYS_FLEX()
        {
            this.SYS_FLEX_ITEM = new List<SYS_FLEX_ITEM>();
        }
    }
}

