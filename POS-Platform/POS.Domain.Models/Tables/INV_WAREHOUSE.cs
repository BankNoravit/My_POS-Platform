using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("INV_WAREHOUSE")]
    public class INV_WAREHOUSE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"WAREHOUSE_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid WAREHOUSE_ID { get; set; } // WAREHOUSE_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"WAREHOUSE_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? WAREHOUSE_CODE { get; set; } // WAREHOUSE_CODE (length: 50)

        [Column(@"WAREHOUSE_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? WAREHOUSE_NAME_THA { get; set; } // WAREHOUSE_NAME_THA (length: 300)

        [Column(@"WAREHOUSE_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? WAREHOUSE_NAME_ENG { get; set; } // WAREHOUSE_NAME_ENG (length: 300)

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

        public virtual ICollection<INV_STOCK_REQUISITION_ITEM> INV_STOCK_REQUISITION_ITEM { get; set; } // INV_STOCK_REQUISITION_ITEM.FK_INV_STOCK_REQUISITION_ITEM_WAREHOUSE_ID
        [InverseProperty("WAREHOUSE_TO")]
        public virtual ICollection<INV_STOCK_REQUISITION> WAREHOUSE_TO { get; set; } // INV_STOCK_REQUISITION.FK_INV_STOCK_REQUISITION_WAREHOUSE_ID
        public virtual ICollection<INV_WAREHOUSE_ADDRESS> INV_WAREHOUSE_ADDRESS { get; set; } // INV_WAREHOUSE_ADDRESS.FK_INV_WAREHOUSE_ADDRESS_BRANCH_ID
        public virtual ICollection<INV_WAREHOUSE_LOCATION> INV_WAREHOUSE_LOCATION { get; set; } // INV_WAREHOUSE_LOCATION.FK_INV_WAREHOUSE_LOCATION_WAREHOUSE_ID
        public virtual ICollection<PUR_GOODS_RECEIPT> PUR_GOODS_RECEIPT { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_WAREHOUSE_ID
        public virtual ICollection<PUR_GOODS_RETURN> PUR_GOODS_RETURN { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_WAREHOUSE_ID
        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM_LOCATION> PUR_PURCHASE_ORDER_ITEM_LOCATION { get; set; } // PUR_PURCHASE_ORDER_ITEM_LOCATION.FK_PUR_PURCHASE_ORDER_ITEM_LOCATION_WAREHOUSE_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION_ITEM_LOCATION> PUR_PURCHASE_REQUISITION_ITEM_LOCATION { get; set; } // PUR_PURCHASE_REQUISITION_ITEM_LOCATION.FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_WAREHOUSE_ID

        public virtual SYS_USER CREATED_BY { get; set; } // FK_INV_WAREHOUSE_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_INV_WAREHOUSE_LAST_UPDATED_BY_ID

        public INV_WAREHOUSE()
        {
            this.WAREHOUSE_TO = new List<INV_STOCK_REQUISITION>();
            this.INV_STOCK_REQUISITION_ITEM = new List<INV_STOCK_REQUISITION_ITEM>();
            this.INV_WAREHOUSE_ADDRESS = new List<INV_WAREHOUSE_ADDRESS>();
            this.INV_WAREHOUSE_LOCATION = new List<INV_WAREHOUSE_LOCATION>();
            this.PUR_GOODS_RECEIPT = new List<PUR_GOODS_RECEIPT>();
            this.PUR_GOODS_RETURN = new List<PUR_GOODS_RETURN>();
            this.PUR_PURCHASE_ORDER_ITEM_LOCATION = new List<PUR_PURCHASE_ORDER_ITEM_LOCATION>();
            this.PUR_PURCHASE_REQUISITION_ITEM_LOCATION = new List<PUR_PURCHASE_REQUISITION_ITEM_LOCATION>();
        }
    }
}

