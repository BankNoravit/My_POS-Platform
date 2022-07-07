using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Common
{
    public class PARAM_SENDGRID_EMAIL
    {
        public string AUTHORIZE_TOKEN { get; set; }             // AUTHORIZE_TOKEN: Token for access API
        public string EMAIL_API_URL { get; set; }               // EMAIL_API_URL: API Url of Sendgrid Email [Rest API]
        public SG_EMAIL_PARAMS SENDGRID_PARAMS { get; set; }    // SENDGRID_PARAMS: Required & optional parameters of Sendgrid Email from Official document

        public PARAM_SENDGRID_EMAIL()
        {
            this.SENDGRID_PARAMS = new SG_EMAIL_PARAMS();
        }
    }

    #region [Sub Class Params]
    public class SG_EMAIL_PARAMS
    {
        public List<SG_EMAIL_RECEIVER_PARAM> personalizations { get; set; }
        public SG_EMAIL_STRUCTURE from { get; set; }
        public string subject { get; set; }
        public List<SG_EMAIL_CONTENT_PARAM> content { get; set; }

        public SG_EMAIL_PARAMS()
        {
            this.from = new SG_EMAIL_STRUCTURE();
            this.personalizations = new List<SG_EMAIL_RECEIVER_PARAM>();
            this.content = new List<SG_EMAIL_CONTENT_PARAM>();
        }
    }

    public class SG_EMAIL_STRUCTURE
    {
        public string email { get; set; }
        public string name { get; set; }
    }

    public class SG_EMAIL_RECEIVER_PARAM
    {
        public List<SG_EMAIL_STRUCTURE> to { get; set; }
        public List<SG_EMAIL_STRUCTURE> cc { get; set; }
        public List<SG_EMAIL_STRUCTURE> bcc { get; set; }

        public SG_EMAIL_RECEIVER_PARAM()
        {
            this.to = new List<SG_EMAIL_STRUCTURE>();
            this.cc = null;  // optional
            this.bcc = null; // optional
        }
    }

    public class SG_EMAIL_CONTENT_PARAM
    {
        public string type { get; set; }
        public string value { get; set; }

        public SG_EMAIL_CONTENT_PARAM()
        {
            this.type = "text/html";
        }
    }
    #endregion [Sub Class Params]
}
