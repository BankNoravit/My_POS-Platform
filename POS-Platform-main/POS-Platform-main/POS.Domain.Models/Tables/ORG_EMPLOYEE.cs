using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ORG_EMPLOYEE")]
    public class ORG_EMPLOYEE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"EMPLOYEE_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid EMPLOYEE_ID { get; set; } // EMPLOYEE_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"EMPLOYEE_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? EMPLOYEE_CODE { get; set; } // EMPLOYEE_CODE (length: 50)

        [Column(@"TITLE_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? TITLE_ID { get; set; } // TITLE_ID

        [Column(@"FIRST_NAME_THA", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? FIRST_NAME_THA { get; set; } // FIRST_NAME_THA (length: 300)

        [Column(@"LAST_NAME_THA", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? LAST_NAME_THA { get; set; } // LAST_NAME_THA (length: 300)

        [Column(@"FIRST_NAME_ENG", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? FIRST_NAME_ENG { get; set; } // FIRST_NAME_ENG (length: 300)

        [Column(@"LAST_NAME_ENG", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? LAST_NAME_ENG { get; set; } // LAST_NAME_ENG (length: 300)

        [Column(@"NICKNAME", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? NICKNAME { get; set; } // NICKNAME (length: 50)

        [Column(@"TAX_NO", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_20)]
        [MaxLength(20)]
        public string? TAX_NO { get; set; } // TAX_NO (length: 20)

        [Column(@"GENDER_ID", Order = 11, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? GENDER_ID { get; set; } // GENDER_ID

        [Column(@"BIRTH_DATE", Order = 12, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? BIRTH_DATE { get; set; } // BIRTH_DATE

        [Column(@"NATIONALITY_ID", Order = 13, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? NATIONALITY_ID { get; set; } // NATIONALITY_ID

        [Column(@"RACE_ID", Order = 14, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? RACE_ID { get; set; } // RACE_ID

        [Column(@"RELIGION_ID", Order = 15, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? RELIGION_ID { get; set; } // RELIGION_ID

        [Column(@"BLOOD_TYPE_ID", Order = 16, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? BLOOD_TYPE_ID { get; set; } // BLOOD_TYPE_ID

        [Column(@"MILITARY_STATUS_ID", Order = 17, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? MILITARY_STATUS_ID { get; set; } // MILITARY_STATUS_ID

        [Column(@"MARITAL_STATUS_ID", Order = 18, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? MARITAL_STATUS_ID { get; set; } // MARITAL_STATUS_ID

        [Column(@"PHOTO_URL", Order = 19, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? PHOTO_URL { get; set; } // PHOTO_URL (length: 300)

        [Column(@"PHONE", Order = 20, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? PHONE { get; set; } // PHONE (length: 100)

        [Column(@"EMAIL", Order = 21, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? EMAIL { get; set; } // EMAIL (length: 100)

        [Column(@"LINE_OFFICIAL_ID", Order = 22, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? LINE_OFFICIAL_ID { get; set; } // LINE_OFFICIAL_ID (length: 100)

        [Column(@"FACEBOOK_ID", Order = 23, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FACEBOOK_ID { get; set; } // FACEBOOK_ID (length: 100)

        [Column(@"DEPARTMENT_ID", Order = 24, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid DEPARTMENT_ID { get; set; } // DEPARTMENT_ID

        [Column(@"POSITION_ID", Order = 25, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid POSITION_ID { get; set; } // POSITION_ID

        [Column(@"LEADER_ID", Order = 26, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? LEADER_ID { get; set; } // LEADER_ID

        [Column(@"START_WORK_DATE", Order = 27, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? START_WORK_DATE { get; set; } // START_WORK_DATE

        [Column(@"EMPLOYEE_TYPE_ID", Order = 28, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? EMPLOYEE_TYPE_ID { get; set; } // EMPLOYEE_TYPE_ID

        [Column(@"WORK_STATUS_ID", Order = 29, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? WORK_STATUS_ID { get; set; } // WORK_STATUS_ID

        [Column(@"SIGNATURE_URL", Order = 30, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? SIGNATURE_URL { get; set; } // SIGNATURE_URL (length: 300)

        [Column(@"COMMENTS", Order = 31, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 32, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 33, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 34, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 35, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 36, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 37, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        [InverseProperty("REQUISITION_BY")]
        public virtual ICollection<INV_STOCK_REQUISITION> REQUISITION_BY { get; set; } // INV_STOCK_REQUISITION.FK_INV_STOCK_REQUISITION_REQUISITION_BY_ID
        [InverseProperty("BRANCH_GROUP_OWNER")]
        public virtual ICollection<ORG_BRANCH_GROUP> BRANCH_GROUP_OWNER { get; set; } // ORG_BRANCH_GROUP.FK_ORG_BRANCH_GROUP_BRANCH_GROUP_OWNER_ID
        [InverseProperty("MANAGER")]
        public virtual ICollection<ORG_BRANCH> MANAGER { get; set; } // ORG_BRANCH.FK_ORG_BRANCH_MANAGER_ID
        public virtual ICollection<ORG_EMPLOYEE_ADDRESS> ORG_EMPLOYEE_ADDRESS { get; set; } // ORG_EMPLOYEE_ADDRESS.FK_ORG_EMPLOYEE_ADDRESS_EMPLOYEE_ID
        [InverseProperty("ORG_EMPLOYEE_LEADER")]
        public virtual ICollection<ORG_EMPLOYEE> ORG_EMPLOYEE_CHILD { get; set; } // ORG_EMPLOYEE.FK_ORG_EMPLOYEE_LEADER_ID
        [InverseProperty("RECEIPT_BY")]
        public virtual ICollection<PUR_GOODS_RECEIPT> RECEIPT_BY { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_RECEIPT_BY_ID
        [InverseProperty("RETURN_BY")]
        public virtual ICollection<PUR_GOODS_RETURN> RETURN_BY { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_RETURN_BY_ID
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_EMPLOYEE_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_EMPLOYEE_ID
        public virtual ICollection<SYS_USER> SYS_USER { get; set; } // SYS_USER.FK_SYS_USER_EMPLOYEE_ID

        public virtual ORG_EMPLOYEE ORG_EMPLOYEE_LEADER { get; set; } // FK_ORG_EMPLOYEE_LEADER_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_ORG_EMPLOYEE_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ORG_EMPLOYEE_LAST_UPDATED_BY_ID

        public ORG_EMPLOYEE()
        {
            this.REQUISITION_BY = new List<INV_STOCK_REQUISITION>();
            this.MANAGER = new List<ORG_BRANCH>();
            this.BRANCH_GROUP_OWNER = new List<ORG_BRANCH_GROUP>();
            this.ORG_EMPLOYEE_CHILD = new List<ORG_EMPLOYEE>();
            this.ORG_EMPLOYEE_ADDRESS = new List<ORG_EMPLOYEE_ADDRESS>();
            this.RECEIPT_BY = new List<PUR_GOODS_RECEIPT>();
            this.RETURN_BY = new List<PUR_GOODS_RETURN>();
            this.PUR_PURCHASE_ORDER = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_REQUISITION = new List<PUR_PURCHASE_REQUISITION>();
            this.SYS_USER = new List<SYS_USER>();
        }
    }
}

