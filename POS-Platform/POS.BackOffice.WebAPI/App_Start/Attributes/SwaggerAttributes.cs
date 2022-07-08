using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json;

namespace POS.WebAPI
{
    #region [SwaggerOperationAttribute: Swagger Method Description Model]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class SwaggerMethodDescriptionModelAttribute : SwaggerOperationAttribute
    {
        public SwaggerMethodDescriptionModelAttribute(Type type) : base() {
            var instance = Activator.CreateInstance(type);
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(instance, options);
            base.Description = @json;
        }
    }
    #endregion [ProducesResponseTypeAttribute: Swagger Method Description Model]

    #region [SwaggerOperationAttribute: Swagger Method Description]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class SwaggerMethodDescriptionAttribute : SwaggerOperationAttribute
    {
        public SwaggerMethodDescriptionAttribute(string description) : base(description: description) { }
    }
    #endregion [ProducesResponseTypeAttribute: Swagger Method Description]

    #region [ProducesResponseTypeAttribute: Swagger Success]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class SwaggerResponseSuccessAttribute : SwaggerResponseAttribute
    {
        public SwaggerResponseSuccessAttribute(Type type) : base(statusCode: StatusCodes.Status200OK, description: "Success.", type: type) { }
    }
    #endregion [ProducesResponseTypeAttribute: Swagger Success]

    #region [ProducesResponseTypeAttribute: Swagger Unauthorized]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class SwaggerResponseUnauthorizedAttribute : SwaggerResponseAttribute
    {
        public SwaggerResponseUnauthorizedAttribute() : base(statusCode: StatusCodes.Status401Unauthorized, description: "Unauthorized.", type: typeof(UnauthorizeResponseResult)) { }
    }
    #endregion [ProducesResponseTypeAttribute: Swagger CultureNotSupported]

    #region [ProducesResponseTypeAttribute: Swagger Success]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class SwaggerResponseCultureNotSupportedAttribute : SwaggerResponseAttribute
    {
        public SwaggerResponseCultureNotSupportedAttribute() : base(statusCode: StatusCodes.Status406NotAcceptable, description: "Culture is not supported.", type: typeof(NotAcceptableResponseResult)) { }
    }
    #endregion [ProducesResponseTypeAttribute: Swagger CultureNotSupported]

    #region [ProducesResponseTypeAttribute: Swagger InvalidParams]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class SwaggerResponseInvalidParamsAttribute : SwaggerResponseAttribute
    {
        public SwaggerResponseInvalidParamsAttribute() : base(statusCode: StatusCodes.Status422UnprocessableEntity, description: "Invalid parameters.", type: typeof(ModelStateErrorResponseResult)) { }
    }
    #endregion [ProducesResponseTypeAttribute: Swagger InvalidParams]
}
