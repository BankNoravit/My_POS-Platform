using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("INV_STOCK_REQUISITION")]
    public class INV_STOCK_REQUISITION
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"STOCK_REQUISITION_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid STOCK_REQUISITION_ID { get; set; } // STOCK_REQUISITION_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"BRANCH_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BRANCH_ID { get; set; } // BRANCH_ID

        [Column(@"BRANCH_TO_ID", Order = 4, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BRANCH_TO_ID { get; set; } // BRANCH_TO_ID

        [Column(@"BRANCH_TO_CODE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? BRANCH_TO_CODE { get; set; } // BRANCH_TO_CODE (length: 50)

        [Column(@"BRANCH_TO_NAME", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? BRANCH_TO_NAME { get; set; } // BRANCH_TO_NAME (length: 300)

        [Column(@"WAREHOUSE_TO_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid WAREHOUSE_TO_ID { get; set; } // WAREHOUSE_TO_ID

        [Column(@"WAREHOUSE_TO_CODE", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? WAREHOUSE_TO_CODE { get; set; } // WAREHOUSE_TO_CODE (length: 50)

        [Column(@"WAREHOUSE_TO_NAME", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? WAREHOUSE_TO_NAME { get; set; } // WAREHOUSE_TO_NAME (length: 300)

        [Column(@"WAREHOUSE_LOCATION_TO_ID", Order = 10, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid WAREHOUSE_LOCATION_TO_ID { get; set; } // WAREHOUSE_LOCATION_TO_ID

        [Column(@"WAREHOUSE_LOCATION_TO_CODE", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? WAREHOUSE_LOCATION_TO_CODE { get; set; } // WAREHOUSE_LOCATION_TO_CODE (length: 50)

        [Column(@"WAREHOUSE_LOCATION_TO_NAME", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? WAREHOUSE_LOCATION_TO_NAME { get; set; } // WAREHOUSE_LOCATION_TO_NAME (length: 300)

        [Column(@"TRANSACTION_TYPE", Order = 13, TypeName = SQLSERVER_CONST.VARCHAR_3)]
        [Required]
        [MaxLength(3)]
        public string? TRANSACTION_TYPE { get; set; } // TRANSACTION_TYPE (length: 3)

        [Column(@"STOCK_REQUISITION_NO", Order = 14, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? STOCK_REQUISITION_NO { get; set; } // STOCK_REQUISITION_NO (length: 50)

        [Column(@"STOCK_REQUISITION_DATE", Order = 15, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime STOCK_REQUISITION_DATE { get; set; } // STOCK_REQUISITION_DATE

        [Column(@"REFERENCE_NO", Order = 16, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? REFERENCE_NO { get; set; } // REFERENCE_NO (length: 50)

        [Column(@"REFERENCE_DATE", Order = 17, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? REFERENCE_DATE { get; set; } // REFERENCE_DATE

        [Column(@"REQUISITION_BY_ID", Order = 18, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid REQUISITION_BY_ID { get; set; } // REQUISITION_BY_ID

        [Column(@"REQUISITION_BY_CODE", Order = 19, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? REQUISITION_BY_CODE { get; set; } // REQUISITION_BY_CODE (length: 50)

        [Column(@"REQUISITION_BY_NAME", Order = 20, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? REQUISITION_BY_NAME { get; set; } // REQUISITION_BY_NAME (length: 300)

        [Column(@"APPROVAL_STATUS_ID", Order = 21, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid APPROVAL_STATUS_ID { get; set; } // APPROVAL_STATUS_ID

        [Column(@"APPROVAL_STATUS_CODE", Order = 22, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? APPROVAL_STATUS_CODE { get; set; } // APPROVAL_STATUS_CODE (length: 50)

        [Column(@"APPROVAL_STATUS_NAME", Order = 23, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? APPROVAL_STATUS_NAME { get; set; } // APPROVAL_STATUS_NAME (length: 300)

        [Column(@"APPROVAL_DATE", Order = 24, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? APPROVAL_DATE { get; set; } // APPROVAL_DATE

        [Column(@"DOCUMENT_STATUS_ID", Order = 25, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid DOCUMENT_STATUS_ID { get; set; } // DOCUMENT_STATUS_ID

        [Column(@"DOCUMENT_STATUS_CODE", Order = 26, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? DOCUMENT_STATUS_CODE { get; set; } // DOCUMENT_STATUS_CODE (length: 50)

        [Column(@"DOCUMENT_STATUS_NAME", Order = 27, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? DOCUMENT_STATUS_NAME { get; set; } // DOCUMENT_STATUS_NAME (length: 300)

        [Column(@"COMMENTS", Order = 28, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 29, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 30, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 31, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 32, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 33, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 34, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<INV_STOCK_REQUISITION_ITEM> INV_STOCK_REQUISITION_ITEM { get; set; } // INV_STOCK_REQUISITION_ITEM.FK_INV_STOCK_REQUISITION_ITEM_STOCK_REQUISITION_ID

        public virtual INV_WAREHOUSE WAREHOUSE_TO { get; set; } // FK_INV_STOCK_REQUISITION_WAREHOUSE_ID
        public virtual INV_WAREHOUSE_LOCATION WAREHOUSE_LOCATION_TO { get; set; } // FK_INV_STOCK_REQUISITION_WAREHOUSE_LOCATION_TO_ID
        public virtual ORG_BRANCH BRANCH { get; set; } // FK_INV_STOCK_REQUISITION_BRANCH_ID
        public virtual ORG_BRANCH BRANCH_TO { get; set; } // FK_INV_STOCK_REQUISITION_BRANCH_TO_ID
        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_INV_STOCK_REQUISITION_COMPANY_ID
        public virtual ORG_EMPLOYEE REQUISITION_BY { get; set; } // FK_INV_STOCK_REQUISITION_REQUISITION_BY_ID
        public virtual SYS_FLEX_ITEM APPROVAL_STATUS { get; set; } // FK_INV_STOCK_REQUISITION_APPROVAL_STATUS_ID
        public virtual SYS_FLEX_ITEM DOCUMENT_STATUS { get; set; } // FK_INV_STOCK_REQUISITION_DOCUMENT_STATUS_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_INV_STOCK_REQUISITION_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_INV_STOCK_REQUISITION_LAST_UPDATED_BY_ID

        public INV_STOCK_REQUISITION()
        {
            this.INV_STOCK_REQUISITION_ITEM = new List<INV_STOCK_REQUISITION_ITEM>();
        }
    }
}

