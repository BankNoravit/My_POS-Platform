using System.Globalization;

namespace POS.AppSettings
{
    public sealed class APP_SETTINGS
    {
        public string DEFAULT_CULTURE_NAME = "en-US";
        public string FORCE_CULTURE_DATETIME_FORMAT_NAME = "en-US";

        public CultureInfo DEFAULT_REQUEST_CULTURE { get; set; }
        public List<CultureInfo> SUPPORT_CULTURES { get; set; }

        public bool IS_SEPARATE_READ_WRITE_DB { get; set; }
        public bool IS_AUTO_MIGRATION_DB_ON_START_UP { get; set; }
        public string ACCESS_TOKEN_COOKIE_NAME { get; set; }
        public string DATA_ID_ENCRYPTION_KEY { get; set; }
        public string PASSWORD_ENCRYPTION_KEY { get; set; }
        public List<string> ALLOWED_ORIGINS { get; set; }
        public APP_SETTINGS_API_DOCUMENT API_DOCUMENT { get; set; }                  // Swagger
        public APP_SETTINGS_JWT_CONFIGURATION JWT_CONFIGURATION { get; set; }        // Jwt config for generate token

        public APP_SETTINGS()
        {
            this.DEFAULT_REQUEST_CULTURE = new CultureInfo("en-US");
            this.SUPPORT_CULTURES = new List<CultureInfo>()
            {
                new CultureInfo("en-US"),
                new CultureInfo("th-TH")
            };

            this.ACCESS_TOKEN_COOKIE_NAME = String.Empty;
            this.DATA_ID_ENCRYPTION_KEY = String.Empty;
            this.PASSWORD_ENCRYPTION_KEY = String.Empty;
            this.ALLOWED_ORIGINS = new List<string>();
            this.API_DOCUMENT = new APP_SETTINGS_API_DOCUMENT();
            this.JWT_CONFIGURATION = new APP_SETTINGS_JWT_CONFIGURATION();
        }
    }
}