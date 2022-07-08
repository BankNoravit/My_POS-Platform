using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Department.ViewModels
{
    public class VMPARAM_CREATE_ORG_DEPARTMENT
    {
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public string? DEPARTMENT_CODE { get; set; }                // DEPARTMENT_CODE (length: 50)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? DEPARTMENT_NAME_THA { get; set; }            // DEPARTMENT_NAME_THA (length: 300)

        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? DEPARTMENT_NAME_ENG { get; set; }            // DEPARTMENT_NAME_ENG (length: 300)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public System.Guid? DEPARTMENT_TYPE_ID { get; set; }        //DEPARTMENT_TYPE_ID

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public System.Guid? BRANCH_ID { get; set; }                 //BRANCH_ID             

        [StringLength(4000, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE
    }
}
