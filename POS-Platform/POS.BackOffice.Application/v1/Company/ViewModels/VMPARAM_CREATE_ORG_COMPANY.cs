using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Company.ViewModels
{
    public class VMPARAM_CREATE_ORG_COMPANY
    {
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(50, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? COMPANY_CODE { get; set; } // COMPANY_CODE (length: 50)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? COMPANY_NAME_THA { get; set; } // COMPANY_NAME_THA (length: 300)
        
        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? COMPANY_NAME_ENG { get; set; } // COMPANY_NAME_ENG (length: 300)

        [StringLength(13, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? TAX_NO { get; set; } // TAX_NO (length: 13)

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

        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? LOGO_URL { get; set; } // LOGO_URL (length: 300)

        [StringLength(4000, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE
    }
}
