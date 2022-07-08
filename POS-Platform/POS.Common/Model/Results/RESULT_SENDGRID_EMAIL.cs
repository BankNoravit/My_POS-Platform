using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Common
{
    public class RESULT_SENDGRID_EMAIL
    {
        public bool IS_SUCCESS { get; set; }
        public int STATUS_CODE { get; set; }
        public string MESSAGE { get; set; }
    }
}
