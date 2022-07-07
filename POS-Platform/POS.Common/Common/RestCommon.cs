using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace POS.Common
{
    // T:  ใช้ DeserializeObject Result จาก Api 
    // T2: ใช้ DeserializeObject Error  จาก Api (เฉพาะกรณี Api แยก Response Success และ Unsuccess เป็น 2 แบบ)
    // Parameters in [PARAM_REST_REQUEST]:
    //      "string URL":   รับ "Domain Url" ที่ใช้สำหรับ Connect ไปยัง Api 
    //      "string ROUTE": รับ "Route" ที่ใช้เรียก Method ภายใน "Domain Url" 
    //      "List<KeyValuePair<string, string>> HEADER": HTTP Request Header สำหรับ Request ไปยัง Api รับข้อมูลเป็น Key และ Value 
    //      "object JSON_BODY": Parameters(HTTP Request Body) ที่ใช้ส่งไปยัง Api รองรับรับค่าทั้งแบบ Model หรือ Anonymous(Key,value)

    public partial interface IRestCommon
    {
        string UrlCombind(string url, params string[] paths);

        // GET
        Task<RESULT_REST_RESPONSE> Get<T>(PARAM_REST_REQUEST param);
        Task<RESULT_REST_RESPONSE> Get<T, T2>(PARAM_REST_REQUEST param);

        // POST
        Task<RESULT_REST_RESPONSE> Post<T>(PARAM_REST_REQUEST param);
        Task<RESULT_REST_RESPONSE> Post<T, T2>(PARAM_REST_REQUEST param);

        // PUT
        Task<RESULT_REST_RESPONSE> Put<T>(PARAM_REST_REQUEST param);
        Task<RESULT_REST_RESPONSE> Put<T, T2>(PARAM_REST_REQUEST param);

        // DELETE
        Task<RESULT_REST_RESPONSE> Delete<T>(PARAM_REST_REQUEST param);
        Task<RESULT_REST_RESPONSE> Delete<T, T2>(PARAM_REST_REQUEST param);

        Task<T> HttpClientGet<T>(string url);
        Task<IEnumerable<T>> HttpClientGetMany<T>(string url);
    }

    public partial class RestCommon : IRestCommon
    {
        private const string default_ContentTypeKey = "Content-Type";
        private const string default_ContentTypeValue = "application/json";
        private const string default_AcceptKey = "Accept";
        private const string default_AcceptValue = "*/*";

        public RestCommon() { }

        #region [Utility Methods]
        public string UrlCombind(string url, params string[] paths)
        {
            return paths.Aggregate(url, (current, path) => string.Format("{0}/{1}", current.TrimEnd('/'), path.TrimStart('/')));
        }
        #endregion [Utility Methods]

        #region [GET Methods]
        public async Task<RESULT_REST_RESPONSE> Get<T>(PARAM_REST_REQUEST param)
        {
            try
            {
                var httpMethod = Method.Get;
                var client = this.InitRestClient(url: param.URL);
                var request = this.InitRouteHttpMethod(route: param.ROUTE, method: httpMethod);

                this.SetRouteBody(ref request, jsonBody: param.JSON_BODY, method: httpMethod);
                this.SetRouteHeader(ref request, header: param.HEADER);

                var response = await client.ExecuteAsync(request);
                return this.GetRestResponse<T>(iRes: response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<RESULT_REST_RESPONSE> Get<T, T2>(PARAM_REST_REQUEST param)
        {
            try
            {
                var httpMethod = Method.Get;
                var client = this.InitRestClient(url: param.URL);
                var request = this.InitRouteHttpMethod(route: param.ROUTE, method: httpMethod);

                this.SetRouteBody(ref request, jsonBody: param.JSON_BODY, method: httpMethod);
                this.SetRouteHeader(ref request, header: param.HEADER);

                var response = await client.ExecuteAsync(request);
                return this.GetRestResponse<T, T2>(iRes: response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion [GET Methods]

        #region [POST Methods]
        public async Task<RESULT_REST_RESPONSE> Post<T>(PARAM_REST_REQUEST param)
        {
            try
            {
                var httpMethod = Method.Post;
                var client = this.InitRestClient(url: param.URL);
                var request = this.InitRouteHttpMethod(route: param.ROUTE, method: httpMethod);

                this.SetRouteBody(ref request, jsonBody: param.JSON_BODY, method: httpMethod);
                this.SetRouteHeader(ref request, header: param.HEADER);

                var response = await client.ExecuteAsync(request);
                return this.GetRestResponse<T>(iRes: response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<RESULT_REST_RESPONSE> Post<T, T2>(PARAM_REST_REQUEST param)
        {
            try
            {
                var httpMethod = Method.Post;
                var client = this.InitRestClient(url: param.URL);
                var request = this.InitRouteHttpMethod(route: param.ROUTE, method: httpMethod);

                this.SetRouteBody(ref request, jsonBody: param.JSON_BODY, method: httpMethod);
                this.SetRouteHeader(ref request, header: param.HEADER);

                var response = await client.ExecuteAsync(request);
                return this.GetRestResponse<T, T2>(iRes: response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [POST Methods]

        #region [PUT Methods]
        public async Task<RESULT_REST_RESPONSE> Put<T>(PARAM_REST_REQUEST param)
        {
            try
            {
                var httpMethod = Method.Put;
                var client = this.InitRestClient(url: param.URL);
                var request = this.InitRouteHttpMethod(route: param.ROUTE, method: httpMethod);

                this.SetRouteBody(ref request, jsonBody: param.JSON_BODY, method: httpMethod);
                this.SetRouteHeader(ref request, header: param.HEADER);

                var response = await client.ExecuteAsync(request);
                return this.GetRestResponse<T>(iRes: response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<RESULT_REST_RESPONSE> Put<T, T2>(PARAM_REST_REQUEST param)
        {
            try
            {
                var httpMethod = Method.Put;
                var client = this.InitRestClient(url: param.URL);
                var request = this.InitRouteHttpMethod(route: param.ROUTE, method: httpMethod);

                this.SetRouteBody(ref request, jsonBody: param.JSON_BODY, method: httpMethod);
                this.SetRouteHeader(ref request, header: param.HEADER);

                var response = await client.ExecuteAsync(request);
                return this.GetRestResponse<T, T2>(iRes: response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [PUT Methods]

        #region [DELETE Methods]
        public async Task<RESULT_REST_RESPONSE> Delete<T>(PARAM_REST_REQUEST param)
        {
            try
            {
                var httpMethod = Method.Delete;
                var client = this.InitRestClient(url: param.URL);
                var request = this.InitRouteHttpMethod(route: param.ROUTE, method: httpMethod);

                this.SetRouteBody(ref request, jsonBody: param.JSON_BODY, method: httpMethod);
                this.SetRouteHeader(ref request, header: param.HEADER);

                var response = await client.ExecuteAsync(request);
                return this.GetRestResponse<T>(iRes: response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<RESULT_REST_RESPONSE> Delete<T, T2>(PARAM_REST_REQUEST param)
        {
            try
            {
                var httpMethod = Method.Delete;
                var client = this.InitRestClient(url: param.URL);
                var request = this.InitRouteHttpMethod(route: param.ROUTE, method: httpMethod);

                this.SetRouteBody(ref request, jsonBody: param.JSON_BODY, method: httpMethod);
                this.SetRouteHeader(ref request, header: param.HEADER);

                var response = await client.ExecuteAsync(request);
                return this.GetRestResponse<T, T2>(iRes: response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [DELETE Methods]

        #region [Private Methods]

        private RestClient InitRestClient(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                    throw new Exception("Service url not found.");

                return new RestClient(url);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private RestRequest InitRouteHttpMethod(string route, Method method)
        {
            try
            {
                if (string.IsNullOrEmpty(route))
                    throw new Exception("Route not found.");

                var request = new RestRequest(resource: route, method: method);
                request.RequestFormat = DataFormat.Json;
                return request;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SetRouteHeader(ref RestRequest request, List<KeyValuePair<string, string>> header)
        {
            if (header == null)
                header = new List<KeyValuePair<string, string>>();

            if (header.Where(a => a.Key.Trim().ToLower() == default_ContentTypeKey.Trim().ToLower()).Count() == 0)
                header.Add(new KeyValuePair<string, string>(default_ContentTypeKey, default_ContentTypeValue));

            if (header.Where(a => a.Key.Trim().ToLower() == default_AcceptKey.Trim().ToLower()).Count() == 0)
                header.Add(new KeyValuePair<string, string>(default_AcceptKey, default_AcceptValue));

            foreach (var keyVal in header)
            {
                request.AddHeader(keyVal.Key, keyVal.Value);
            }
        }

        private void SetRouteBody(ref RestRequest request, object jsonBody, Method method)
        {
            try
            {
                if (jsonBody != null)
                {
                    request.AddJsonBody(jsonBody);
                }
                else
                {
                    switch (method)
                    {
                        case Method.Post:
                        case Method.Put:
                        case Method.Delete:
                            throw new Exception(method.ToString() + " required at least one parameter(request body).");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private RESULT_REST_RESPONSE GetRestResponse<T>(RestResponse? iRes)
        {
            RESULT_REST_RESPONSE res = new RESULT_REST_RESPONSE();
            try
            {
                if (iRes != null)
                {
                    res.IS_SUCCESS = iRes.IsSuccessful;
                    res.STATUS_CODE = iRes.StatusCode;
                    res.STATUS_DESC = iRes.StatusDescription;
                    res.RESULT = JsonConvert.DeserializeObject<T>(iRes.Content);
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private RESULT_REST_RESPONSE GetRestResponse<T, T2>(RestResponse iRes)
        {
            RESULT_REST_RESPONSE res = new RESULT_REST_RESPONSE();
            try
            {
                if (iRes != null)
                {
                    res.IS_SUCCESS = iRes.IsSuccessful;
                    res.STATUS_CODE = iRes.StatusCode;
                    res.STATUS_DESC = iRes.StatusDescription;
                    if (res.IS_SUCCESS)
                    {
                        res.RESULT = JsonConvert.DeserializeObject<T>(iRes.Content);
                    }
                    else
                    {
                        res.RESULT = JsonConvert.DeserializeObject<T2>(iRes.Content);
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion  [Private Methods]

        #region [GET Methods]
        public async Task<T> HttpClientGet<T>(string url)
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(url);
                return await response.Content.ReadFromJsonAsync<T>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> HttpClientGetMany<T>(string url)
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(url);
                return await response.Content.ReadFromJsonAsync<IEnumerable<T>>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [GET Methods]
    }
}
