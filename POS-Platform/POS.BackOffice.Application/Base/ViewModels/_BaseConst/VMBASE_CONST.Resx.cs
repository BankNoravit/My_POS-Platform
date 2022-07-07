using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{
    public partial class VMBASE_CONST
    {
        // .Resx
        // Suffix: RESX is "Name" field of Resource file (.resx)
        // Use const_resx on Data Annotation attribute at "ErrorMessage" parameter
        // Use Data Annotation attribute "Display" and Set parameter "Name" for change field name in error message
        // Sample Coding:
        // ----------------------------------------------------------------
        //      [Display(Name = "{CUSTOMER_NAME}")]
        //      [Required(ErrorMessage = VMBASE_CONST.REQUIRED_RESX)]
        //      public string CUSTOMER_NAME { get; set; }
        // ----------------------------------------------------------------

        //public const string BANKACCOUNT_RESX = "BANKACCOUNT_RESX";
        //public const string CHEQUE_RESX = "CHEQUE_RESX";
        //public const string CREDITCARD_RESX = "CREDITCARD_RESX";
        //public const string CURRENCY_RESX = "CURRENCY_RESX";
        //public const string EMAILADDRESS_RESX = "EMAILADDRESS_RESX";
        //public const string STRINGLENGTH_RESX = "STRINGLENGTH_RESX";
        //public const string NUMBER_RESX = "NUMBER_RESX";
        //public const string PHONE_RESX = "PHONE_RESX";
        //public const string FAX_RESX = "FAX_RESX";
        //public const string RANGE_RESX = "RANGE_RESX";
        //public const string REQUIRED_RESX = "REQUIRED_RESX";
        //public const string URL_RESX = "URL_RESX";
        //public const string WHITESPACE_RESX = "WHITESPACE_RESX";
        //public const string PASSWORD_POLICY_RESX = "PASSWORD_POLICY_RESX";
        //public const string STRINGLENGTH_RANGE_RESX = "STRINGLENGTH_RANGE_RESX";

        public const string BANKACCOUNT_RESX = "Invalid backaccount format.";
        public const string CHEQUE_RESX = "Invalid cheque format.";
        public const string CREDITCARD_RESX = "Invalid creditcard format.";
        public const string CURRENCY_RESX = "Invalid currency format.";
        public const string EMAILADDRESS_RESX = "Invalid email format.";
        public const string STRINGLENGTH_RESX = "Invalid character length.";
        public const string NUMBER_RESX = "Invalid number.";
        public const string PHONE_RESX = "Invalid phone format.";
        public const string FAX_RESX = "Invalid fax format.";
        public const string RANGE_RESX = "Invalid range.";
        public const string REQUIRED_RESX = "Required.";
        public const string URL_RESX = "Invalid url format.";
        public const string WHITESPACE_RESX = "Whitespace(s) not allowed.";
        public const string PASSWORD_POLICY_RESX = "Invalid password policy.";
        public const string STRINGLENGTH_RANGE_RESX = "Invalid character range.";
        public const string USERNAME_RESX = "Username must only include numbers, letters and symbol (dash, underscore).";

        public const string RANGE_10M_RESX = "Invalid range. (0 - 99,999,999.00)";
    }
}
