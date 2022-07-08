using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("PUR_VENDOR")]
    public class PUR_VENDOR
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"VENDOR_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid VENDOR_ID { get; set; } // VENDOR_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"VENDOR_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? VENDOR_CODE { get; set; } // VENDOR_CODE (length: 50)

        [Column(@"TITLE_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? TITLE_ID { get; set; } // TITLE_ID

        [Column(@"VENDOR_NAME_THA", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? VENDOR_NAME_THA { get; set; } // VENDOR_NAME_THA (length: 300)

        [Column(@"VENDOR_NAME_ENG", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? VENDOR_NAME_ENG { get; set; } // VENDOR_NAME_ENG (length: 300)

        [Column(@"VENDOR_BILLING_NAME_THA", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? VENDOR_BILLING_NAME_THA { get; set; } // VENDOR_BILLING_NAME_THA (length: 300)

        [Column(@"VENDOR_BILLING_NAME_ENG", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? VENDOR_BILLING_NAME_ENG { get; set; } // VENDOR_BILLING_NAME_ENG (length: 300)

        [Column(@"TAX_ID", Order = 9, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? TAX_ID { get; set; } // TAX_ID

        [Column(@"TAX_NO", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_20)]
        [Required]
        [MaxLength(20)]
        public string? TAX_NO { get; set; } // TAX_NO (length: 20)

        [Column(@"JURASTIC_NO", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_20)]
        [Required]
        [MaxLength(20)]
        public string? JURASTIC_NO { get; set; } // JURASTIC_NO (length: 20)

        [Column(@"PROSPECT_ID", Order = 12, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PROSPECT_ID { get; set; } // PROSPECT_ID

        [Column(@"IS_ONE_TIME", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ONE_TIME { get; set; } // IS_ONE_TIME

        [Column(@"IS_FOREIGN", Order = 14, TypeName = SQLSERVER_CONST.BIT)]
        public bool? IS_FOREIGN { get; set; } // IS_FOREIGN

        [Column(@"VENDOR_GROUP_ID", Order = 15, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VENDOR_GROUP_ID { get; set; } // VENDOR_GROUP_ID

        [Column(@"VENDOR_TYPE_ID", Order = 16, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VENDOR_TYPE_ID { get; set; } // VENDOR_TYPE_ID

        [Column(@"CREDIT_DAYS", Order = 17, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int CREDIT_DAYS { get; set; } // CREDIT_DAYS

        [Column(@"CREDIT_LIMIT", Order = 18, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool CREDIT_LIMIT { get; set; } // CREDIT_LIMIT

        [Column(@"CREDIT_LIMIT_AMOUNT", Order = 19, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal CREDIT_LIMIT_AMOUNT { get; set; } // CREDIT_LIMIT_AMOUNT

        [Column(@"CREDIT_REMAIN", Order = 20, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal CREDIT_REMAIN { get; set; } // CREDIT_REMAIN

        [Column(@"OUTSTANDING_BALANCE", Order = 21, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal OUTSTANDING_BALANCE { get; set; } // OUTSTANDING_BALANCE

        [Column(@"LAST_PAYMENT_DATE", Order = 22, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? LAST_PAYMENT_DATE { get; set; } // LAST_PAYMENT_DATE

        [Column(@"BILLING_ID", Order = 23, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? BILLING_ID { get; set; } // BILLING_ID

        [Column(@"BILLING_DAY", Order = 24, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? BILLING_DAY { get; set; } // BILLING_DAY (length: 100)

        [Column(@"BILLING_DATE", Order = 25, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? BILLING_DATE { get; set; } // BILLING_DATE (length: 100)

        [Column(@"BILLING_WEEK", Order = 26, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? BILLING_WEEK { get; set; } // BILLING_WEEK (length: 100)

        [Column(@"COLLECT_ID", Order = 27, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? COLLECT_ID { get; set; } // COLLECT_ID

        [Column(@"COLLECT_DAY", Order = 28, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? COLLECT_DAY { get; set; } // COLLECT_DAY (length: 100)

        [Column(@"COLLECT_DATE", Order = 29, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? COLLECT_DATE { get; set; } // COLLECT_DATE (length: 100)

        [Column(@"COLLECT_WEEK", Order = 30, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? COLLECT_WEEK { get; set; } // COLLECT_WEEK (length: 100)

        [Column(@"BIRTH_DATE", Order = 31, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? BIRTH_DATE { get; set; } // BIRTH_DATE

        [Column(@"PHONE", Order = 32, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? PHONE { get; set; } // PHONE (length: 100)

        [Column(@"FAX", Order = 33, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FAX { get; set; } // FAX (length: 100)

        [Column(@"EMAIL", Order = 34, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? EMAIL { get; set; } // EMAIL (length: 100)

        [Column(@"LINE_ID", Order = 35, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? LINE_ID { get; set; } // LINE_ID (length: 100)

        [Column(@"FACEBOOK_ID", Order = 36, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FACEBOOK_ID { get; set; } // FACEBOOK_ID (length: 100)

        [Column(@"WEBSITE", Order = 37, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? WEBSITE { get; set; } // WEBSITE (length: 300)

        [Column(@"IMAGE_URL", Order = 38, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? IMAGE_URL { get; set; } // IMAGE_URL (length: 300)

        [Column(@"COMMENTS", Order = 39, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 40, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 41, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 42, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 43, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 44, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 45, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<PUR_GOODS_RECEIPT> PUR_GOODS_RECEIPT { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_VENDOR_ID
        public virtual ICollection<PUR_GOODS_RETURN> PUR_GOODS_RETURN { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_VENDOR_ID
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_VENDOR_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_VENDOR_ID
        public virtual ICollection<PUR_VENDOR_ADDRESS> PUR_VENDOR_ADDRESS { get; set; } // PUR_VENDOR_ADDRESS.FK_PUR_VENDOR_ADDRESS_VENDOR_ID
        public virtual ICollection<PUR_VENDOR_BANK_ACCOUNT> PUR_VENDOR_BANK_ACCOUNT { get; set; } // PUR_VENDOR_BANK_ACCOUNT.FK_PUR_VENDOR_BANK_ACCOUNT_VENDOR_ID
        public virtual ICollection<PUR_VENDOR_CONTACT> PUR_VENDOR_CONTACT { get; set; } // PUR_VENDOR_CONTACT.FK_PUR_VENDOR_CONTACT_VENDOR_ID

        public virtual FNA_TAX FNA_TAX { get; set; } // FK_PUR_VENDOR_TAX_ID
        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_PUR_VENDOR_COMPANY_ID
        public virtual PUR_VENDOR_GROUP PUR_VENDOR_GROUP { get; set; } // FK_PUR_VENDOR_VENDOR_GROUP_ID
        public virtual PUR_VENDOR_TYPE PUR_VENDOR_TYPE { get; set; } // FK_PUR_VENDOR_VENDOR_TYPE_ID
        public virtual SYS_FLEX_ITEM BILLING { get; set; } // FK_PUR_VENDOR_BILLING_ID
        public virtual SYS_FLEX_ITEM COLLECT { get; set; } // FK_PUR_VENDOR_COLLECT_ID
        public virtual SYS_FLEX_ITEM PROSPECT { get; set; } // FK_PUR_VENDOR_PROSPECT_ID
        public virtual SYS_FLEX_ITEM TITLE { get; set; } // FK_PUR_VENDOR_TITLE_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_PUR_VENDOR_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_PUR_VENDOR_LAST_UPDATED_BY_ID

        public PUR_VENDOR()
        {
            this.PUR_GOODS_RECEIPT = new List<PUR_GOODS_RECEIPT>();
            this.PUR_GOODS_RETURN = new List<PUR_GOODS_RETURN>();
            this.PUR_PURCHASE_ORDER = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_REQUISITION = new List<PUR_PURCHASE_REQUISITION>();
            this.PUR_VENDOR_ADDRESS = new List<PUR_VENDOR_ADDRESS>();
            this.PUR_VENDOR_BANK_ACCOUNT = new List<PUR_VENDOR_BANK_ACCOUNT>();
            this.PUR_VENDOR_CONTACT = new List<PUR_VENDOR_CONTACT>();
        }
    }
}

