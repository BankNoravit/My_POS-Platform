using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_FLEX_ITEM")]
    public class SYS_FLEX_ITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"FLEX_ITEM_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid FLEX_ITEM_ID { get; set; } // FLEX_ITEM_ID (Primary key)

        [Column(@"FLEX_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid FLEX_ID { get; set; } // FLEX_ID

        [Column(@"FLEX_ITEM_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? FLEX_ITEM_CODE { get; set; } // FLEX_ITEM_CODE (length: 50)

        [Column(@"FLEX_ITEM_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? FLEX_ITEM_NAME_THA { get; set; } // FLEX_ITEM_NAME_THA (length: 300)

        [Column(@"FLEX_ITEM_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? FLEX_ITEM_NAME_ENG { get; set; } // FLEX_ITEM_NAME_ENG (length: 300)

        [Column(@"IS_ENABLED", Order = 6, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ENABLED { get; set; } // IS_ENABLED

        [Column(@"EFFECTIVE_DATE_FROM", Order = 7, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? EFFECTIVE_DATE_FROM { get; set; } // EFFECTIVE_DATE_FROM

        [Column(@"EFFECTIVE_DATE_TO", Order = 8, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? EFFECTIVE_DATE_TO { get; set; } // EFFECTIVE_DATE_TO

        [Column(@"ATTRIBUTE1", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE1 { get; set; } // ATTRIBUTE1 (length: 300)

        [Column(@"ATTRIBUTE2", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE2 { get; set; } // ATTRIBUTE2 (length: 300)

        [Column(@"ATTRIBUTE3", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE3 { get; set; } // ATTRIBUTE3 (length: 300)

        [Column(@"ATTRIBUTE4", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE4 { get; set; } // ATTRIBUTE4 (length: 300)

        [Column(@"ATTRIBUTE5", Order = 13, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE5 { get; set; } // ATTRIBUTE5 (length: 300)

        [Column(@"ATTRIBUTE6", Order = 14, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE6 { get; set; } // ATTRIBUTE6 (length: 300)

        [Column(@"ATTRIBUTE7", Order = 15, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE7 { get; set; } // ATTRIBUTE7 (length: 300)

        [Column(@"ATTRIBUTE8", Order = 16, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE8 { get; set; } // ATTRIBUTE8 (length: 300)

        [Column(@"ATTRIBUTE9", Order = 17, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE9 { get; set; } // ATTRIBUTE9 (length: 300)

        [Column(@"ATTRIBUTE10", Order = 18, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ATTRIBUTE10 { get; set; } // ATTRIBUTE10 (length: 300)

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

        [InverseProperty("MATCHING_TYPE")]
        public virtual ICollection<ASM_FA_OS_MATCHING> MATCHING_TYPE { get; set; } // ASM_FA_OS_MATCHING.FK_ASM_FA_OS_MATCHING_MATCHING_TYPE_ID
        [InverseProperty("TAX_TYPE")]
        public virtual ICollection<FNA_TAX> TAX_TYPE { get; set; } // FNA_TAX.FK_FNA_TAX_TAX_TYPE_ID
        [InverseProperty("APPROVAL_STATUS")]
        public virtual ICollection<INV_STOCK_REQUISITION> APPROVAL_STATUS { get; set; } // INV_STOCK_REQUISITION.FK_INV_STOCK_REQUISITION_APPROVAL_STATUS_ID
        [InverseProperty("DOCUMENT_STATUS")]
        public virtual ICollection<INV_STOCK_REQUISITION> DOCUMENT_STATUS { get; set; } // INV_STOCK_REQUISITION.FK_INV_STOCK_REQUISITION_DOCUMENT_STATUS_ID
        [InverseProperty("LOCATION")]
        public virtual ICollection<ORG_BRANCH> LOCATION { get; set; } // ORG_BRANCH.FK_ORG_BRANCH_LOCATION_ID
        [InverseProperty("DEPARTMENT_TYPE")]
        public virtual ICollection<ORG_DEPARTMENT> DEPARTMENT_TYPE { get; set; } // ORG_DEPARTMENT.FK_ORG_DEPARTMENT_DEPARTMENT_TYPE_ID
        [InverseProperty("DOCUMENT_STATUS")]
        public virtual ICollection<PUR_GOODS_RECEIPT> PUR_GOODS_RECEIPT_DOCUMENT_STATUS { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_DOCUMENT_STATUS_ID
        [InverseProperty("DOCUMENT_STATUS")]
        public virtual ICollection<PUR_GOODS_RETURN> PUR_GOODS_RETURN_DOCUMENT_STATUS { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_DOCUMENT_STATUS_ID
        [InverseProperty("APPROVAL_STATUS")]
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER_APPROVAL_STATUS { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_APPROVAL_STATUS_ID
        [InverseProperty("DOCUMENT_STATUS")]
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER_DOCUMENT_STATUS { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_DOCUMENT_STATUS_ID
        [InverseProperty("PURCHASE_ORDER_TYPE")]
        public virtual ICollection<PUR_PURCHASE_ORDER> PURCHASE_ORDER_TYPE { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_PURCHASE_ORDER_TYPE_ID
        [InverseProperty("SHIPPING_METHOD")]
        public virtual ICollection<PUR_PURCHASE_ORDER> SHIPPING_METHOD { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_SHIPPING_METHOD_ID
        [InverseProperty("APPROVAL_STATUS")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION_APPROVAL_STATUS { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_APPROVAL_STATUS_ID
        [InverseProperty("DOCUMENT_STATUS")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION_DOCUMENT_STATUS { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_DOCUMENT_STATUS_ID
        [InverseProperty("SHIPPING_METHOD")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION_SHIPPING_METHOD { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_SHIPPING_METHOD_ID
        [InverseProperty("PURCHASE_REQUISITION_TYPE")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PURCHASE_REQUISITION_TYPE { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_PURCHASE_REQUISITION_TYPE_ID
        [InverseProperty("BILLING")]
        public virtual ICollection<PUR_VENDOR> BILLING { get; set; } // PUR_VENDOR.FK_PUR_VENDOR_BILLING_ID
        [InverseProperty("COLLECT")]
        public virtual ICollection<PUR_VENDOR> COLLECT { get; set; } // PUR_VENDOR.FK_PUR_VENDOR_COLLECT_ID
        [InverseProperty("PROSPECT")]
        public virtual ICollection<PUR_VENDOR> PROSPECT { get; set; } // PUR_VENDOR.FK_PUR_VENDOR_PROSPECT_ID
        [InverseProperty("TITLE")]
        public virtual ICollection<PUR_VENDOR> TITLE { get; set; } // PUR_VENDOR.FK_PUR_VENDOR_TITLE_ID
        [InverseProperty("CUSTOMER_TYPE")]
        public virtual ICollection<SAL_CUSTOMER> CUSTOMER_TYPE { get; set; } // SAL_CUSTOMER.FK_SAL_CUSTOMER_CUSTOMER_TYPE_ID
        [InverseProperty("BILLING")]
        public virtual ICollection<SAL_CUSTOMER> SAL_CUSTOMER_BILLING { get; set; } // SAL_CUSTOMER.FK_SAL_CUSTOMER_BILLING_ID
        [InverseProperty("COLLECT")]
        public virtual ICollection<SAL_CUSTOMER> SAL_CUSTOMER_COLLECT { get; set; } // SAL_CUSTOMER.FK_SAL_CUSTOMER_COLLECT_ID
        [InverseProperty("PROSPECT")]
        public virtual ICollection<SAL_CUSTOMER> SAL_CUSTOMER_PROSPECT { get; set; } // SAL_CUSTOMER.FK_SAL_CUSTOMER_PROSPECT_ID
        [InverseProperty("TITLE")]
        public virtual ICollection<SAL_CUSTOMER> SAL_CUSTOMER_TITLE { get; set; } // SAL_CUSTOMER.FK_SAL_CUSTOMER_TITLE_ID

        public virtual SYS_FLEX SYS_FLEX { get; set; } // FK_SYS_FLEX_ITEM_FLEX_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_FLEX_ITEM_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_FLEX_ITEM_LAST_UPDATED_BY_ID

        public SYS_FLEX_ITEM()
        {
            this.MATCHING_TYPE = new List<ASM_FA_OS_MATCHING>();
            this.TAX_TYPE = new List<FNA_TAX>();
            this.APPROVAL_STATUS = new List<INV_STOCK_REQUISITION>();
            this.DOCUMENT_STATUS = new List<INV_STOCK_REQUISITION>();
            this.LOCATION = new List<ORG_BRANCH>();
            this.DEPARTMENT_TYPE = new List<ORG_DEPARTMENT>();
            this.PUR_GOODS_RECEIPT_DOCUMENT_STATUS = new List<PUR_GOODS_RECEIPT>();
            this.PUR_GOODS_RETURN_DOCUMENT_STATUS = new List<PUR_GOODS_RETURN>();
            this.PUR_PURCHASE_ORDER_APPROVAL_STATUS = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_ORDER_DOCUMENT_STATUS = new List<PUR_PURCHASE_ORDER>();
            this.PURCHASE_ORDER_TYPE = new List<PUR_PURCHASE_ORDER>();
            this.SHIPPING_METHOD = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_REQUISITION_APPROVAL_STATUS = new List<PUR_PURCHASE_REQUISITION>();
            this.PUR_PURCHASE_REQUISITION_DOCUMENT_STATUS = new List<PUR_PURCHASE_REQUISITION>();
            this.PURCHASE_REQUISITION_TYPE = new List<PUR_PURCHASE_REQUISITION>();
            this.PUR_PURCHASE_REQUISITION_SHIPPING_METHOD = new List<PUR_PURCHASE_REQUISITION>();
            this.BILLING = new List<PUR_VENDOR>();
            this.COLLECT = new List<PUR_VENDOR>();
            this.PROSPECT = new List<PUR_VENDOR>();
            this.TITLE = new List<PUR_VENDOR>();
            this.SAL_CUSTOMER_BILLING = new List<SAL_CUSTOMER>();
            this.SAL_CUSTOMER_COLLECT = new List<SAL_CUSTOMER>();
            this.CUSTOMER_TYPE = new List<SAL_CUSTOMER>();
            this.SAL_CUSTOMER_PROSPECT = new List<SAL_CUSTOMER>();
            this.SAL_CUSTOMER_TITLE = new List<SAL_CUSTOMER>();
        }
    }
}

