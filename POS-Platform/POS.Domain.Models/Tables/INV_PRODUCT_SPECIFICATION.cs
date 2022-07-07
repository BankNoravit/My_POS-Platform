using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("INV_PRODUCT_SPECIFICATION")]
    public class INV_PRODUCT_SPECIFICATION
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"PRODUCT_SPECIFICATION_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid PRODUCT_SPECIFICATION_ID { get; set; } // PRODUCT_SPECIFICATION_ID (Primary key)

        [Column(@"PRODUCT_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid PRODUCT_ID { get; set; } // PRODUCT_ID

        [Column(@"SPECIFICATION_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid SPECIFICATION_ID { get; set; } // SPECIFICATION_ID

        [Column(@"SPECIFICATION_ITEM_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid SPECIFICATION_ITEM_ID { get; set; } // SPECIFICATION_ITEM_ID

        [Column(@"SPECIFICATION_ITEM_VALUE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? SPECIFICATION_ITEM_VALUE { get; set; } // SPECIFICATION_ITEM_VALUE (length: 300)

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

        public virtual INV_PRODUCT INV_PRODUCT { get; set; } // FK_INV_PRODUCT_SPECIFICATION_PRODUCT_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_INV_PRODUCT_SPECIFICATION_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_INV_PRODUCT_SPECIFICATION_LAST_UPDATED_BY_ID

        public INV_PRODUCT_SPECIFICATION()
        {
        }
    }
}

