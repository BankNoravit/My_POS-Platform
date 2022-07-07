using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("FNA_TAX")]
    public class FNA_TAX
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"TAX_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid TAX_ID { get; set; } // TAX_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"TAX_TYPE_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid TAX_TYPE_ID { get; set; } // TAX_TYPE_ID

        [Column(@"TAX_CODE", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? TAX_CODE { get; set; } // TAX_CODE (length: 50)

        [Column(@"TAX_NAME_THA", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? TAX_NAME_THA { get; set; } // TAX_NAME_THA (length: 300)

        [Column(@"TAX_NAME_ENG", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? TAX_NAME_ENG { get; set; } // TAX_NAME_ENG (length: 300)

        [Column(@"TAX_RATE", Order = 7, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal TAX_RATE { get; set; } // TAX_RATE

        [Column(@"TAX_BASE", Order = 8, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal TAX_BASE { get; set; } // TAX_BASE

        [Column(@"COMMENTS", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 10, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 11, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 12, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 13, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 14, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 15, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        [InverseProperty("FNA_TAX_VAT")]
        public virtual ICollection<PUR_GOODS_RECEIPT> VAT { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_VAT_ID
        [InverseProperty("FNA_TAX_VAT")]
        public virtual ICollection<PUR_GOODS_RETURN> PUR_GOODS_RETURN_VAT { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_VAT_ID
        [InverseProperty("FNA_TAX_VAT")]
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER_VAT { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_VAT_ID
        [InverseProperty("FNA_TAX_VAT")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION_VAT { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_VAT_ID
        public virtual ICollection<PUR_VENDOR> PUR_VENDOR { get; set; } // PUR_VENDOR.FK_PUR_VENDOR_TAX_ID
        public virtual ICollection<SAL_CUSTOMER> SAL_CUSTOMER { get; set; } // SAL_CUSTOMER.FK_SAL_CUSTOMER_TAX_ID

        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_FNA_TAX_COMPANY_ID
        public virtual SYS_FLEX_ITEM TAX_TYPE { get; set; } // FK_FNA_TAX_TAX_TYPE_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_FNA_TAX_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_FNA_TAX_LAST_UPDATED_BY_ID

        public FNA_TAX()
        {
            this.VAT = new List<PUR_GOODS_RECEIPT>();
            this.PUR_GOODS_RETURN_VAT = new List<PUR_GOODS_RETURN>();
            this.PUR_PURCHASE_ORDER_VAT = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_REQUISITION_VAT = new List<PUR_PURCHASE_REQUISITION>();
            this.PUR_VENDOR = new List<PUR_VENDOR>();
            this.SAL_CUSTOMER = new List<SAL_CUSTOMER>();
        }
    }
}

