namespace POS.BackOffice.Web.Configuration
{
    public sealed class APP_SETTINGS
    {
        public string ODATA_SERVICES_URL { get; set; }
        public string DATA_ENCRYPTION_KEY { get; set; }

#pragma warning disable CS8618 // Non-nullable property 'ODATA_SERVICES_URL' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'DATA_ENCRYPTION_KEY' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public APP_SETTINGS(){}
#pragma warning restore CS8618 // Non-nullable property 'DATA_ENCRYPTION_KEY' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning restore CS8618 // Non-nullable property 'ODATA_SERVICES_URL' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}