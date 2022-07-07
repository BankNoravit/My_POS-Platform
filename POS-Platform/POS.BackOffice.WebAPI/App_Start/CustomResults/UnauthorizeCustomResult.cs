using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace POS.WebAPI
{
    public class UnauthorizeResponseResult
    {
        public bool IS_SUCCESS { get; }
        public string MESSAGE { get; }
        public object RESULT { get; }

        public UnauthorizeResponseResult()
        {
            IS_SUCCESS = false;
            MESSAGE = "Unauthorized.";
            RESULT = null;
        }

        public UnauthorizeResponseResult(string msg)
        {
            IS_SUCCESS = false;
            MESSAGE = msg;
            RESULT = null;
        }
    }

    public class UnauthorizeCustomResult : ObjectResult
    {
        public UnauthorizeCustomResult() : base(new UnauthorizeResponseResult())
        {
            StatusCode = StatusCodes.Status401Unauthorized;
        }

        public UnauthorizeCustomResult(string msg) : base(new UnauthorizeResponseResult(msg))
        {
            StatusCode = StatusCodes.Status401Unauthorized;
        }
    }
}
