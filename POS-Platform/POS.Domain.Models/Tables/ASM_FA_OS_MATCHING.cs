using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ASM_FA_OS_MATCHING")]
    public class ASM_FA_OS_MATCHING
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ASM_FA_OS_MATCHING_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid ASM_FA_OS_MATCHING_ID { get; set; } // ASM_FA_OS_MATCHING_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"MATCHING_TYPE_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? MATCHING_TYPE_ID { get; set; } // MATCHING_TYPE_ID

        [Column(@"PRODUCT_CODE", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_40)]
        [Required]
        [MaxLength(40)]
        public string? PRODUCT_CODE { get; set; } // PRODUCT_CODE (length: 40)

        [Column(@"PRODUCT_CODE_FA", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_40)]
        [MaxLength(40)]
        public string? PRODUCT_CODE_FA { get; set; } // PRODUCT_CODE_FA (length: 40)

        [Column(@"COMMENTS", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 7, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 8, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 9, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 10, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 11, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 12, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_ASM_FA_OS_MATCHING_COMPANY_ID
        public virtual SYS_FLEX_ITEM MATCHING_TYPE { get; set; } // FK_ASM_FA_OS_MATCHING_MATCHING_TYPE_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_ASM_FA_OS_MATCHING_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ASM_FA_OS_MATCHING_LAST_UPDATED_BY_ID

        public ASM_FA_OS_MATCHING()
        {
        }
    }
}

