using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{
    public class VMBASE_RES_LIST<T>
    {
        public VMBASE_RES_LIST()
        { }

        public VMBASE_RES_LIST(IEnumerable<T> result)
        {
            this.RESULT = result;
        }

        public string? TRACKING_CODE { get; set; } 
        public string? MESSAGE { get; set; } 
        public long? TOTAL_RECORD { get; set; } = 0;
        public IEnumerable<T> RESULT { get; set; } = new List<T>();
    }
}
