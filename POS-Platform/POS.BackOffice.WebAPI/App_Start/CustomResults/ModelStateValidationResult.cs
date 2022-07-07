using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace POS.WebAPI
{
    public class ModelStateErrorTemplate
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FIELD { get; }

        public string MESSAGE { get; }

        public ModelStateErrorTemplate(string field, string message)
        {
            FIELD = field != string.Empty ? field : null;
            MESSAGE = message;
        }
    }

    public class ModelStateErrorList
    {
        public List<ModelStateErrorTemplate> ERRORS { get; }
        public ModelStateErrorList(ModelStateDictionary modelState)
        {
            ERRORS = modelState.Keys
                    .SelectMany(key => modelState[key].Errors.Select(x => new ModelStateErrorTemplate(key, x.ErrorMessage)))
                    .ToList();
        }
    }

    public class ModelStateErrorResponseResult
    {
        public bool IS_SUCCESS { get; }
        public string MESSAGE { get; }
        public ModelStateErrorList RESULT { get; }

        public ModelStateErrorResponseResult(ModelStateDictionary modelState)
        {
            IS_SUCCESS = false;
            MESSAGE = "Invalid Parameters.";
            RESULT = new ModelStateErrorList(modelState);
        }
    }

    public class ValidationFailedResult : ObjectResult
    {
        public ValidationFailedResult(ModelStateDictionary modelState) : base(new ModelStateErrorResponseResult(modelState))
        {
            StatusCode = StatusCodes.Status400BadRequest;
        }
    }
}
