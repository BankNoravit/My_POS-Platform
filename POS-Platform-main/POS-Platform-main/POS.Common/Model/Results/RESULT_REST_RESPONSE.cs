using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace POS.Common
{
    public class RESULT_REST_RESPONSE
    {
        public bool IS_SUCCESS { get; set; }
        public HttpStatusCode STATUS_CODE { get; set; }
        public string STATUS_DESC { get; set; }
        public object RESULT { get; set; }

        public RESULT_REST_RESPONSE()
        {
            this.IS_SUCCESS = false;
            this.STATUS_CODE = HttpStatusCode.NotFound;
            this.STATUS_DESC = null;
            this.RESULT = null;
        }
    }

    public class RESULT_REST_RESPONSE<T>
    {
        public bool IS_SUCCESS { get; set; }
        public HttpStatusCode STATUS_CODE { get; set; }
        public string STATUS_DESC { get; set; }
        public T RESULT { get; set; }

        public RESULT_REST_RESPONSE()
        {
            this.IS_SUCCESS = false;
            this.STATUS_CODE = HttpStatusCode.NotFound;
            this.STATUS_DESC = null;
        }
    }
}
