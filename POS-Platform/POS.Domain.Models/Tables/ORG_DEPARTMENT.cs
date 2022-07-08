using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ORG_DEPARTMENT")]
    public class ORG_DEPARTMENT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"DEPARTMENT_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid DEPARTMENT_ID { get; set; } // DEPARTMENT_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"DEPARTMENT_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? DEPARTMENT_CODE { get; set; } // DEPARTMENT_CODE (length: 50)

        [Column(@"DEPARTMENT_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? DEPARTMENT_NAME_THA { get; set; } // DEPARTMENT_NAME_THA (length: 300)

        [Column(@"DEPARTMENT_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? DEPARTMENT_NAME_ENG { get; set; } // DEPARTMENT_NAME_ENG (length: 300)

        [Column(@"DEPARTMENT_TYPE_ID", Order = 6, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? DEPARTMENT_TYPE_ID { get; set; } // DEPARTMENT_TYPE_ID

        [Column(@"BRANCH_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? BRANCH_ID { get; set; } // BRANCH_ID

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

        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_DEPARTMENT_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_DEPARTMENT_ID

        public virtual ORG_BRANCH ORG_BRANCH { get; set; } // FK_ORG_DEPARTMENT_BRANCH_ID
        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_ORG_DEPARTMENT_COMPANY_ID
        public virtual SYS_FLEX_ITEM DEPARTMENT_TYPE { get; set; } // FK_ORG_DEPARTMENT_DEPARTMENT_TYPE_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_ORG_DEPARTMENT_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ORG_DEPARTMENT_LAST_UPDATED_BY_ID

        public ORG_DEPARTMENT()
        {
            this.PUR_PURCHASE_ORDER = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_REQUISITION = new List<PUR_PURCHASE_REQUISITION>();
        }
    }
}

