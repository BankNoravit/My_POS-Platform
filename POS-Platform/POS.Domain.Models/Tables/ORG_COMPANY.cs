using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ORG_COMPANY")]
    public class ORG_COMPANY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"COMPANY_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID (Primary key)

        [Column(@"COMPANY_CODE", Order = 2, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? COMPANY_CODE { get; set; } // COMPANY_CODE (length: 50)

        [Column(@"COMPANY_NAME_THA", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? COMPANY_NAME_THA { get; set; } // COMPANY_NAME_THA (length: 300)

        [Column(@"COMPANY_NAME_ENG", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? COMPANY_NAME_ENG { get; set; } // COMPANY_NAME_ENG (length: 300)

        [Column(@"TAX_NO", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_13)]
        [MaxLength(13)]
        public string? TAX_NO { get; set; } // TAX_NO (length: 13)

        [Column(@"PHONE", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? PHONE { get; set; } // PHONE (length: 100)

        [Column(@"FAX", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FAX { get; set; } // FAX (length: 100)

        [Column(@"EMAIL", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? EMAIL { get; set; } // EMAIL (length: 100)

        [Column(@"LINE_OFFICIAL_ID", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? LINE_OFFICIAL_ID { get; set; } // LINE_OFFICIAL_ID (length: 100)

        [Column(@"FACEBOOK_ID", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FACEBOOK_ID { get; set; } // FACEBOOK_ID (length: 100)

        [Column(@"WEBSITE", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? WEBSITE { get; set; } // WEBSITE (length: 300)

        [Column(@"LOGO_URL", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? LOGO_URL { get; set; } // LOGO_URL (length: 300)

        [Column(@"COMMENTS", Order = 13, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 14, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 15, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 16, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 17, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 18, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 19, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<ASM_FA_OS_MATCHING> ASM_FA_OS_MATCHING { get; set; } // ASM_FA_OS_MATCHING.FK_ASM_FA_OS_MATCHING_COMPANY_ID
        public virtual ICollection<FNA_BANK_ACCOUNT> FNA_BANK_ACCOUNT { get; set; } // FNA_BANK_ACCOUNT.FK_FNA_BANK_ACCOUNT_COMPANY_ID
        public virtual ICollection<FNA_BANK_BRANCH> FNA_BANK_BRANCH { get; set; } // FNA_BANK_BRANCH.FK_FNA_BANK_BRANCH_COMPANY_ID
        public virtual ICollection<FNA_BANK> FNA_BANK { get; set; } // FNA_BANK.FK_FNA_BANK_COMPANY_ID
        public virtual ICollection<FNA_COST_CENTER> FNA_COST_CENTER { get; set; } // FNA_COST_CENTER.FK_FNA_COST_CENTER_COMPANY_ID
        public virtual ICollection<FNA_CURRENCY> FNA_CURRENCY { get; set; } // FNA_CURRENCY.FK_FNA_CURRENCY_COMPANY_ID
        public virtual ICollection<FNA_EXPENSE> FNA_EXPENSE { get; set; } // FNA_EXPENSE.FK_FNA_EXPENSE_COMPANY_ID
        public virtual ICollection<FNA_TAX> FNA_TAX { get; set; } // FNA_TAX.FK_FNA_TAX_COMPANY_ID
        public virtual ICollection<INV_BRAND> INV_BRAND { get; set; } // INV_BRAND.FK_INV_BRAND_COMPANY_ID
        public virtual ICollection<INV_CATEGORY> INV_CATEGORY { get; set; } // INV_CATEGORY.FK_INV_CATEGORY_COMPANY_ID
        public virtual ICollection<INV_GROUP_CATEGORY> INV_GROUP_CATEGORY { get; set; } // INV_GROUP_CATEGORY.FK_INV_GROUP_CATEGORY_COMPANY_ID
        public virtual ICollection<INV_SPECIFICATION> INV_SPECIFICATION { get; set; } // INV_SPECIFICATION.FK_INV_SPECIFICATION_COMPANY_ID
        public virtual ICollection<INV_STOCK_REQUISITION> INV_STOCK_REQUISITION { get; set; } // INV_STOCK_REQUISITION.FK_INV_STOCK_REQUISITION_COMPANY_ID
        public virtual ICollection<INV_SUB_CATEGORY> INV_SUB_CATEGORY { get; set; } // INV_SUB_CATEGORY.FK_INV_SUB_CATEGORY_COMPANY_ID
        public virtual ICollection<ORG_BUSINESS_UNIT> ORG_BUSINESS_UNIT { get; set; } // ORG_BUSINESS_UNIT.FK_ORG_BUSINESS_UNIT_COMPANY_ID
        public virtual ICollection<ORG_COMPANY_ADDRESS> ORG_COMPANY_ADDRESS { get; set; } // ORG_COMPANY_ADDRESS.FK_ORG_COMPANY_ADDRESS_COMPANY_ID
        public virtual ICollection<ORG_DEPARTMENT> ORG_DEPARTMENT { get; set; } // ORG_DEPARTMENT.FK_ORG_DEPARTMENT_COMPANY_ID
        public virtual ICollection<ORG_POSITION_LEVEL> ORG_POSITION_LEVEL { get; set; } // ORG_POSITION_LEVEL.FK_ORG_POSITION_LEVEL_COMPANY_ID
        public virtual ICollection<ORG_POSITION> ORG_POSITION { get; set; } // ORG_POSITION.FK_ORG_POSITION_COMPANY_ID
        public virtual ICollection<ORG_ZONE> ORG_ZONE { get; set; } // ORG_ZONE.FK_ORG_ZONE_COMPANY_ID
        public virtual ICollection<PUR_GOODS_RECEIPT> PUR_GOODS_RECEIPT { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_COMPANY_ID
        public virtual ICollection<PUR_GOODS_RETURN> PUR_GOODS_RETURN { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_COMPANY_ID
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_COMPANY_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_COMPANY_ID
        public virtual ICollection<PUR_VENDOR_ADDRESS> PUR_VENDOR_ADDRESS { get; set; } // PUR_VENDOR_ADDRESS.FK_PUR_VENDOR_ADDRESS_COMPANY_ID
        public virtual ICollection<PUR_VENDOR_BANK_ACCOUNT> PUR_VENDOR_BANK_ACCOUNT { get; set; } // PUR_VENDOR_BANK_ACCOUNT.FK_PUR_VENDOR_BANK_ACCOUNT_COMPANY_ID
        public virtual ICollection<PUR_VENDOR_CONTACT> PUR_VENDOR_CONTACT { get; set; } // PUR_VENDOR_CONTACT.FK_PUR_VENDOR_CONTACT_COMPANY_ID
        public virtual ICollection<PUR_VENDOR_GROUP> PUR_VENDOR_GROUP { get; set; } // PUR_VENDOR_GROUP.FK_PUR_VENDOR_GROUP_COMPANY_ID
        public virtual ICollection<PUR_VENDOR_TYPE> PUR_VENDOR_TYPE { get; set; } // PUR_VENDOR_TYPE.FK_PUR_VENDOR_TYPE_COMPANY_ID
        public virtual ICollection<PUR_VENDOR> PUR_VENDOR { get; set; } // PUR_VENDOR.FK_PUR_VENDOR_COMPANY_ID
        public virtual ICollection<SA_PASSWORD_POLICY> SA_PASSWORD_POLICY { get; set; } // SA_PASSWORD_POLICY.FK_SYS_PASSWORD_POLICY_COMPANY_ID
        public virtual ICollection<SAL_CUSTOMER_GROUP> SAL_CUSTOMER_GROUP { get; set; } // SAL_CUSTOMER_GROUP.FK_SAL_CUSTOMER_GROUP_COMPANY_ID
        public virtual ICollection<SAL_CUSTOMER> SAL_CUSTOMER { get; set; } // SAL_CUSTOMER.FK_SAL_CUSTOMER_COMPANY_ID
        public virtual ICollection<SYS_FLEX> SYS_FLEX { get; set; } // SYS_FLEX.FK_SYS_FLEX_COMPANY_ID
        public virtual ICollection<SYS_USER> SYS_USER { get; set; } // SYS_USER.FK_SYS_USER_COMPANY_ID

        public virtual SYS_USER CREATED_BY { get; set; } // FK_ORG_COMPANY_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ORG_COMPANY_LAST_UPDATED_BY_ID

        public ORG_COMPANY()
        {
            this.ASM_FA_OS_MATCHING = new List<ASM_FA_OS_MATCHING>();
            this.FNA_BANK = new List<FNA_BANK>();
            this.FNA_BANK_ACCOUNT = new List<FNA_BANK_ACCOUNT>();
            this.FNA_BANK_BRANCH = new List<FNA_BANK_BRANCH>();
            this.FNA_COST_CENTER = new List<FNA_COST_CENTER>();
            this.FNA_CURRENCY = new List<FNA_CURRENCY>();
            this.FNA_EXPENSE = new List<FNA_EXPENSE>();
            this.FNA_TAX = new List<FNA_TAX>();
            this.INV_BRAND = new List<INV_BRAND>();
            this.INV_CATEGORY = new List<INV_CATEGORY>();
            this.INV_GROUP_CATEGORY = new List<INV_GROUP_CATEGORY>();
            this.INV_SPECIFICATION = new List<INV_SPECIFICATION>();
            this.INV_STOCK_REQUISITION = new List<INV_STOCK_REQUISITION>();
            this.INV_SUB_CATEGORY = new List<INV_SUB_CATEGORY>();
            this.ORG_BUSINESS_UNIT = new List<ORG_BUSINESS_UNIT>();
            this.ORG_COMPANY_ADDRESS = new List<ORG_COMPANY_ADDRESS>();
            this.ORG_DEPARTMENT = new List<ORG_DEPARTMENT>();
            this.ORG_POSITION = new List<ORG_POSITION>();
            this.ORG_POSITION_LEVEL = new List<ORG_POSITION_LEVEL>();
            this.ORG_ZONE = new List<ORG_ZONE>();
            this.PUR_GOODS_RECEIPT = new List<PUR_GOODS_RECEIPT>();
            this.PUR_GOODS_RETURN = new List<PUR_GOODS_RETURN>();
            this.PUR_PURCHASE_ORDER = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_REQUISITION = new List<PUR_PURCHASE_REQUISITION>();
            this.PUR_VENDOR = new List<PUR_VENDOR>();
            this.PUR_VENDOR_ADDRESS = new List<PUR_VENDOR_ADDRESS>();
            this.PUR_VENDOR_BANK_ACCOUNT = new List<PUR_VENDOR_BANK_ACCOUNT>();
            this.PUR_VENDOR_CONTACT = new List<PUR_VENDOR_CONTACT>();
            this.PUR_VENDOR_GROUP = new List<PUR_VENDOR_GROUP>();
            this.PUR_VENDOR_TYPE = new List<PUR_VENDOR_TYPE>();
            this.SA_PASSWORD_POLICY = new List<SA_PASSWORD_POLICY>();
            this.SAL_CUSTOMER = new List<SAL_CUSTOMER>();
            this.SAL_CUSTOMER_GROUP = new List<SAL_CUSTOMER_GROUP>();
            this.SYS_FLEX = new List<SYS_FLEX>();
            this.SYS_USER = new List<SYS_USER>();
        }
    }
}

