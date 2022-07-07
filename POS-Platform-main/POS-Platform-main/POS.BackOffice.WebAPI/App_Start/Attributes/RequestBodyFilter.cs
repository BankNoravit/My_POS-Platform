using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.Annotations;
using System.Text;
using System.Text.Json;

namespace POS.WebAPI
{
    public class RequestBodyFilter : IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var request = context.HttpContext.Request;
            using (var reader = new StreamReader(request.Body))
            {
                string body = reader.ReadToEndAsync().GetAwaiter().GetResult();
                var odataJson = JsonConvert.DeserializeObject<JObject>(body);
                odataJson.Property("@odata.type")?.Remove();
                byte[] bytes = Encoding.ASCII.GetBytes(odataJson.ToString(Formatting.None));
                request.Body = new MemoryStream(bytes); // here i am trying to change request body
            }
        }
    }
}
