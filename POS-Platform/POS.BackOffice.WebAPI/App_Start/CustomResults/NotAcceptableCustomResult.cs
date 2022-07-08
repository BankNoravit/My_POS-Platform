using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace POS.WebAPI
{
    public class NotAcceptableResponseResult
    {
        public bool IS_SUCCESS { get; }
        public string MESSAGE { get; }
        public object RESULT { get; }

        public NotAcceptableResponseResult(string msg)
        {
            IS_SUCCESS = false;
            MESSAGE = (string.IsNullOrEmpty(msg) ? "Not Acceptable." : msg);
            RESULT = null;
        }
    }

    public class NotAcceptableCustomResult : ObjectResult
    {
        public NotAcceptableCustomResult(string msg) : base(new NotAcceptableResponseResult(msg))
        {
            StatusCode = StatusCodes.Status406NotAcceptable;
        }
    }
}
