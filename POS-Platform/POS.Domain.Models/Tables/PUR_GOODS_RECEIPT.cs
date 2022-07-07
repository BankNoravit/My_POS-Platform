using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("PUR_GOODS_RECEIPT")]
    public class PUR_GOODS_RECEIPT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"GOODS_RECEIPT_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid GOODS_RECEIPT_ID { get; set; } // GOODS_RECEIPT_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"BRANCH_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BRANCH_ID { get; set; } // BRANCH_ID

        [Column(@"WAREHOUSE_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid WAREHOUSE_ID { get; set; } // WAREHOUSE_ID

        [Column(@"WAREHOUSE_CODE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? WAREHOUSE_CODE { get; set; } // WAREHOUSE_CODE (length: 50)

        [Column(@"WAREHOUSE_NAME", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? WAREHOUSE_NAME { get; set; } // WAREHOUSE_NAME (length: 300)

        [Column(@"WAREHOUSE_LOCATION_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid WAREHOUSE_LOCATION_ID { get; set; } // WAREHOUSE_LOCATION_ID

        [Column(@"WAREHOUSE_LOCATION_CODE", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? WAREHOUSE_LOCATION_CODE { get; set; } // WAREHOUSE_LOCATION_CODE (length: 50)

        [Column(@"WAREHOUSE_LOCATION_NAME", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? WAREHOUSE_LOCATION_NAME { get; set; } // WAREHOUSE_LOCATION_NAME (length: 300)

        [Column(@"GOODS_RECEIPT_NO", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? GOODS_RECEIPT_NO { get; set; } // GOODS_RECEIPT_NO (length: 50)

        [Column(@"GOODS_RECEIPT_DATE", Order = 11, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime GOODS_RECEIPT_DATE { get; set; } // GOODS_RECEIPT_DATE

        [Column(@"REFERENCE_NO", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? REFERENCE_NO { get; set; } // REFERENCE_NO (length: 50)

        [Column(@"REFERENCE_DATE", Order = 13, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? REFERENCE_DATE { get; set; } // REFERENCE_DATE

        [Column(@"PURCHASE_ORDER_ID", Order = 14, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? PURCHASE_ORDER_ID { get; set; } // PURCHASE_ORDER_ID

        [Column(@"PURCHASE_ORDER_NO", Order = 15, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? PURCHASE_ORDER_NO { get; set; } // PURCHASE_ORDER_NO (length: 50)

        [Column(@"PURCHASE_ORDER_DATE", Order = 16, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? PURCHASE_ORDER_DATE { get; set; } // PURCHASE_ORDER_DATE

        [Column(@"VENDOR_ID", Order = 17, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VENDOR_ID { get; set; } // VENDOR_ID

        [Column(@"VENDOR_CODE", Order = 18, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? VENDOR_CODE { get; set; } // VENDOR_CODE (length: 50)

        [Column(@"VENDOR_NAME", Order = 19, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? VENDOR_NAME { get; set; } // VENDOR_NAME (length: 300)

        [Column(@"CURRENCY_ID", Order = 20, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? CURRENCY_ID { get; set; } // CURRENCY_ID

        [Column(@"CURRENCY_CODE", Order = 21, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? CURRENCY_CODE { get; set; } // CURRENCY_CODE (length: 50)

        [Column(@"CURRENCY_NAME", Order = 22, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? CURRENCY_NAME { get; set; } // CURRENCY_NAME (length: 300)

        [Column(@"EXCHANGE_RATE", Order = 23, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal EXCHANGE_RATE { get; set; } // EXCHANGE_RATE

        [Column(@"EXCHANGE_RATE_DATE", Order = 24, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? EXCHANGE_RATE_DATE { get; set; } // EXCHANGE_RATE_DATE

        [Column(@"VAT_ID", Order = 25, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VAT_ID { get; set; } // VAT_ID

        [Column(@"VAT_CODE", Order = 26, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? VAT_CODE { get; set; } // VAT_CODE (length: 50)

        [Column(@"VAT_NAME", Order = 27, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? VAT_NAME { get; set; } // VAT_NAME (length: 300)

        [Column(@"VAT_RATE", Order = 28, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal VAT_RATE { get; set; } // VAT_RATE

        [Column(@"SUB_TOTAL", Order = 29, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal SUB_TOTAL { get; set; } // SUB_TOTAL

        [Column(@"SUB_TOTAL_FC", Order = 30, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal SUB_TOTAL_FC { get; set; } // SUB_TOTAL_FC

        [Column(@"PERCENT_DISCOUNT", Order = 31, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PERCENT_DISCOUNT { get; set; } // PERCENT_DISCOUNT

        [Column(@"DISCOUNT", Order = 32, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT { get; set; } // DISCOUNT

        [Column(@"DISCOUNT_FC", Order = 33, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT_FC { get; set; } // DISCOUNT_FC

        [Column(@"PRICE_AFTER_DISCOUNT", Order = 34, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_DISCOUNT { get; set; } // PRICE_AFTER_DISCOUNT

        [Column(@"PRICE_AFTER_DISCOUNT_FC", Order = 35, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_DISCOUNT_FC { get; set; } // PRICE_AFTER_DISCOUNT_FC

        [Column(@"PRICE_BEFORE_VAT", Order = 36, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_BEFORE_VAT { get; set; } // PRICE_BEFORE_VAT

        [Column(@"PRICE_BEFORE_VAT_FC", Order = 37, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_BEFORE_VAT_FC { get; set; } // PRICE_BEFORE_VAT_FC

        [Column(@"PRICE_BEFORE_VAT_BASE", Order = 38, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_BEFORE_VAT_BASE { get; set; } // PRICE_BEFORE_VAT_BASE

        [Column(@"VAT", Order = 39, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal VAT { get; set; } // VAT

        [Column(@"PRICE_AFTER_VAT", Order = 40, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_VAT { get; set; } // PRICE_AFTER_VAT

        [Column(@"PRICE_AFTER_VAT_FC", Order = 41, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_VAT_FC { get; set; } // PRICE_AFTER_VAT_FC

        [Column(@"GRAND_TOTAL", Order = 42, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal GRAND_TOTAL { get; set; } // GRAND_TOTAL

        [Column(@"GRAND_TOTAL_FC", Order = 43, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal GRAND_TOTAL_FC { get; set; } // GRAND_TOTAL_FC

        [Column(@"RECEIPT_BY_ID", Order = 44, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid RECEIPT_BY_ID { get; set; } // RECEIPT_BY_ID

        [Column(@"RECEIPT_BY_CODE", Order = 45, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? RECEIPT_BY_CODE { get; set; } // RECEIPT_BY_CODE (length: 50)

        [Column(@"RECEIPT_BY_NAME", Order = 46, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? RECEIPT_BY_NAME { get; set; } // RECEIPT_BY_NAME (length: 300)

        [Column(@"RECEIPT_DATE", Order = 47, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime RECEIPT_DATE { get; set; } // RECEIPT_DATE

        [Column(@"IS_SERIAL_PENDING", Order = 48, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_SERIAL_PENDING { get; set; } // IS_SERIAL_PENDING

        [Column(@"REMARK", Order = 49, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? REMARK { get; set; } // REMARK (length: 4000)

        [Column(@"DOCUMENT_STATUS_ID", Order = 50, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid DOCUMENT_STATUS_ID { get; set; } // DOCUMENT_STATUS_ID

        [Column(@"DOCUMENT_STATUS_CODE", Order = 51, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? DOCUMENT_STATUS_CODE { get; set; } // DOCUMENT_STATUS_CODE (length: 50)

        [Column(@"DOCUMENT_STATUS_NAME", Order = 52, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? DOCUMENT_STATUS_NAME { get; set; } // DOCUMENT_STATUS_NAME (length: 300)

        [Column(@"COMMENTS", Order = 53, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 54, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 55, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 56, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 57, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 58, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 59, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<PUR_GOODS_RECEIPT_ITEM> PUR_GOODS_RECEIPT_ITEM { get; set; } // PUR_GOODS_RECEIPT_ITEM.FK_PUR_GOODS_RECEIPT_ITEM_GOODS_RECEIPT_ID

        public virtual FNA_CURRENCY FNA_CURRENCY { get; set; } // FK_PUR_GOODS_RECEIPT_CURRENCY_ID
        public virtual FNA_TAX FNA_TAX_VAT { get; set; } // FK_PUR_GOODS_RECEIPT_VAT_ID
        public virtual INV_WAREHOUSE INV_WAREHOUSE { get; set; } // FK_PUR_GOODS_RECEIPT_WAREHOUSE_ID
        public virtual INV_WAREHOUSE_LOCATION INV_WAREHOUSE_LOCATION { get; set; } // FK_PUR_GOODS_RECEIPT_WAREHOUSE_LOCATION_ID
        public virtual ORG_BRANCH ORG_BRANCH { get; set; } // FK_PUR_GOODS_RECEIPT_BRANCH_ID
        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_PUR_GOODS_RECEIPT_COMPANY_ID
        public virtual ORG_EMPLOYEE RECEIPT_BY { get; set; } // FK_PUR_GOODS_RECEIPT_RECEIPT_BY_ID
        public virtual PUR_PURCHASE_ORDER PUR_PURCHASE_ORDER { get; set; } // FK_PUR_GOODS_RECEIPT_PURCHASE_ORDER_ID
        public virtual PUR_VENDOR PUR_VENDOR { get; set; } // FK_PUR_GOODS_RECEIPT_VENDOR_ID
        public virtual SYS_FLEX_ITEM DOCUMENT_STATUS { get; set; } // FK_PUR_GOODS_RECEIPT_DOCUMENT_STATUS_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_PUR_GOODS_RECEIPT_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_PUR_GOODS_RECEIPT_LAST_UPDATED_BY_ID

        public PUR_GOODS_RECEIPT()
        {
            this.PUR_GOODS_RECEIPT_ITEM = new List<PUR_GOODS_RECEIPT_ITEM>();
        }
    }
}

