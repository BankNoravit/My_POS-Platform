using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POS.ViewModels
{
    public class VMBASE_SEARCH_CONDITIONS
    {
        [Display(Name = "{PAGE_NUMBER}")]
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public int PAGE_NUMBER { get; set; }

        [Display(Name = "{PAGE_SIZE}")]
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public int PAGE_SIZE { get; set; }

        [Display(Name = "{SEARCH_FIELD}")]
        [StringLength(50, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RESX)]
        public string SEARCH_FIELD { get; set; }

        [Display(Name = "{ORDER_COLUMN_NAME}")]
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RESX)]
        public string ORDER_COLUMN_NAME { get; set; }

        [Display(Name = "{ORDER_DESCENDING}")]
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public string ORDER_DIRECTION { get; set; }
    }
}
