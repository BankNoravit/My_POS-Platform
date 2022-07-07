using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace POS.Common
{
    public class RESULT_REST_MULTI_RESPONSES<T>
    {
        public bool IS_SUCCESS_ALL { get; set; }
        public T RESULT { get; set; }
    }
}
