using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Zone.ViewModels
{
    public class VMPARAM_CREATE_ORG_ZONE
    {
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(50, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? ZONE_CODE { get; set; } // ZONE_CODE (length: 50)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? ZONE_NAME_THA { get; set; } // ZONE_NAME_THA (length: 300)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? ZONE_NAME_ENG { get; set; } // ZONE_NAME_ENG (length: 300)

        [StringLength(4000, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE
    }
}
