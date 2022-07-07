using Microsoft.Extensions.Options;
using Microsoft.OData.Client;
using POS.BackOffice.Web.Configuration;
using POS.Common;

namespace POS.BackOffice.Web.Services
{
    public enum PAGE_MODE
    {
        CREATE = 1,
        UPDATE = 2
    }

    public enum QUERY_OPERATORS
    {
        STARTSWITH,
        ENDSWITH,
        CONTAINS,
        EQUAL,
        NOTEQUAL,
        GREATERTHAN,
        GREATERTHANOREQUAL,
        LESSTHAN,
        LESSTHANOREQUAL,
        BETWEEN,
        NOTBETWEEN,
        IN,
        NOTIN,
        ISEMPTY,
        ISNOTEMPTY,
        ISNULL,
        ISNOTNULL
    }

    public interface IBaseService
    {
        string GetOdataRequestUrl(ODATA_ROUTE_NAME pRouteName);
        ODataContext GetODataContext();
        T GetEntityResponse<T>(DataServiceResponse responses);
        string GetODataQueryEndpoint<T>(IQueryable query);
        string EncryptRouteData(object data);
        T DecryptRouteData<T>(string data);

        string ModeCreate();
        string ModeUpdate();
    }

    public class BaseService : IBaseService
    {
        protected readonly APP_SETTINGS _appSettings;
        protected readonly IUtilityCommon _util;
        protected readonly ISecurityCommon _secure;

        public BaseService(IOptions<APP_SETTINGS> appSettings, IUtilityCommon util, ISecurityCommon secure)
        {
            this._appSettings = appSettings.Value;
            this._util = util;
            this._secure = secure;
        }

        public string GetOdataRequestUrl(ODATA_ROUTE_NAME pRouteName)
        {
            return this._util.CombineUrl(baseUrl: this._appSettings.ODATA_SERVICES_URL, relativePaths: pRouteName.ToString());
        }

        public ODataContext GetODataContext()
        {
            var rootUrl = this._appSettings.ODATA_SERVICES_URL;
            var _context = new ODataContext(new Uri(rootUrl));
            return _context;
        }

        public T GetEntityResponse<T>(DataServiceResponse responses)
        {
            T result = default(T);
            foreach (OperationResponse response in responses)
            {
                var changeResponse = (ChangeOperationResponse)response;
                var entityDescriptor = (EntityDescriptor)changeResponse.Descriptor;
                result = (T)entityDescriptor.Entity; // the person created on the service
            }
            return result;
        }

        public string GetODataQueryEndpoint<T>(IQueryable query)
        {   // for custom url without edm endpoint
            string result = string.Empty;
            var _query = (query as DataServiceQuery<T>.DataServiceOrderedQuery);
            if (_query != null)
                result = _query.RequestUri.ToString();

            return result;
        }

        public string EncryptRouteData(object data)
        {
            return this._secure.EncryptDataUrlEncoder(data, this._appSettings.DATA_ENCRYPTION_KEY);
        }

        public T DecryptRouteData<T>(string data)
        {
            return this._secure.DecryptDataUrlEncoder<T>(data, this._appSettings.DATA_ENCRYPTION_KEY);
        }

        public string ModeCreate()
        {
            return this.EncryptRouteData(((int)PAGE_MODE.CREATE));
        }

        public string ModeUpdate()
        {
            return this.EncryptRouteData(((int)PAGE_MODE.UPDATE));
        }
    }
}