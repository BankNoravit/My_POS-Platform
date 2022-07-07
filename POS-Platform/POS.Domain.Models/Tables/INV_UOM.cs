using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("INV_UOM")]
    public class INV_UOM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"UOM_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid UOM_ID { get; set; } // UOM_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"UOM_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? UOM_CODE { get; set; } // UOM_CODE (length: 50)

        [Column(@"UOM_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? UOM_NAME_THA { get; set; } // UOM_NAME_THA (length: 300)

        [Column(@"UOM_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? UOM_NAME_ENG { get; set; } // UOM_NAME_ENG (length: 300)

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

        public virtual ICollection<INV_PRODUCT> INV_PRODUCT { get; set; } // INV_PRODUCT.FK_INV_PRODUCT_UOM_ID
        public virtual ICollection<INV_STOCK_REQUISITION_ITEM> INV_STOCK_REQUISITION_ITEM { get; set; } // INV_STOCK_REQUISITION_ITEM.FK_INV_STOCK_REQUISITION_ITEM_UOM_ID
        public virtual ICollection<PUR_GOODS_RECEIPT_ITEM> PUR_GOODS_RECEIPT_ITEM { get; set; } // PUR_GOODS_RECEIPT_ITEM.FK_PUR_GOODS_RECEIPT_ITEM_UOM_ID
        public virtual ICollection<PUR_GOODS_RETURN_ITEM> PUR_GOODS_RETURN_ITEM { get; set; } // PUR_GOODS_RETURN_ITEM.FK_PUR_GOODS_RETURN_ITEM_UOM_ID
        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM> PUR_PURCHASE_ORDER_ITEM { get; set; } // PUR_PURCHASE_ORDER_ITEM.FK_PUR_PURCHASE_ORDER_ITEM_UOM_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION_ITEM> PUR_PURCHASE_REQUISITION_ITEM { get; set; } // PUR_PURCHASE_REQUISITION_ITEM.FK_PUR_PURCHASE_REQUISITION_ITEM_UOM_ID

        public virtual SYS_USER CREATED_BY { get; set; } // FK_INV_UOM_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_INV_UOM_LAST_UPDATED_BY_ID

        public INV_UOM()
        {
            this.INV_PRODUCT = new List<INV_PRODUCT>();
            this.INV_STOCK_REQUISITION_ITEM = new List<INV_STOCK_REQUISITION_ITEM>();
            this.PUR_GOODS_RECEIPT_ITEM = new List<PUR_GOODS_RECEIPT_ITEM>();
            this.PUR_GOODS_RETURN_ITEM = new List<PUR_GOODS_RETURN_ITEM>();
            this.PUR_PURCHASE_ORDER_ITEM = new List<PUR_PURCHASE_ORDER_ITEM>();
            this.PUR_PURCHASE_REQUISITION_ITEM = new List<PUR_PURCHASE_REQUISITION_ITEM>();
        }
    }
}

