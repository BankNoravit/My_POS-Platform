using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ORG_POSITION_LEVEL")]
    public class ORG_POSITION_LEVEL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"POSITION_LEVEL_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid POSITION_LEVEL_ID { get; set; } // POSITION_LEVEL_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"POSITION_LEVEL_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? POSITION_LEVEL_CODE { get; set; } // POSITION_LEVEL_CODE (length: 50)

        [Column(@"POSITION_LEVEL_NAME_THA", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? POSITION_LEVEL_NAME_THA { get; set; } // POSITION_LEVEL_NAME_THA (length: 300)

        [Column(@"POSITION_LEVEL_NAME_ENG", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? POSITION_LEVEL_NAME_ENG { get; set; } // POSITION_LEVEL_NAME_ENG (length: 300)

        [Column(@"POSITION_LEVEL", Order = 6, TypeName = SQLSERVER_CONST.INT)]
        [Required]
        public int POSITION_LEVEL { get; set; } // POSITION_LEVEL

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

        public virtual ICollection<ORG_POSITION> ORG_POSITION { get; set; } // ORG_POSITION.FK_ORG_POSITION_POSITION_LEVEL_ID

        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_ORG_POSITION_LEVEL_COMPANY_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_ORG_POSITION_LEVEL_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ORG_POSITION_LEVEL_LAST_UPDATED_BY_ID

        public ORG_POSITION_LEVEL()
        {
            this.ORG_POSITION = new List<ORG_POSITION>();
        }
    }
}

