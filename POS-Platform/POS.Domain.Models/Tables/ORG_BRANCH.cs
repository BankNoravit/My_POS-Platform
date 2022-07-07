using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ORG_BRANCH")]
    public class ORG_BRANCH
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"BRANCH_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid BRANCH_ID { get; set; } // BRANCH_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"BRANCH_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? BRANCH_CODE { get; set; } // BRANCH_CODE (length: 50)

        [Column(@"BRANCH_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? BRANCH_NAME_THA { get; set; } // BRANCH_NAME_THA (length: 300)

        [Column(@"BRANCH_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? BRANCH_NAME_ENG { get; set; } // BRANCH_NAME_ENG (length: 300)

        [Column(@"BUSINESS_UNIT_ID", Order = 6, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? BUSINESS_UNIT_ID { get; set; } // BUSINESS_UNIT_ID

        [Column(@"MANAGER_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? MANAGER_ID { get; set; } // MANAGER_ID

        [Column(@"IS_HEADQUARTER", Order = 8, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_HEADQUARTER { get; set; } // IS_HEADQUARTER

        [Column(@"IS_SHOP", Order = 9, TypeName = SQLSERVER_CONST.BIT)]
        public bool? IS_SHOP { get; set; } // IS_SHOP

        [Column(@"IS_WAREHOUSE", Order = 10, TypeName = SQLSERVER_CONST.BIT)]
        public bool? IS_WAREHOUSE { get; set; } // IS_WAREHOUSE

        [Column(@"IS_FRANCHISEE", Order = 11, TypeName = SQLSERVER_CONST.BIT)]
        public bool? IS_FRANCHISEE { get; set; } // IS_FRANCHISEE

        [Column(@"FRANCHISEE_ID", Order = 12, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? FRANCHISEE_ID { get; set; } // FRANCHISEE_ID

        [Column(@"BRANCH", Order = 13, TypeName = SQLSERVER_CONST.VARCHAR_5)]
        [Required]
        [MaxLength(5)]
        public string? BRANCH { get; set; } // BRANCH (length: 5)

        [Column(@"BRANCH_STATUS_ID", Order = 14, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? BRANCH_STATUS_ID { get; set; } // BRANCH_STATUS_ID

        [Column(@"BRANCH_OPEN_DATE", Order = 15, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? BRANCH_OPEN_DATE { get; set; } // BRANCH_OPEN_DATE

        [Column(@"BRANCH_CLOSE_DATE", Order = 16, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? BRANCH_CLOSE_DATE { get; set; } // BRANCH_CLOSE_DATE

        [Column(@"BRANCH_OFFICE_HOUR", Order = 17, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? BRANCH_OFFICE_HOUR { get; set; } // BRANCH_OFFICE_HOUR

        [Column(@"LOCATION_ID", Order = 18, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? LOCATION_ID { get; set; } // LOCATION_ID

        [Column(@"ZONE_ID", Order = 19, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? ZONE_ID { get; set; } // ZONE_ID

        [Column(@"AREA_SIZE", Order = 20, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        public decimal? AREA_SIZE { get; set; } // AREA_SIZE

        [Column(@"RENT_PER_SQM", Order = 21, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        public decimal? RENT_PER_SQM { get; set; } // RENT_PER_SQM

        [Column(@"PHONE", Order = 22, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? PHONE { get; set; } // PHONE (length: 100)

        [Column(@"FAX", Order = 23, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FAX { get; set; } // FAX (length: 100)

        [Column(@"EMAIL", Order = 24, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? EMAIL { get; set; } // EMAIL (length: 100)

        [Column(@"LINE_OFFICIAL_ID", Order = 25, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? LINE_OFFICIAL_ID { get; set; } // LINE_OFFICIAL_ID (length: 100)

        [Column(@"FACEBOOK_ID", Order = 26, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FACEBOOK_ID { get; set; } // FACEBOOK_ID (length: 100)

        [Column(@"WEBSITE", Order = 27, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? WEBSITE { get; set; } // WEBSITE (length: 300)

        [Column(@"COMMENTS", Order = 28, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 29, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 30, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 31, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 32, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 33, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 34, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        [InverseProperty("BRANCH_TO")]
        public virtual ICollection<INV_STOCK_REQUISITION> BRANCH_TO { get; set; } // INV_STOCK_REQUISITION.FK_INV_STOCK_REQUISITION_BRANCH_TO_ID
        [InverseProperty("BRANCH")]
        public virtual ICollection<INV_STOCK_REQUISITION> INV_STOCK_REQUISITION_BRANCH { get; set; } // INV_STOCK_REQUISITION.FK_INV_STOCK_REQUISITION_BRANCH_ID
        public virtual ICollection<ORG_BRANCH_ADDRESS> ORG_BRANCH_ADDRESS { get; set; } // ORG_BRANCH_ADDRESS.FK_ORG_BRANCH_ADDRESS_BRANCH_ID
        public virtual ICollection<ORG_BRANCH_GROUP_ITEM> ORG_BRANCH_GROUP_ITEM { get; set; } // ORG_BRANCH_GROUP_ITEM.FK_ORG_BRANCH_GROUP_ITEM_BRANCH_ID
        public virtual ICollection<ORG_DEPARTMENT> ORG_DEPARTMENT { get; set; } // ORG_DEPARTMENT.FK_ORG_DEPARTMENT_BRANCH_ID
        public virtual ICollection<PUR_GOODS_RECEIPT> PUR_GOODS_RECEIPT { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_BRANCH_ID
        public virtual ICollection<PUR_GOODS_RETURN> PUR_GOODS_RETURN { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_BRANCH_ID
        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM_LOCATION> PUR_PURCHASE_ORDER_ITEM_LOCATION { get; set; } // PUR_PURCHASE_ORDER_ITEM_LOCATION.FK_PUR_PURCHASE_ORDER_ITEM_LOCATION_BRANCH_ID
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_BRANCH_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION_ITEM_LOCATION> PUR_PURCHASE_REQUISITION_ITEM_LOCATION { get; set; } // PUR_PURCHASE_REQUISITION_ITEM_LOCATION.FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_BRANCH_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_BRANCH_ID

        public virtual ORG_EMPLOYEE MANAGER { get; set; } // FK_ORG_BRANCH_MANAGER_ID
        public virtual ORG_FRANCHISEE ORG_FRANCHISEE { get; set; } // FK_ORG_BRANCH_FRANCHISEE_ID
        public virtual SYS_FLEX_ITEM LOCATION { get; set; } // FK_ORG_BRANCH_LOCATION_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_ORG_BRANCH_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ORG_BRANCH_LAST_UPDATED_BY_ID

        public ORG_BRANCH()
        {
            this.INV_STOCK_REQUISITION_BRANCH = new List<INV_STOCK_REQUISITION>();
            this.BRANCH_TO = new List<INV_STOCK_REQUISITION>();
            this.ORG_BRANCH_ADDRESS = new List<ORG_BRANCH_ADDRESS>();
            this.ORG_BRANCH_GROUP_ITEM = new List<ORG_BRANCH_GROUP_ITEM>();
            this.ORG_DEPARTMENT = new List<ORG_DEPARTMENT>();
            this.PUR_GOODS_RECEIPT = new List<PUR_GOODS_RECEIPT>();
            this.PUR_GOODS_RETURN = new List<PUR_GOODS_RETURN>();
            this.PUR_PURCHASE_ORDER = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_ORDER_ITEM_LOCATION = new List<PUR_PURCHASE_ORDER_ITEM_LOCATION>();
            this.PUR_PURCHASE_REQUISITION = new List<PUR_PURCHASE_REQUISITION>();
            this.PUR_PURCHASE_REQUISITION_ITEM_LOCATION = new List<PUR_PURCHASE_REQUISITION_ITEM_LOCATION>();
        }
    }
}

