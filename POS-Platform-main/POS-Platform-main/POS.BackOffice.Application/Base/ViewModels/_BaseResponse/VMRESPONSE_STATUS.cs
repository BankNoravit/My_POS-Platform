using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{
    public class VMRESPONSE_STATUS
    {
        public VMRESPONSE_STATUS()
        {   // Default
            this.IS_SUCCESS = false;
            this.MESSAGE = string.Empty;
            this.RESULT = null;
        }

        public bool IS_SUCCESS { get; set; }
        public string MESSAGE { get; set; }
        public object RESULT { get; set; }
    }
}
