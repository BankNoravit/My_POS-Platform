using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SAL_CUSTOMER_CONTACT")]
    public class SAL_CUSTOMER_CONTACT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"CUSTOMER_CONTACT_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid CUSTOMER_CONTACT_ID { get; set; } // CUSTOMER_CONTACT_ID (Primary key)

        [Column(@"CUSTOMER_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CUSTOMER_ID { get; set; } // CUSTOMER_ID

        [Column(@"CONTACT_NAME", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? CONTACT_NAME { get; set; } // CONTACT_NAME (length: 300)

        [Column(@"POSITION_NAME", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? POSITION_NAME { get; set; } // POSITION_NAME (length: 100)

        [Column(@"DEPARTMENT_NAME", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? DEPARTMENT_NAME { get; set; } // DEPARTMENT_NAME (length: 100)

        [Column(@"PHONE", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [Required]
        [MaxLength(100)]
        public string? PHONE { get; set; } // PHONE (length: 100)

        [Column(@"FAX", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FAX { get; set; } // FAX (length: 100)

        [Column(@"EMAIL", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? EMAIL { get; set; } // EMAIL (length: 100)

        [Column(@"LINE_ID", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? LINE_ID { get; set; } // LINE_ID (length: 100)

        [Column(@"FACEBOOK_ID", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FACEBOOK_ID { get; set; } // FACEBOOK_ID (length: 100)

        [Column(@"IS_DEFAULT", Order = 11, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DEFAULT { get; set; } // IS_DEFAULT

        [Column(@"COMMENTS", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 13, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 14, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 15, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 16, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 17, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 18, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual SAL_CUSTOMER SAL_CUSTOMER { get; set; } // FK_SAL_CUSTOMER_CONTACT_CUSTOMER_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SAL_CUSTOMER_CONTACT_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SAL_CUSTOMER_CONTACT_LAST_UPDATED_BY_ID

        public SAL_CUSTOMER_CONTACT()
        {
        }
    }
}

