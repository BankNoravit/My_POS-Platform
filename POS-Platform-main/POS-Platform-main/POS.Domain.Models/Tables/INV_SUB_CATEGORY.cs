using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("INV_SUB_CATEGORY")]
    public class INV_SUB_CATEGORY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"SUB_CATEGORY_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid SUB_CATEGORY_ID { get; set; } // SUB_CATEGORY_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"CATEGORY_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CATEGORY_ID { get; set; } // CATEGORY_ID

        [Column(@"SUB_CATEGORY_CODE", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? SUB_CATEGORY_CODE { get; set; } // SUB_CATEGORY_CODE (length: 50)

        [Column(@"SUB_CATEGORY_NAME_THA", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? SUB_CATEGORY_NAME_THA { get; set; } // SUB_CATEGORY_NAME_THA (length: 300)

        [Column(@"SUB_CATEGORY_NAME_ENG", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? SUB_CATEGORY_NAME_ENG { get; set; } // SUB_CATEGORY_NAME_ENG (length: 300)

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

        [Column(@"IS_ACTIVE", Order = 12, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<INV_PRODUCT> INV_PRODUCT { get; set; } // INV_PRODUCT.FK_INV_PRODUCT_SUB_CATEGORY_ID
        [InverseProperty("INV_SUB_CATEGORY_SUB_CATEGORY")]
        public virtual INV_SUB_CATEGORY INV_SUB_CATEGORY_CHILD { get; set; } // INV_SUB_CATEGORY.FK_INV_SUB_CATEGORY_INV_SUB_CATEGORY

        public virtual INV_SUB_CATEGORY INV_SUB_CATEGORY_SUB_CATEGORY { get; set; } // FK_INV_SUB_CATEGORY_INV_SUB_CATEGORY
        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_INV_SUB_CATEGORY_COMPANY_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_INV_SUB_CATEGORY_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_INV_SUB_CATEGORY_LAST_UPDATED_BY_ID

        public INV_SUB_CATEGORY()
        {
            this.INV_PRODUCT = new List<INV_PRODUCT>();
        }
    }
}

