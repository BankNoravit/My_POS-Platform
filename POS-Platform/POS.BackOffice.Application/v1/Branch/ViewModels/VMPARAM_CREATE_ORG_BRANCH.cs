using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Branch.ViewModels
{
    public class VMPARAM_CREATE_ORG_BRANCH
    {
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(50, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? BRANCH_CODE { get; set; } // BRANCH_CODE (length: 50)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? BRANCH_NAME_THA { get; set; } // BRANCH_NAME_THA (length: 300)

        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? BRANCH_NAME_ENG { get; set; } // BRANCH_NAME_ENG (length: 300)

        public System.Guid? BUSINESS_UNIT_ID { get; set; } // BUSINESS_UNIT_ID

        public System.Guid? MANAGER_ID { get; set; } // MANAGER_ID

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public bool IS_HEADQUARTER { get; set; } // IS_HEADQUARTER
        public bool? IS_SHOP { get; set; } // IS_SHOP
        public bool? IS_WAREHOUSE { get; set; } // IS_WAREHOUSE
        public bool? IS_FRANCHISEE { get; set; } // IS_FRANCHISEE
        public System.Guid? FRANCHISEE_ID { get; set; } // FRANCHISEE_ID

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(5, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? BRANCH { get; set; } // BRANCH (length: 5)

        public System.Guid? BRANCH_STATUS_ID { get; set; } // BRANCH_STATUS_ID

        public System.DateTime? BRANCH_OPEN_DATE { get; set; } // BRANCH_OPEN_DATE

        public System.DateTime? BRANCH_CLOSE_DATE { get; set; } // BRANCH_CLOSE_DATE

        public System.Guid? BRANCH_OFFICE_HOUR { get; set; } // BRANCH_OFFICE_HOUR

        public System.Guid? LOCATION_ID { get; set; } // LOCATION_ID

        public System.Guid? ZONE_ID { get; set; } // ZONE_ID

        public decimal? AREA_SIZE { get; set; } // AREA_SIZE

        public decimal? RENT_PER_SQM { get; set; } // RENT_PER_SQM

        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? PHONE { get; set; } // PHONE (length: 100)

        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? FAX { get; set; } // FAX (length: 100)

        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? EMAIL { get; set; } // EMAIL (length: 100)

        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? LINE_OFFICIAL_ID { get; set; } // LINE_OFFICIAL_ID (length: 100)

        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? FACEBOOK_ID { get; set; } // FACEBOOK_ID (length: 100)

        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? WEBSITE { get; set; } // WEBSITE (length: 300)

        [StringLength(4000, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE
    }
}
