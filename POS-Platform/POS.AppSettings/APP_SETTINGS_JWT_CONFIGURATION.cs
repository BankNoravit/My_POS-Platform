namespace POS.AppSettings
{
    public sealed class APP_SETTINGS_JWT_CONFIGURATION
    {
        public string ISSUER { get; set; }
        public string AUDIENCE { get; set; }
        public List<string> ISSUERS { get; set; }
        public List<string> AUDIENCES { get; set; }
        public string SECRET_KEY { get; set; }
        public double ACCESS_EXPIRE_HOURS { get; set; }
        public double REFRESH_EXPIRE_HOURS { get; set; }
        public APP_SETTINGS_JWT_CONFIGURATION()
        {
            this.ISSUER = String.Empty;
            this.AUDIENCE = String.Empty;
            this.SECRET_KEY = String.Empty;
            this.ISSUERS = new List<string>();
            this.AUDIENCES = new List<string>();
        }
    }
}