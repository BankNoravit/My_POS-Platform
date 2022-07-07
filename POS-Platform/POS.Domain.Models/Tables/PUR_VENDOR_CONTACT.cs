using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("PUR_VENDOR_CONTACT")]
    public class PUR_VENDOR_CONTACT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"VENDOR_CONTACT_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid VENDOR_CONTACT_ID { get; set; } // VENDOR_CONTACT_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"VENDOR_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid VENDOR_ID { get; set; } // VENDOR_ID

        [Column(@"CONTACT_NAME", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? CONTACT_NAME { get; set; } // CONTACT_NAME (length: 300)

        [Column(@"ADDRESS", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ADDRESS { get; set; } // ADDRESS (length: 300)

        [Column(@"POSITION_NAME", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? POSITION_NAME { get; set; } // POSITION_NAME (length: 100)

        [Column(@"DEPARTMENT_NAME", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? DEPARTMENT_NAME { get; set; } // DEPARTMENT_NAME (length: 100)

        [Column(@"PHONE", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [Required]
        [MaxLength(100)]
        public string? PHONE { get; set; } // PHONE (length: 100)

        [Column(@"FAX", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FAX { get; set; } // FAX (length: 100)

        [Column(@"EMAIL", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? EMAIL { get; set; } // EMAIL (length: 100)

        [Column(@"LINE_ID", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? LINE_ID { get; set; } // LINE_ID (length: 100)

        [Column(@"FACEBOOK_ID", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FACEBOOK_ID { get; set; } // FACEBOOK_ID (length: 100)

        [Column(@"IS_DEFAULT", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DEFAULT { get; set; } // IS_DEFAULT

        [Column(@"COMMENTS", Order = 14, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 15, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 16, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 17, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 18, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 19, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 20, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_VENDOR_CONTACT_ID
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_VENDOR_CONTACT_ID

        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_PUR_VENDOR_CONTACT_COMPANY_ID
        public virtual PUR_VENDOR PUR_VENDOR { get; set; } // FK_PUR_VENDOR_CONTACT_VENDOR_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_PUR_VENDOR_CONTACT_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_PUR_VENDOR_CONTACT_LAST_UPDATED_BY_ID

        public PUR_VENDOR_CONTACT()
        {
            this.PUR_PURCHASE_ORDER = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_REQUISITION = new List<PUR_PURCHASE_REQUISITION>();
        }
    }
}

