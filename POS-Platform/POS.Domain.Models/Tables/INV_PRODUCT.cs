using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("INV_PRODUCT")]
    public class INV_PRODUCT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"PRODUCT_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid PRODUCT_ID { get; set; } // PRODUCT_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"UPC", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? UPC { get; set; } // UPC (length: 50)

        [Column(@"PRODUCT_CODE", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? PRODUCT_CODE { get; set; } // PRODUCT_CODE (length: 50)

        [Column(@"PRODUCT_SUPPLIER_CODE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? PRODUCT_SUPPLIER_CODE { get; set; } // PRODUCT_SUPPLIER_CODE (length: 50)

        [Column(@"PRODUCT_NAME_THA", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? PRODUCT_NAME_THA { get; set; } // PRODUCT_NAME_THA (length: 300)

        [Column(@"PRODUCT_NAME_ENG", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? PRODUCT_NAME_ENG { get; set; } // PRODUCT_NAME_ENG (length: 300)

        [Column(@"PRODUCT_TYPE_ID", Order = 8, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PRODUCT_TYPE_ID { get; set; } // PRODUCT_TYPE_ID

        [Column(@"CALCULATE_COST_TYPE_ID", Order = 9, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CALCULATE_COST_TYPE_ID { get; set; } // CALCULATE_COST_TYPE_ID

        [Column(@"IS_TAX", Order = 10, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_TAX { get; set; } // IS_TAX

        [Column(@"IS_SERIAL_CONTROL", Order = 11, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_SERIAL_CONTROL { get; set; } // IS_SERIAL_CONTROL

        [Column(@"CATEGORY_ID", Order = 12, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? CATEGORY_ID { get; set; } // CATEGORY_ID

        [Column(@"SUB_CATEGORY_ID", Order = 13, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? SUB_CATEGORY_ID { get; set; } // SUB_CATEGORY_ID

        [Column(@"BRAND_ID", Order = 14, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? BRAND_ID { get; set; } // BRAND_ID

        [Column(@"UOM_ID", Order = 15, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? UOM_ID { get; set; } // UOM_ID

        [Column(@"MODEL", Order = 16, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? MODEL { get; set; } // MODEL (length: 300)

        [Column(@"COLOR_ID", Order = 17, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? COLOR_ID { get; set; } // COLOR_ID

        [Column(@"SPECIFICATION_ID", Order = 18, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? SPECIFICATION_ID { get; set; } // SPECIFICATION_ID

        [Column(@"WEIGHT", Order = 19, TypeName = SQLSERVER_CONST.MONEY)]
        [Required]
        public decimal WEIGHT { get; set; } // WEIGHT

        [Column(@"WIDTH", Order = 20, TypeName = SQLSERVER_CONST.MONEY)]
        [Required]
        public decimal WIDTH { get; set; } // WIDTH

        [Column(@"DEPTH", Order = 21, TypeName = SQLSERVER_CONST.MONEY)]
        [Required]
        public decimal DEPTH { get; set; } // DEPTH

        [Column(@"HEIGHT", Order = 22, TypeName = SQLSERVER_CONST.MONEY)]
        [Required]
        public decimal HEIGHT { get; set; } // HEIGHT

        [Column(@"WARRANTY_DAYS", Order = 23, TypeName = SQLSERVER_CONST.INT)]
        public int? WARRANTY_DAYS { get; set; } // WARRANTY_DAYS

        [Column(@"SUPPLIER_WARRANTY_DAYS", Order = 24, TypeName = SQLSERVER_CONST.INT)]
        public int? SUPPLIER_WARRANTY_DAYS { get; set; } // SUPPLIER_WARRANTY_DAYS

        [Column(@"IS_EOL", Order = 25, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_EOL { get; set; } // IS_EOL

        [Column(@"COMMENTS", Order = 26, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 27, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 28, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 29, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 30, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 31, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 32, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<INV_PRODDUCT_SELLING_POINT> INV_PRODDUCT_SELLING_POINT { get; set; } // INV_PRODDUCT_SELLING_POINT.FK_INV_PRODDUCT_SELLING_POINT_PRODUCT_ID
        public virtual ICollection<INV_PRODUCT_IMAGE> INV_PRODUCT_IMAGE { get; set; } // INV_PRODUCT_IMAGE.FK_INV_PRODUCT_IMAGE_PRODUCT_ID
        public virtual ICollection<INV_PRODUCT_SPECIFICATION> INV_PRODUCT_SPECIFICATION { get; set; } // INV_PRODUCT_SPECIFICATION.FK_INV_PRODUCT_SPECIFICATION_PRODUCT_ID
        public virtual ICollection<INV_STOCK_REQUISITION_ITEM> INV_STOCK_REQUISITION_ITEM { get; set; } // INV_STOCK_REQUISITION_ITEM.FK_INV_STOCK_REQUISITION_ITEM_PRODUCT_ID
        public virtual ICollection<PUR_GOODS_RECEIPT_ITEM_SERIAL> PUR_GOODS_RECEIPT_ITEM_SERIAL { get; set; } // PUR_GOODS_RECEIPT_ITEM_SERIAL.FK_PUR_GOODS_RECEIPT_ITEM_SERIAL_PRODUCT_ID
        public virtual ICollection<PUR_GOODS_RECEIPT_ITEM> PUR_GOODS_RECEIPT_ITEM { get; set; } // PUR_GOODS_RECEIPT_ITEM.FK_PUR_GOODS_RECEIPT_ITEM_PRODUCT_ID
        public virtual ICollection<PUR_GOODS_RETURN_ITEM_SERIAL> PUR_GOODS_RETURN_ITEM_SERIAL { get; set; } // PUR_GOODS_RETURN_ITEM_SERIAL.FK_PUR_GOODS_RETURN_ITEM_SERIAL_PRODUCT_ID
        public virtual ICollection<PUR_GOODS_RETURN_ITEM> PUR_GOODS_RETURN_ITEM { get; set; } // PUR_GOODS_RETURN_ITEM.FK_PUR_GOODS_RETURN_ITEM_PRODUCT_ID
        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM_LOCATION> PUR_PURCHASE_ORDER_ITEM_LOCATION { get; set; } // PUR_PURCHASE_ORDER_ITEM_LOCATION.FK_PUR_PURCHASE_ORDER_ITEM_LOCATION_PRODUCT_ID
        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM> PUR_PURCHASE_ORDER_ITEM { get; set; } // PUR_PURCHASE_ORDER_ITEM.FK_PUR_PURCHASE_ORDER_ITEM_PRODUCT_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION_ITEM> PUR_PURCHASE_REQUISITION_ITEM { get; set; } // PUR_PURCHASE_REQUISITION_ITEM.FK_PUR_PURCHASE_REQUISITION_ITEM_PRODUCT_ID

        public virtual INV_SUB_CATEGORY INV_SUB_CATEGORY { get; set; } // FK_INV_PRODUCT_SUB_CATEGORY_ID
        public virtual INV_UOM INV_UOM { get; set; } // FK_INV_PRODUCT_UOM_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_INV_PRODUCT_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_INV_PRODUCT_LAST_UPDATED_BY_ID

        public INV_PRODUCT()
        {
            this.INV_PRODDUCT_SELLING_POINT = new List<INV_PRODDUCT_SELLING_POINT>();
            this.INV_PRODUCT_IMAGE = new List<INV_PRODUCT_IMAGE>();
            this.INV_PRODUCT_SPECIFICATION = new List<INV_PRODUCT_SPECIFICATION>();
            this.INV_STOCK_REQUISITION_ITEM = new List<INV_STOCK_REQUISITION_ITEM>();
            this.PUR_GOODS_RECEIPT_ITEM = new List<PUR_GOODS_RECEIPT_ITEM>();
            this.PUR_GOODS_RECEIPT_ITEM_SERIAL = new List<PUR_GOODS_RECEIPT_ITEM_SERIAL>();
            this.PUR_GOODS_RETURN_ITEM = new List<PUR_GOODS_RETURN_ITEM>();
            this.PUR_GOODS_RETURN_ITEM_SERIAL = new List<PUR_GOODS_RETURN_ITEM_SERIAL>();
            this.PUR_PURCHASE_ORDER_ITEM = new List<PUR_PURCHASE_ORDER_ITEM>();
            this.PUR_PURCHASE_ORDER_ITEM_LOCATION = new List<PUR_PURCHASE_ORDER_ITEM_LOCATION>();
            this.PUR_PURCHASE_REQUISITION_ITEM = new List<PUR_PURCHASE_REQUISITION_ITEM>();
        }
    }
}

