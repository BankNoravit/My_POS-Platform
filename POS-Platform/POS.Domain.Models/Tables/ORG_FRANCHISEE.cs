using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ORG_FRANCHISEE")]
    public class ORG_FRANCHISEE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"FRANCHISEE_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid FRANCHISEE_ID { get; set; } // FRANCHISEE_ID (Primary key)

        [Column(@"FRANCHISEE_CODE", Order = 2, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? FRANCHISEE_CODE { get; set; } // FRANCHISEE_CODE (length: 50)

        [Column(@"FRANCHISEE_NAME_THA", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? FRANCHISEE_NAME_THA { get; set; } // FRANCHISEE_NAME_THA (length: 300)

        [Column(@"FRANCHISEE_NAME_ENG", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? FRANCHISEE_NAME_ENG { get; set; } // FRANCHISEE_NAME_ENG (length: 300)

        [Column(@"PHONE", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? PHONE { get; set; } // PHONE (length: 100)

        [Column(@"FAX", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FAX { get; set; } // FAX (length: 100)

        [Column(@"EMAIL", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? EMAIL { get; set; } // EMAIL (length: 100)

        [Column(@"LINE_OFFICIAL_ID", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? LINE_OFFICIAL_ID { get; set; } // LINE_OFFICIAL_ID (length: 100)

        [Column(@"FACEBOOK_ID", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [MaxLength(100)]
        public string? FACEBOOK_ID { get; set; } // FACEBOOK_ID (length: 100)

        [Column(@"WEBSITE", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? WEBSITE { get; set; } // WEBSITE (length: 300)

        [Column(@"LOGO_URL", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? LOGO_URL { get; set; } // LOGO_URL (length: 300)

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

        public virtual ICollection<ORG_BRANCH> ORG_BRANCH { get; set; } // ORG_BRANCH.FK_ORG_BRANCH_FRANCHISEE_ID
        public virtual ICollection<ORG_FRANCHISEE_ADDRESS> ORG_FRANCHISEE_ADDRESS { get; set; } // ORG_FRANCHISEE_ADDRESS.FK_ORG_FRANCHISEE_ADDRESS_FRANCHISEE_ID

        public virtual SYS_USER CREATED_BY { get; set; } // FK_ORG_FRANCHISEE_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ORG_FRANCHISEE_LAST_UPDATED_BY_ID

        public ORG_FRANCHISEE()
        {
            this.ORG_BRANCH = new List<ORG_BRANCH>();
            this.ORG_FRANCHISEE_ADDRESS = new List<ORG_FRANCHISEE_ADDRESS>();
        }
    }
}

