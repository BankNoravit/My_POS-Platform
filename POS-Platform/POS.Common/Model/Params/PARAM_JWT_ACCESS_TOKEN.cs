using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Common
{
    public class PARAM_JWT_ACCESS_TOKEN
    {
        public string USERNAME { get; set; }                            // Required
        public string SECRET_KEY { get; set; }                          // Required
        public string ISSUER { get; set; }                              // Required
        public string AUDIENCE { get; set; }                            // Required
        public List<KeyValuePair<string, string>> BODY { get; set; }    // Optional
        public DateTime START_DATE { get; set; }                        // Required
        public DateTime EXPIRE_DATE { get; set; }                       // Required

        public PARAM_JWT_ACCESS_TOKEN()
        {
            this.BODY = new List<KeyValuePair<string, string>>();
        }
    }
}
