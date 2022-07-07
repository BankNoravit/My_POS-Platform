using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ORG_BRANCH_GROUP")]
    public class ORG_BRANCH_GROUP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"BRANCH_GROUP_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid BRANCH_GROUP_ID { get; set; } // BRANCH_GROUP_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"BRANCH_GROUP_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? BRANCH_GROUP_CODE { get; set; } // BRANCH_GROUP_CODE (length: 50)

        [Column(@"BRANCH_GROUP_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? BRANCH_GROUP_NAME_THA { get; set; } // BRANCH_GROUP_NAME_THA (length: 300)

        [Column(@"BRANCH_GROUP_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? BRANCH_GROUP_NAME_ENG { get; set; } // BRANCH_GROUP_NAME_ENG (length: 300)

        [Column(@"BRANCH_GROUP_TYPE_ID", Order = 6, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? BRANCH_GROUP_TYPE_ID { get; set; } // BRANCH_GROUP_TYPE_ID

        [Column(@"BRANCH_GROUP_OWNER_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? BRANCH_GROUP_OWNER_ID { get; set; } // BRANCH_GROUP_OWNER_ID

        [Column(@"COMMENTS", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 9, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 10, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 11, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 12, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 14, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<ORG_BRANCH_GROUP_ITEM> ORG_BRANCH_GROUP_ITEM { get; set; } // ORG_BRANCH_GROUP_ITEM.FK_ORG_BRANCH_GROUP_ITEM_BRANCH_GROUP_ID

        public virtual ORG_EMPLOYEE BRANCH_GROUP_OWNER { get; set; } // FK_ORG_BRANCH_GROUP_BRANCH_GROUP_OWNER_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_ORG_BRANCH_GROUP_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ORG_BRANCH_GROUP_LAST_UPDATED_BY_ID

        public ORG_BRANCH_GROUP()
        {
            this.ORG_BRANCH_GROUP_ITEM = new List<ORG_BRANCH_GROUP_ITEM>();
        }
    }
}

