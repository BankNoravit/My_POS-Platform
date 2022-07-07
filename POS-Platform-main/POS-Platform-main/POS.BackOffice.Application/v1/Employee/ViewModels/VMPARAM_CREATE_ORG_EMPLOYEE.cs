using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Employee.ViewModels
{
    public class VMPARAM_CREATE_ORG_EMPLOYEE
    {
        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(50, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? EMPLOYEE_CODE { get; set; } // EMPLOYEE_CODE (length: 50)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public System.Guid? TITLE_ID { get; set; } // TITLE_ID

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? FIRST_NAME_THA { get; set; } // FIRST_NAME_THA (length: 300)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? LAST_NAME_THA { get; set; } // LAST_NAME_THA (length: 300)

        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? FIRST_NAME_ENG { get; set; } // FIRST_NAME_ENG (length: 300)

        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? LAST_NAME_ENG { get; set; } // LAST_NAME_ENG (length: 300)

        [StringLength(50, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? NICKNAME { get; set; } // NICKNAME (length: 50)

        [StringLength(20, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? TAX_NO { get; set; } // TAX_NO (length: 20)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public System.Guid? GENDER_ID { get; set; } // GENDER_ID

        public System.DateTime? BIRTH_DATE { get; set; } // BIRTH_DATE

        public System.Guid? NATIONALITY_ID { get; set; } // NATIONALITY_ID

        public System.Guid? RACE_ID { get; set; } // RACE_ID

        public System.Guid? RELIGION_ID { get; set; } // RELIGION_ID

        public System.Guid? BLOOD_TYPE_ID { get; set; } // BLOOD_TYPE_ID

        public System.Guid? MILITARY_STATUS_ID { get; set; } // MILITARY_STATUS_ID

        public System.Guid? MARITAL_STATUS_ID { get; set; } // MARITAL_STATUS_ID

        [StringLength(300, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? PHOTO_URL { get; set; } // PHOTO_URL (length: 300)

        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? PHONE { get; set; } // PHONE (length: 100)

        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? EMAIL { get; set; } // EMAIL (length: 100)

        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? LINE_OFFICIAL_ID { get; set; } // LINE_OFFICIAL_ID (length: 100)

        [StringLength(100, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? FACEBOOK_ID { get; set; } // FACEBOOK_ID (length: 100)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public System.Guid DEPARTMENT_ID { get; set; } // DEPARTMENT_ID

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public System.Guid POSITION_ID { get; set; } // POSITION_ID

        public System.Guid? LEADER_ID { get; set; } // LEADER_ID

        public System.DateTime? START_WORK_DATE { get; set; } // START_WORK_DATE

        public System.Guid? EMPLOYEE_TYPE_ID { get; set; } // EMPLOYEE_TYPE_ID

        public System.Guid? WORK_STATUS_ID { get; set; } // WORK_STATUS_ID

        public string? SIGNATURE_URL { get; set; } // SIGNATURE_URL (length: 300)

        [StringLength(4000, ErrorMessage = VMBASE_CONST.STRINGLENGTH_RANGE_RESX)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE
    }
}
