using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("PUR_PURCHASE_REQUISITION")]
    public class PUR_PURCHASE_REQUISITION
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"PURCHASE_REQUISITION_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid PURCHASE_REQUISITION_ID { get; set; } // PURCHASE_REQUISITION_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"BRANCH_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BRANCH_ID { get; set; } // BRANCH_ID

        [Column(@"PURCHASE_REQUISITION_TYPE_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PURCHASE_REQUISITION_TYPE_ID { get; set; } // PURCHASE_REQUISITION_TYPE_ID

        [Column(@"TRANSACTION_TYPE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_3)]
        [Required]
        [MaxLength(3)]
        public string? TRANSACTION_TYPE { get; set; } // TRANSACTION_TYPE (length: 3)

        [Column(@"PURCHASE_REQUISITION_NO", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? PURCHASE_REQUISITION_NO { get; set; } // PURCHASE_REQUISITION_NO (length: 50)

        [Column(@"PURCHASE_REQUISITION_DATE", Order = 7, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime PURCHASE_REQUISITION_DATE { get; set; } // PURCHASE_REQUISITION_DATE

        [Column(@"REFERENCE_NO", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? REFERENCE_NO { get; set; } // REFERENCE_NO (length: 50)

        [Column(@"REFERENCE_DATE", Order = 9, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? REFERENCE_DATE { get; set; } // REFERENCE_DATE

        [Column(@"VENDOR_ID", Order = 10, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VENDOR_ID { get; set; } // VENDOR_ID

        [Column(@"VENDOR_CODE", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? VENDOR_CODE { get; set; } // VENDOR_CODE (length: 50)

        [Column(@"VENDOR_NAME", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? VENDOR_NAME { get; set; } // VENDOR_NAME (length: 300)

        [Column(@"VENDOR_CONTACT_ID", Order = 13, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VENDOR_CONTACT_ID { get; set; } // VENDOR_CONTACT_ID

        [Column(@"VENDOR_CONTACT_NAME", Order = 14, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? VENDOR_CONTACT_NAME { get; set; } // VENDOR_CONTACT_NAME (length: 300)

        [Column(@"VENDOR_BILLING_ADDRESS", Order = 15, TypeName = SQLSERVER_CONST.VARCHAR_1000)]
        [Required]
        [MaxLength(1000)]
        public string? VENDOR_BILLING_ADDRESS { get; set; } // VENDOR_BILLING_ADDRESS (length: 1000)

        [Column(@"TAX_NO", Order = 16, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? TAX_NO { get; set; } // TAX_NO (length: 50)

        [Column(@"CREDIT_DAYS", Order = 17, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int CREDIT_DAYS { get; set; } // CREDIT_DAYS

        [Column(@"DUE_DATE", Order = 18, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? DUE_DATE { get; set; } // DUE_DATE

        [Column(@"EMPLOYEE_ID", Order = 19, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid EMPLOYEE_ID { get; set; } // EMPLOYEE_ID

        [Column(@"EMPLOYEE_CODE", Order = 20, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? EMPLOYEE_CODE { get; set; } // EMPLOYEE_CODE (length: 50)

        [Column(@"EMPLOYEE_NAME", Order = 21, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? EMPLOYEE_NAME { get; set; } // EMPLOYEE_NAME (length: 300)

        [Column(@"DEPARTMENT_ID", Order = 22, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid DEPARTMENT_ID { get; set; } // DEPARTMENT_ID

        [Column(@"DEPARTMENT_CODE", Order = 23, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? DEPARTMENT_CODE { get; set; } // DEPARTMENT_CODE (length: 50)

        [Column(@"DEPARTMENT_NAME", Order = 24, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? DEPARTMENT_NAME { get; set; } // DEPARTMENT_NAME (length: 300)

        [Column(@"POSITION_ID", Order = 25, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid POSITION_ID { get; set; } // POSITION_ID

        [Column(@"POSITION_CODE", Order = 26, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? POSITION_CODE { get; set; } // POSITION_CODE (length: 50)

        [Column(@"POSITION_NAME", Order = 27, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? POSITION_NAME { get; set; } // POSITION_NAME (length: 300)

        [Column(@"CURRENCY_ID", Order = 28, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? CURRENCY_ID { get; set; } // CURRENCY_ID

        [Column(@"CURRENCY_CODE", Order = 29, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? CURRENCY_CODE { get; set; } // CURRENCY_CODE (length: 50)

        [Column(@"CURRENCY_NAME", Order = 30, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? CURRENCY_NAME { get; set; } // CURRENCY_NAME (length: 300)

        [Column(@"EXCHANGE_RATE", Order = 31, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal EXCHANGE_RATE { get; set; } // EXCHANGE_RATE

        [Column(@"EXCHANGE_RATE_DATE", Order = 32, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? EXCHANGE_RATE_DATE { get; set; } // EXCHANGE_RATE_DATE

        [Column(@"SHIPPING_METHOD_ID", Order = 33, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid SHIPPING_METHOD_ID { get; set; } // SHIPPING_METHOD_ID

        [Column(@"SHIPPING_METHOD_CODE", Order = 34, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? SHIPPING_METHOD_CODE { get; set; } // SHIPPING_METHOD_CODE (length: 50)

        [Column(@"SHIPPING_METHOD_NAME", Order = 35, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? SHIPPING_METHOD_NAME { get; set; } // SHIPPING_METHOD_NAME (length: 300)

        [Column(@"VAT_ID", Order = 36, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VAT_ID { get; set; } // VAT_ID

        [Column(@"VAT_CODE", Order = 37, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? VAT_CODE { get; set; } // VAT_CODE (length: 50)

        [Column(@"VAT_NAME", Order = 38, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? VAT_NAME { get; set; } // VAT_NAME (length: 300)

        [Column(@"VAT_RATE", Order = 39, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal VAT_RATE { get; set; } // VAT_RATE

        [Column(@"SUB_TOTAL", Order = 40, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal SUB_TOTAL { get; set; } // SUB_TOTAL

        [Column(@"SUB_TOTAL_FC", Order = 41, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal SUB_TOTAL_FC { get; set; } // SUB_TOTAL_FC

        [Column(@"PERCENT_DISCOUNT", Order = 42, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PERCENT_DISCOUNT { get; set; } // PERCENT_DISCOUNT

        [Column(@"DISCOUNT", Order = 43, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT { get; set; } // DISCOUNT

        [Column(@"DISCOUNT_FC", Order = 44, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT_FC { get; set; } // DISCOUNT_FC

        [Column(@"PRICE_AFTER_DISCOUNT", Order = 45, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_DISCOUNT { get; set; } // PRICE_AFTER_DISCOUNT

        [Column(@"PRICE_AFTER_DISCOUNT_FC", Order = 46, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_DISCOUNT_FC { get; set; } // PRICE_AFTER_DISCOUNT_FC

        [Column(@"PRICE_BEFORE_VAT", Order = 47, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_BEFORE_VAT { get; set; } // PRICE_BEFORE_VAT

        [Column(@"PRICE_BEFORE_VAT_FC", Order = 48, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_BEFORE_VAT_FC { get; set; } // PRICE_BEFORE_VAT_FC

        [Column(@"PRICE_BEFORE_VAT_BASE", Order = 49, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_BEFORE_VAT_BASE { get; set; } // PRICE_BEFORE_VAT_BASE

        [Column(@"VAT", Order = 50, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal VAT { get; set; } // VAT

        [Column(@"PRICE_AFTER_VAT", Order = 51, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_VAT { get; set; } // PRICE_AFTER_VAT

        [Column(@"PRICE_AFTER_VAT_FC", Order = 52, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_VAT_FC { get; set; } // PRICE_AFTER_VAT_FC

        [Column(@"GRAND_TOTAL", Order = 53, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal GRAND_TOTAL { get; set; } // GRAND_TOTAL

        [Column(@"GRAND_TOTAL_FC", Order = 54, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal GRAND_TOTAL_FC { get; set; } // GRAND_TOTAL_FC

        [Column(@"REMARK", Order = 55, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? REMARK { get; set; } // REMARK (length: 4000)

        [Column(@"APPROVAL_STATUS_ID", Order = 56, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid APPROVAL_STATUS_ID { get; set; } // APPROVAL_STATUS_ID

        [Column(@"APPROVAL_STATUS_CODE", Order = 57, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? APPROVAL_STATUS_CODE { get; set; } // APPROVAL_STATUS_CODE (length: 50)

        [Column(@"APPROVAL_STATUS_NAME", Order = 58, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? APPROVAL_STATUS_NAME { get; set; } // APPROVAL_STATUS_NAME (length: 300)

        [Column(@"APPROVAL_DATE", Order = 59, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? APPROVAL_DATE { get; set; } // APPROVAL_DATE

        [Column(@"DOCUMENT_STATUS_ID", Order = 60, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid DOCUMENT_STATUS_ID { get; set; } // DOCUMENT_STATUS_ID

        [Column(@"DOCUMENT_STATUS_CODE", Order = 61, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? DOCUMENT_STATUS_CODE { get; set; } // DOCUMENT_STATUS_CODE (length: 50)

        [Column(@"DOCUMENT_STATUS_NAME", Order = 62, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? DOCUMENT_STATUS_NAME { get; set; } // DOCUMENT_STATUS_NAME (length: 300)

        [Column(@"COMMENTS", Order = 63, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 64, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 65, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 66, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 67, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 68, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 69, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_PURCHASE_REQUISITION_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION_ITEM> PUR_PURCHASE_REQUISITION_ITEM { get; set; } // PUR_PURCHASE_REQUISITION_ITEM.FK_PUR_PURCHASE_REQUISITION_ITEM_PURCHASE_REQUISITION_ID

        public virtual FNA_CURRENCY FNA_CURRENCY { get; set; } // FK_PUR_PURCHASE_REQUISITION_CURRENCY_ID
        public virtual FNA_TAX FNA_TAX_VAT { get; set; } // FK_PUR_PURCHASE_REQUISITION_VAT_ID
        public virtual ORG_BRANCH ORG_BRANCH { get; set; } // FK_PUR_PURCHASE_REQUISITION_BRANCH_ID
        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_PUR_PURCHASE_REQUISITION_COMPANY_ID
        public virtual ORG_DEPARTMENT ORG_DEPARTMENT { get; set; } // FK_PUR_PURCHASE_REQUISITION_DEPARTMENT_ID
        public virtual ORG_EMPLOYEE ORG_EMPLOYEE { get; set; } // FK_PUR_PURCHASE_REQUISITION_EMPLOYEE_ID
        public virtual ORG_POSITION ORG_POSITION { get; set; } // FK_PUR_PURCHASE_REQUISITION_POSITION_ID
        public virtual PUR_VENDOR PUR_VENDOR { get; set; } // FK_PUR_PURCHASE_REQUISITION_VENDOR_ID
        public virtual PUR_VENDOR_CONTACT PUR_VENDOR_CONTACT { get; set; } // FK_PUR_PURCHASE_REQUISITION_VENDOR_CONTACT_ID
        public virtual SYS_FLEX_ITEM APPROVAL_STATUS { get; set; } // FK_PUR_PURCHASE_REQUISITION_APPROVAL_STATUS_ID
        public virtual SYS_FLEX_ITEM DOCUMENT_STATUS { get; set; } // FK_PUR_PURCHASE_REQUISITION_DOCUMENT_STATUS_ID
        public virtual SYS_FLEX_ITEM PURCHASE_REQUISITION_TYPE { get; set; } // FK_PUR_PURCHASE_REQUISITION_PURCHASE_REQUISITION_TYPE_ID
        public virtual SYS_FLEX_ITEM SHIPPING_METHOD { get; set; } // FK_PUR_PURCHASE_REQUISITION_SHIPPING_METHOD_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_PUR_PURCHASE_REQUISITION_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_PUR_PURCHASE_REQUISITION_LAST_UPDATED_BY_ID

        public PUR_PURCHASE_REQUISITION()
        {
            this.PUR_PURCHASE_ORDER = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_REQUISITION_ITEM = new List<PUR_PURCHASE_REQUISITION_ITEM>();
        }
    }
}

