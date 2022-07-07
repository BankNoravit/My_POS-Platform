using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("ORG_BRANCH_ADDRESS")]
    public class ORG_BRANCH_ADDRESS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"BRANCH_ADDRESS_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid BRANCH_ADDRESS_ID { get; set; } // BRANCH_ADDRESS_ID (Primary key)

        [Column(@"BRANCH_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid BRANCH_ID { get; set; } // BRANCH_ID

        [Column(@"ADDRESS_LINE_1", Order = 3, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ADDRESS_LINE_1 { get; set; } // ADDRESS_LINE_1 (length: 300)

        [Column(@"ADDRESS_LINE_2", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ADDRESS_LINE_2 { get; set; } // ADDRESS_LINE_2 (length: 300)

        [Column(@"ADDRESS_LINE_3", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ADDRESS_LINE_3 { get; set; } // ADDRESS_LINE_3 (length: 300)

        [Column(@"ADDRESS_NO", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? ADDRESS_NO { get; set; } // ADDRESS_NO (length: 50)

        [Column(@"BUILDING_VILLAGE", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? BUILDING_VILLAGE { get; set; } // BUILDING_VILLAGE (length: 300)

        [Column(@"ROOM_NO", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? ROOM_NO { get; set; } // ROOM_NO (length: 50)

        [Column(@"FLOOR_NO", Order = 9, TypeName = SQLSERVER_CONST.VARCHAR_50)]
        [MaxLength(50)]
        public string? FLOOR_NO { get; set; } // FLOOR_NO (length: 50)

        [Column(@"LANE", Order = 10, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? LANE { get; set; } // LANE (length: 300)

        [Column(@"ROAD", Order = 11, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? ROAD { get; set; } // ROAD (length: 300)

        [Column(@"SUB_DISTRICT_ID", Order = 12, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? SUB_DISTRICT_ID { get; set; } // SUB_DISTRICT_ID

        [Column(@"DISTRICT_ID", Order = 13, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? DISTRICT_ID { get; set; } // DISTRICT_ID

        [Column(@"PROVINCE_ID", Order = 14, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? PROVINCE_ID { get; set; } // PROVINCE_ID

        [Column(@"POSTCODE", Order = 15, TypeName = SQLSERVER_CONST.VARCHAR_5)]
        [MaxLength(5)]
        public string? POSTCODE { get; set; } // POSTCODE (length: 5)

        [Column(@"LATITUDE", Order = 16, TypeName = SQLSERVER_CONST.DECIMAL_10_6)]
        public decimal? LATITUDE { get; set; } // LATITUDE

        [Column(@"LONGITUDE", Order = 17, TypeName = SQLSERVER_CONST.DECIMAL_10_6)]
        public decimal? LONGITUDE { get; set; } // LONGITUDE

        [Column(@"CONTACT_NAME", Order = 18, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? CONTACT_NAME { get; set; } // CONTACT_NAME (length: 300)

        [Column(@"PHONE", Order = 19, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? PHONE { get; set; } // PHONE (length: 300)

        [Column(@"DEPARTMENT", Order = 20, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? DEPARTMENT { get; set; } // DEPARTMENT (length: 300)

        [Column(@"COMMENTS", Order = 21, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 22, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 23, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 24, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 25, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 26, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 27, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        public virtual ORG_BRANCH ORG_BRANCH { get; set; } // FK_ORG_BRANCH_ADDRESS_BRANCH_ID
        public virtual SYS_DISTRICT SYS_DISTRICT { get; set; } // FK_ORG_BRANCH_ADDRESS_DISTRICT_ID
        public virtual SYS_SUB_DISTRICT SYS_SUB_DISTRICT { get; set; } // FK_ORG_BRANCH_ADDRESS_SUB_DISTRICT_ID
        public virtual SYS_USER CREATED_BY { get; set; } // FK_ORG_BRANCH_ADDRESS_CREATED_BY_ID
        public virtual SYS_USER LAST_UPDATED_BY { get; set; } // FK_ORG_BRANCH_ADDRESS_LAST_UPDATED_BY_ID

        public ORG_BRANCH_ADDRESS()
        {
        }
    }
}

