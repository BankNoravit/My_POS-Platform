using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace POS.Common
{
    public class PARAM_REST_REQUEST
    {
        public string URL { get; set; }
        public string ROUTE { get; set; }
        public List<KeyValuePair<string, string>> HEADER { get; set; }
        public object JSON_BODY { get; set; }

        public PARAM_REST_REQUEST()
        {
            this.HEADER = new List<KeyValuePair<string, string>>();
        }
    }
}
