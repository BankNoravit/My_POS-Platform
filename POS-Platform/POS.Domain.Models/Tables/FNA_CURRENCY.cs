using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("FNA_CURRENCY")]
    public class FNA_CURRENCY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"CURRENCY_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid CURRENCY_ID { get; set; } // CURRENCY_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"CURRENCY_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? CURRENCY_CODE { get; set; } // CURRENCY_CODE (length: 50)

        [Column(@"CURRENCY_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? CURRENCY_NAME_THA { get; set; } // CURRENCY_NAME_THA (length: 300)

        [Column(@"CURRENCY_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? CURRENCY_NAME_ENG { get; set; } // CURRENCY_NAME_ENG (length: 300)

        [Column(@"EXCHANGE_RATE", Order = 6, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal EXCHANGE_RATE { get; set; } // EXCHANGE_RATE

        [Column(@"RATE_CURRENCY", Order = 7, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal RATE_CURRENCY { get; set; } // RATE_CURRENCY

        [Column(@"ADJ_RATE", Order = 8, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal ADJ_RATE { get; set; } // ADJ_RATE

        [Column(@"SPOT_RATE", Order = 9, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal SPOT_RATE { get; set; } // SPOT_RATE

        [Column(@"LANDED_RATE", Order = 10, TypeName = SQLSERVER_CONST.DECIMAL_28_6)]
        [Required]
        public decimal LANDED_RATE { get; set; } // LANDED_RATE

        [Column(@"COMMENTS", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 12, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 13, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 14, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 15, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 16, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 17, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<PUR_GOODS_RECEIPT> PUR_GOODS_RECEIPT { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_CURRENCY_ID
        public virtual ICollection<PUR_GOODS_RETURN> PUR_GOODS_RETURN { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_CURRENCY_ID
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_CURRENCY_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_CURRENCY_ID

        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_FNA_CURRENCY_COMPANY_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_FNA_CURRENCY_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_FNA_CURRENCY_LAST_UPDATED_BY_ID

        public FNA_CURRENCY()
        {
            this.PUR_GOODS_RECEIPT = new List<PUR_GOODS_RECEIPT>();
            this.PUR_GOODS_RETURN = new List<PUR_GOODS_RETURN>();
            this.PUR_PURCHASE_ORDER = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_REQUISITION = new List<PUR_PURCHASE_REQUISITION>();
        }
    }
}

