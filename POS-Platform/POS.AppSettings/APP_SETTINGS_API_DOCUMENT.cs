namespace POS.AppSettings
{
    public sealed class APP_SETTINGS_API_DOCUMENT
    {
        public string API_NAME { get; set; }
        public string API_CURRENT_VERSION { get; set; }

        public APP_SETTINGS_API_DOCUMENT()
        {
            this.API_NAME = String.Empty;
            this.API_CURRENT_VERSION = String.Empty;
        }
    }
}