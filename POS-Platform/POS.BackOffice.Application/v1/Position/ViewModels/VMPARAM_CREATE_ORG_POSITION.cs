using POS.ViewModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.ViewModels.v1
{
    public class VMPARAM_CREATE_ORG_POSITION
    {
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public System.Guid POSITION_LEVEL_ID { get; set; } // POSITION_LEVEL_ID

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(50, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? POSITION_CODE { get; set; } // POSITION_CODE (length: 50)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? POSITION_NAME_THA { get; set; } // POSITION_NAME_THA (length: 300)

        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? POSITION_NAME_ENG { get; set; } // POSITION_NAME_ENG (length: 300)

        [StringLength(4000, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE
    }
}

