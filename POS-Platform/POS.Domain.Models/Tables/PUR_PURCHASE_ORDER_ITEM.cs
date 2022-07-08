using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("PUR_PURCHASE_ORDER_ITEM")]
    public class PUR_PURCHASE_ORDER_ITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"PURCHASE_ORDER_ITEM_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid PURCHASE_ORDER_ITEM_ID { get; set; } // PURCHASE_ORDER_ITEM_ID (Primary key)

        [Column(@"PURCHASE_ORDER_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PURCHASE_ORDER_ID { get; set; } // PURCHASE_ORDER_ID

        [Column(@"SEQ_NO", Order = 3, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SEQ_NO { get; set; } // SEQ_NO

        [Column(@"PRODUCT_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PRODUCT_ID { get; set; } // PRODUCT_ID

        [Column(@"PRODUCT_CODE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? PRODUCT_CODE { get; set; } // PRODUCT_CODE (length: 50)

        [Column(@"PRODUCT_NAME", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? PRODUCT_NAME { get; set; } // PRODUCT_NAME (length: 300)

        [Column(@"PRODUCT_DESCRIPTION", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [Required]
        [MaxLength(4000)]
        public string? PRODUCT_DESCRIPTION { get; set; } // PRODUCT_DESCRIPTION (length: 4000)

        [Column(@"UOM_ID", Order = 8, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid UOM_ID { get; set; } // UOM_ID

        [Column(@"UOM_CODE", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? UOM_CODE { get; set; } // UOM_CODE (length: 50)

        [Column(@"UOM_NAME", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? UOM_NAME { get; set; } // UOM_NAME (length: 300)

        [Column(@"IS_VAT_ZERO", Order = 11, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_VAT_ZERO { get; set; } // IS_VAT_ZERO

        [Column(@"RATIO", Order = 12, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal RATIO { get; set; } // RATIO

        [Column(@"QTY", Order = 13, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY { get; set; } // QTY

        [Column(@"QTY_REMAIN", Order = 14, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY_REMAIN { get; set; } // QTY_REMAIN

        [Column(@"QTY_FORCE", Order = 15, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY_FORCE { get; set; } // QTY_FORCE

        [Column(@"QTY_BASE", Order = 16, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY_BASE { get; set; } // QTY_BASE

        [Column(@"QTY_BASE_REMAIN", Order = 17, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY_BASE_REMAIN { get; set; } // QTY_BASE_REMAIN

        [Column(@"UNIT_PRICE", Order = 18, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal UNIT_PRICE { get; set; } // UNIT_PRICE

        [Column(@"UNIT_PRICE_FC", Order = 19, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal UNIT_PRICE_FC { get; set; } // UNIT_PRICE_FC

        [Column(@"DISCOUNT_PRICE_1", Order = 20, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT_PRICE_1 { get; set; } // DISCOUNT_PRICE_1

        [Column(@"DISCOUNT_PRICE_1_FC", Order = 21, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT_PRICE_1_FC { get; set; } // DISCOUNT_PRICE_1_FC

        [Column(@"DISCOUNT_PRICE_2", Order = 22, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT_PRICE_2 { get; set; } // DISCOUNT_PRICE_2

        [Column(@"DISCOUNT_PRICE_2_FC", Order = 23, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT_PRICE_2_FC { get; set; } // DISCOUNT_PRICE_2_FC

        [Column(@"DISCOUNT_PRICE_3", Order = 24, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT_PRICE_3 { get; set; } // DISCOUNT_PRICE_3

        [Column(@"DISCOUNT_PRICE_3_FC", Order = 25, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT_PRICE_3_FC { get; set; } // DISCOUNT_PRICE_3_FC

        [Column(@"TOTAL_PRICE", Order = 26, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal TOTAL_PRICE { get; set; } // TOTAL_PRICE

        [Column(@"TOTAL_PRICE_FC", Order = 27, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal TOTAL_PRICE_FC { get; set; } // TOTAL_PRICE_FC

        [Column(@"DISCOUNT_RATIO", Order = 28, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal DISCOUNT_RATIO { get; set; } // DISCOUNT_RATIO

        [Column(@"AVG_DISCOUNT_PRICE", Order = 29, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal AVG_DISCOUNT_PRICE { get; set; } // AVG_DISCOUNT_PRICE

        [Column(@"AVG_DISCOUNT_PRICE_FC", Order = 30, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal AVG_DISCOUNT_PRICE_FC { get; set; } // AVG_DISCOUNT_PRICE_FC

        [Column(@"PRICE_AFTER_AVG_DISCOUNT", Order = 31, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_AVG_DISCOUNT { get; set; } // PRICE_AFTER_AVG_DISCOUNT

        [Column(@"PRICE_AFTER_AVG_DISCOUNT_FC", Order = 32, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_AFTER_AVG_DISCOUNT_FC { get; set; } // PRICE_AFTER_AVG_DISCOUNT_FC

        [Column(@"PRICE_BEFORE_VAT", Order = 33, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_BEFORE_VAT { get; set; } // PRICE_BEFORE_VAT

        [Column(@"PRICE_BEFORE_VAT_FC", Order = 34, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_BEFORE_VAT_FC { get; set; } // PRICE_BEFORE_VAT_FC

        [Column(@"PRICE_BEFORE_VAT_BASE", Order = 35, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal PRICE_BEFORE_VAT_BASE { get; set; } // PRICE_BEFORE_VAT_BASE

        [Column(@"COMMENTS", Order = 36, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 37, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 38, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 39, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 40, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 41, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 42, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM_LOCATION> PUR_PURCHASE_ORDER_ITEM_LOCATION { get; set; } // PUR_PURCHASE_ORDER_ITEM_LOCATION.FK_PUR_PURCHASE_ORDER_ITEM_LOCATION_PURCHASE_ORDER_ITEM_ID

        public virtual INV_PRODUCT INV_PRODUCT { get; set; } // FK_PUR_PURCHASE_ORDER_ITEM_PRODUCT_ID
        public virtual INV_UOM INV_UOM { get; set; } // FK_PUR_PURCHASE_ORDER_ITEM_UOM_ID
        public virtual PUR_PURCHASE_ORDER PUR_PURCHASE_ORDER { get; set; } // FK_PUR_PURCHASE_ORDER_ITEM_PURCHASE_ORDER_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_PUR_PURCHASE_ORDER_ITEM_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_PUR_PURCHASE_ORDER_ITEM_LAST_UPDATED_BY_ID

        public PUR_PURCHASE_ORDER_ITEM()
        {
            this.PUR_PURCHASE_ORDER_ITEM_LOCATION = new List<PUR_PURCHASE_ORDER_ITEM_LOCATION>();
        }
    }
}

