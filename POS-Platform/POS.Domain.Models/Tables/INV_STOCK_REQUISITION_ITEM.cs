using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("INV_STOCK_REQUISITION_ITEM")]
    public class INV_STOCK_REQUISITION_ITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"STOCK_REQUISITION_ITEM_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid STOCK_REQUISITION_ITEM_ID { get; set; } // STOCK_REQUISITION_ITEM_ID (Primary key)

        [Column(@"STOCK_REQUISITION_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid STOCK_REQUISITION_ID { get; set; } // STOCK_REQUISITION_ID

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

        [Column(@"UOM_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid UOM_ID { get; set; } // UOM_ID

        [Column(@"UOM_CODE", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? UOM_CODE { get; set; } // UOM_CODE (length: 50)

        [Column(@"UOM_NAME", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? UOM_NAME { get; set; } // UOM_NAME (length: 300)

        [Column(@"WAREHOUSE_ID", Order = 10, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid WAREHOUSE_ID { get; set; } // WAREHOUSE_ID

        [Column(@"WAREHOUSE_CODE", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? WAREHOUSE_CODE { get; set; } // WAREHOUSE_CODE (length: 50)

        [Column(@"WAREHOUSE_NAME", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? WAREHOUSE_NAME { get; set; } // WAREHOUSE_NAME (length: 300)

        [Column(@"WAREHOUSE_LOCATION_ID", Order = 13, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid WAREHOUSE_LOCATION_ID { get; set; } // WAREHOUSE_LOCATION_ID

        [Column(@"WAREHOUSE_LOCATION_CODE", Order = 14, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? WAREHOUSE_LOCATION_CODE { get; set; } // WAREHOUSE_LOCATION_CODE (length: 50)

        [Column(@"WAREHOUSE_LOCATION_NAME", Order = 15, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? WAREHOUSE_LOCATION_NAME { get; set; } // WAREHOUSE_LOCATION_NAME (length: 300)

        [Column(@"RATIO", Order = 16, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal RATIO { get; set; } // RATIO

        [Column(@"QTY", Order = 17, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY { get; set; } // QTY

        [Column(@"QTY_BASE", Order = 18, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY_BASE { get; set; } // QTY_BASE

        [Column(@"COMMENTS", Order = 19, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 20, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 21, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 22, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 23, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 24, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 25, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual INV_PRODUCT INV_PRODUCT { get; set; } // FK_INV_STOCK_REQUISITION_ITEM_PRODUCT_ID
        public virtual INV_STOCK_REQUISITION INV_STOCK_REQUISITION { get; set; } // FK_INV_STOCK_REQUISITION_ITEM_STOCK_REQUISITION_ID
        public virtual INV_UOM INV_UOM { get; set; } // FK_INV_STOCK_REQUISITION_ITEM_UOM_ID
        public virtual INV_WAREHOUSE INV_WAREHOUSE { get; set; } // FK_INV_STOCK_REQUISITION_ITEM_WAREHOUSE_ID
        public virtual INV_WAREHOUSE_LOCATION INV_WAREHOUSE_LOCATION { get; set; } // FK_INV_STOCK_REQUISITION_ITEM_WAREHOUSE_LOCATION_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_INV_STOCK_REQUISITION_ITEM_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_INV_STOCK_REQUISITION_ITEM_LAST_UPDATED_BY_ID

        public INV_STOCK_REQUISITION_ITEM()
        {
        }
    }
}

