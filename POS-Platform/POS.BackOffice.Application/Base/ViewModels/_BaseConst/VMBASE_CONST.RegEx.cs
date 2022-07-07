using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{
    public partial class VMBASE_CONST
    {
        // .RegEx
        // Suffix: REGEX is Regular expression const
        public const string WHITESPACE_REGEX = @"^\S*$";
        public const string CREDITCARD_REGEX = @"^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$";
        public const string CURRENCY_REGEX = @"^\d+\.?\d{0,2}$";
        public const string NUMBER_REGEX = @"^\d*$";
        public const string PHONE_REGEX = @"^\d*$";
        public const string FAX_REGEX = @"^\d*$";
        public const string BANKACCOUNT_REGEX = @"^\d*$";
        public const string URL_REGEX = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
        public const string PASSWORD_POLICY_REGEX = @"^\S*$";
        public const string EMAIL_REGEX = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
        public const string USERNAME_REGEX = @"^[A-Za-z\d_-]+$";
    }
}
