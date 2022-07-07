using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_OBJECT")]
    public class SYS_OBJECT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"OBJECT_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid OBJECT_ID { get; set; } // OBJECT_ID (Primary key)

        [Column(@"OBJECT_RELATE_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? OBJECT_RELATE_ID { get; set; } // OBJECT_RELATE_ID

        [Column(@"OBJECT_CODE", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? OBJECT_CODE { get; set; } // OBJECT_CODE (length: 50)

        [Column(@"OBJECT_NAME", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? OBJECT_NAME { get; set; } // OBJECT_NAME (length: 300)

        [Column(@"OBJECT_NAME_EN", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? OBJECT_NAME_EN { get; set; } // OBJECT_NAME_EN (length: 300)

        [Column(@"OBJECT_TYPE", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [Required]
        [MaxLength(50)]
        public string? OBJECT_TYPE { get; set; } // OBJECT_TYPE (length: 50)

        [Column(@"OBJECT_URL", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_500)]
        [MaxLength(500)]
        public string? OBJECT_URL { get; set; } // OBJECT_URL (length: 500)

        [Column(@"COMMENTS", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 9, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 10, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 11, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 12, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 13, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 14, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        [InverseProperty("SYS_OBJECT_OBJECT_RELATE")]
        public virtual ICollection<SYS_OBJECT> SYS_OBJECT_CHILD { get; set; } // SYS_OBJECT.FK_SYS_OBJECT_OBJECT_RELATE_ID

        public virtual SYS_OBJECT SYS_OBJECT_OBJECT_RELATE { get; set; } // FK_SYS_OBJECT_OBJECT_RELATE_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_SYS_OBJECT_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_SYS_OBJECT_LAST_UPDATED_BY_ID

        public SYS_OBJECT()
        {
            this.SYS_OBJECT_CHILD = new List<SYS_OBJECT>();
        }
    }
}

