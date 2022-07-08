using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{
    public class VMBASE_RES<T>
    {
        public VMBASE_RES()
        { }

        public VMBASE_RES(T result)
        {
            this.RESULT = result;
        }

        public string? TRACKING_CODE { get; set; } 
        public string? MESSAGE { get; set; } 
        public T? RESULT { get; set; } = default;
    }
}
