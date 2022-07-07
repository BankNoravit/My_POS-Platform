using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("PUR_GOODS_RETURN_ITEM_SERIAL")]
    public class PUR_GOODS_RETURN_ITEM_SERIAL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"GOODS_RETURN_ITEM_SERIAL_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid GOODS_RETURN_ITEM_SERIAL_ID { get; set; } // GOODS_RETURN_ITEM_SERIAL_ID (Primary key)

        [Column(@"GOODS_RETURN_ITEM_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid GOODS_RETURN_ITEM_ID { get; set; } // GOODS_RETURN_ITEM_ID

        [Column(@"PRODUCT_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PRODUCT_ID { get; set; } // PRODUCT_ID

        [Column(@"SEQ_NO", Order = 4, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int SEQ_NO { get; set; } // SEQ_NO

        [Column(@"QTY", Order = 5, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal QTY { get; set; } // QTY

        [Column(@"SERIAL", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? SERIAL { get; set; } // SERIAL (length: 300)

        [Column(@"COMMENTS", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 8, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 9, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 10, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 11, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"STATUS", Order = 12, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int STATUS { get; set; } // STATUS

        [Column(@"IS_DELETE", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual INV_PRODUCT INV_PRODUCT { get; set; } // FK_PUR_GOODS_RETURN_ITEM_SERIAL_PRODUCT_ID
        public virtual PUR_GOODS_RETURN_ITEM PUR_GOODS_RETURN_ITEM { get; set; } // FK_PUR_GOODS_RETURN_ITEM_SERIAL_GOODS_RETURN_ITEM_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_PUR_GOODS_RETURN_ITEM_SERIAL_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_PUR_GOODS_RETURN_ITEM_SERIAL_LAST_UPDATED_BY_ID

        public PUR_GOODS_RETURN_ITEM_SERIAL()
        {
        }
    }
}

