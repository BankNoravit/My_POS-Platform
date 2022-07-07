using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ORG_BRANCH_GROUP_ITEM")]
    public class ORG_BRANCH_GROUP_ITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"BRANCH_GROUP_ITEM_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid BRANCH_GROUP_ITEM_ID { get; set; } // BRANCH_GROUP_ITEM_ID (Primary key)

        [Column(@"BRANCH_GROUP_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BRANCH_GROUP_ID { get; set; } // BRANCH_GROUP_ID

        [Column(@"BRANCH_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BRANCH_ID { get; set; } // BRANCH_ID

        [Column(@"COMMENTS", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 5, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 6, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 8, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 9, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 10, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ORG_BRANCH ORG_BRANCH { get; set; } // FK_ORG_BRANCH_GROUP_ITEM_BRANCH_ID
        public virtual ORG_BRANCH_GROUP ORG_BRANCH_GROUP { get; set; } // FK_ORG_BRANCH_GROUP_ITEM_BRANCH_GROUP_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_ORG_BRANCH_GROUP_ITEM_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ORG_BRANCH_GROUP_ITEM_LAST_UPDATED_BY_ID

        public ORG_BRANCH_GROUP_ITEM()
        {
        }
    }
}

