using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("PUR_PURCHASE_REQUISITION_ITEM_LOCATION")]
    public class PUR_PURCHASE_REQUISITION_ITEM_LOCATION
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"PURCHASE_REQUISITION_ITEM_LOCATION_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid PURCHASE_REQUISITION_ITEM_LOCATION_ID { get; set; } // PURCHASE_REQUISITION_ITEM_LOCATION_ID (Primary key)

        [Column(@"PURCHASE_REQUISITION_ITEM_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PURCHASE_REQUISITION_ITEM_ID { get; set; } // PURCHASE_REQUISITION_ITEM_ID

        [Column(@"SEQ_NO", Order = 3, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SEQ_NO { get; set; } // SEQ_NO

        [Column(@"BRANCH_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BRANCH_ID { get; set; } // BRANCH_ID

        [Column(@"BRANCH_CODE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? BRANCH_CODE { get; set; } // BRANCH_CODE (length: 50)

        [Column(@"BRANCH_NAME", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? BRANCH_NAME { get; set; } // BRANCH_NAME (length: 300)

        [Column(@"WAREHOUSE_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid WAREHOUSE_ID { get; set; } // WAREHOUSE_ID

        [Column(@"WAREHOUSE_CODE", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? WAREHOUSE_CODE { get; set; } // WAREHOUSE_CODE (length: 50)

        [Column(@"WAREHOUSE_NAME", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? WAREHOUSE_NAME { get; set; } // WAREHOUSE_NAME (length: 300)

        [Column(@"WAREHOUSE_LOCATION_ID", Order = 10, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid WAREHOUSE_LOCATION_ID { get; set; } // WAREHOUSE_LOCATION_ID

        [Column(@"WAREHOUSE_LOCATION_CODE", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? WAREHOUSE_LOCATION_CODE { get; set; } // WAREHOUSE_LOCATION_CODE (length: 50)

        [Column(@"WAREHOUSE_LOCATION_NAME", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? WAREHOUSE_LOCATION_NAME { get; set; } // WAREHOUSE_LOCATION_NAME (length: 300)

        [Column(@"QTY", Order = 13, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY { get; set; } // QTY

        [Column(@"QTY_REMAIN", Order = 14, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY_REMAIN { get; set; } // QTY_REMAIN

        [Column(@"COMMENTS", Order = 15, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 16, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 17, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 18, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 19, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 20, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 21, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual INV_WAREHOUSE INV_WAREHOUSE { get; set; } // FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_WAREHOUSE_ID
        public virtual INV_WAREHOUSE_LOCATION INV_WAREHOUSE_LOCATION { get; set; } // FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_WAREHOUSE_LOCATION_ID
        public virtual ORG_BRANCH ORG_BRANCH { get; set; } // FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_BRANCH_ID
        public virtual PUR_PURCHASE_REQUISITION_ITEM PUR_PURCHASE_REQUISITION_ITEM { get; set; } // FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_PURCHASE_REQUISITION_ITEM_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_LAST_UPDATED_BY_ID

        public PUR_PURCHASE_REQUISITION_ITEM_LOCATION()
        {
        }
    }
}

