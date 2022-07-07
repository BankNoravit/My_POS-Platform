using System;
using NLog;
using System.Reflection;
using RestSharp;
using Newtonsoft.Json;

namespace POS.Common
{
    public partial interface ISendgridEmailCommon
    {
        Task<RESULT_SENDGRID_EMAIL> Send(PARAM_SENDGRID_EMAIL param);
    }

    public partial class SendgridEmailCommon : ISendgridEmailCommon
    {
        #region [Constructor]
        public SendgridEmailCommon() { }
        #endregion [Constructor]

        public async Task<RESULT_SENDGRID_EMAIL> Send(PARAM_SENDGRID_EMAIL param)
        {
            var client = new RestClient(param.EMAIL_API_URL);
            try
            {
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddHeader("Authorization", param.AUTHORIZE_TOKEN);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", JsonConvert.SerializeObject(param.SENDGRID_PARAMS), ParameterType.RequestBody);
                var response = await client.ExecuteAsync(request);
                return new RESULT_SENDGRID_EMAIL()
                {
                    IS_SUCCESS = response.IsSuccessful,
                    STATUS_CODE = (int)response.StatusCode,
                    MESSAGE = response.ErrorMessage
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
