using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_DISTRICT")]
    public class SYS_DISTRICT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"DISTRICT_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid DISTRICT_ID { get; set; } // DISTRICT_ID (Primary key)

        [Column(@"PROVINCE_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PROVINCE_ID { get; set; } // PROVINCE_ID

        [Column(@"DISTRICT_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? DISTRICT_CODE { get; set; } // DISTRICT_CODE (length: 50)

        [Column(@"DISTRICT_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? DISTRICT_NAME_THA { get; set; } // DISTRICT_NAME_THA (length: 300)

        [Column(@"DISTRICT_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? DISTRICT_NAME_ENG { get; set; } // DISTRICT_NAME_ENG (length: 300)

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

        public virtual ICollection<INV_WAREHOUSE_ADDRESS> INV_WAREHOUSE_ADDRESS { get; set; } // INV_WAREHOUSE_ADDRESS.FK_INV_WAREHOUSE_ADDRESS_DISTRICT_ID
        public virtual ICollection<ORG_BRANCH_ADDRESS> ORG_BRANCH_ADDRESS { get; set; } // ORG_BRANCH_ADDRESS.FK_ORG_BRANCH_ADDRESS_DISTRICT_ID
        public virtual ICollection<ORG_COMPANY_ADDRESS> ORG_COMPANY_ADDRESS { get; set; } // ORG_COMPANY_ADDRESS.FK_ORG_COMPANY_ADDRESS_DISTRICT_ID
        public virtual ICollection<ORG_EMPLOYEE_ADDRESS> ORG_EMPLOYEE_ADDRESS { get; set; } // ORG_EMPLOYEE_ADDRESS.FK_ORG_EMPLOYEE_ADDRESS_DISTRICT_ID
        public virtual ICollection<ORG_FRANCHISEE_ADDRESS> ORG_FRANCHISEE_ADDRESS { get; set; } // ORG_FRANCHISEE_ADDRESS.FK_ORG_FRANCHISEE_ADDRESS_DISTRICT_ID
        public virtual ICollection<SYS_SUB_DISTRICT> SYS_SUB_DISTRICT { get; set; } // SYS_SUB_DISTRICT.FK_SYS_SUB_DISTRICT_DISTRICT_ID

        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_DISTRICT_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_DISTRICT_LAST_UPDATED_BY_ID

        public SYS_DISTRICT()
        {
            this.INV_WAREHOUSE_ADDRESS = new List<INV_WAREHOUSE_ADDRESS>();
            this.ORG_BRANCH_ADDRESS = new List<ORG_BRANCH_ADDRESS>();
            this.ORG_COMPANY_ADDRESS = new List<ORG_COMPANY_ADDRESS>();
            this.ORG_EMPLOYEE_ADDRESS = new List<ORG_EMPLOYEE_ADDRESS>();
            this.ORG_FRANCHISEE_ADDRESS = new List<ORG_FRANCHISEE_ADDRESS>();
            this.SYS_SUB_DISTRICT = new List<SYS_SUB_DISTRICT>();
        }
    }
}

