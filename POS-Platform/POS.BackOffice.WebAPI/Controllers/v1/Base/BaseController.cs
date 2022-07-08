using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.Extensions.Options;
using POS.AppSettings;
using System.Globalization;
using System.Text.Json;

namespace POS.Controllers.v1
{
    public class BaseController : ODataController
    {
        protected readonly APP_SETTINGS _appSettings;
        protected readonly IMediator _mediator;

        public BaseController(IOptions<APP_SETTINGS> appSettings, IMediator mediator)
        {
            this._appSettings = appSettings.Value;
            this._mediator = mediator;
            this._setCultureDateFormat();
        }

        #region [Private]
        private void _setCultureDateFormat()
        {
            string cultureInfoName = this._appSettings.FORCE_CULTURE_DATETIME_FORMAT_NAME;
            if (!string.IsNullOrEmpty(cultureInfoName))
            {
                if (Thread.CurrentThread.CurrentCulture.IsReadOnly)
                {
                    var clone = Thread.CurrentThread.CurrentCulture.Clone() as CultureInfo;
                    clone.DateTimeFormat = CultureInfo.GetCultureInfo(cultureInfoName).DateTimeFormat;
                    Thread.CurrentThread.CurrentCulture = clone;
                    Thread.CurrentThread.CurrentUICulture = clone;
                }
                else
                {
                    Thread.CurrentThread.CurrentCulture.DateTimeFormat = new CultureInfo(cultureInfoName).DateTimeFormat;
                    Thread.CurrentThread.CurrentUICulture.DateTimeFormat = new CultureInfo(cultureInfoName).DateTimeFormat;
                }
            }
        }
        #endregion [Private]

        #region [Protected]
        protected string _GetCurrentUsername()
        {
            return HttpContext.User.Identity.Name;
        }

        protected bool _TryValidateModelState<T>(object args, out T result)
        {
            try {
                var json = JsonSerializer.Serialize(args);
                result = JsonSerializer.Deserialize<T>(json);
                return TryValidateModel(result);
            }
            catch(Exception ex)
            {
                result = default(T);
                return false;
            }
        }
        #endregion [Protected]
    }
}