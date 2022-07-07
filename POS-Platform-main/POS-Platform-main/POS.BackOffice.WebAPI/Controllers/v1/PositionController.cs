using MediatR;
using POS.Application.v1;
using POS.AppSettings;
using POS.Domain.Models;
using POS.WebAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.Extensions.Options;
using POS.ViewModels.v1;

namespace POS.Controllers.v1
{
    //[ApiVersion("1.0")]
    public class PositionController : BaseController
    {
        public PositionController(IOptions<APP_SETTINGS> appSettings, IMediator mediator) : base(appSettings, mediator) { }
        
        [EnableQuery]
        public async Task<IQueryable<ORG_POSITION>> Get()
        {
            return await base._mediator.Send(new QueryPosition(base._GetCurrentUsername()), CancellationToken.None);
        }

        [EnableQuery]
        public async Task<SingleResult<ORG_POSITION>> Get([FromODataUri] Guid key)
        {
            return SingleResult.Create(await base._mediator.Send(new QueryPositionByKey(key, base._GetCurrentUsername()), CancellationToken.None));
        }

        [EnableQuery]
        [ModelStateValidation]
        public async Task<IActionResult> Post([FromBody] VMPARAM_CREATE_ORG_POSITION args)
        {
            var res = await base._mediator.Send(new CommandCreatePosition(args, base._GetCurrentUsername()), CancellationToken.None);
            if (string.IsNullOrEmpty(res.TRACKING_CODE))
                return Created(res.RESULT);

            return new BadRequestResult();
        }

        [EnableQuery]
        [ModelStateValidation]
        public async Task<IActionResult> Patch([FromODataUri] Guid key, [FromBody] Delta<ORG_POSITION> args)
        {
            var res = await base._mediator.Send(new CommandPatchPosition(key, args, base._GetCurrentUsername()), CancellationToken.None);
            if(string.IsNullOrEmpty(res.TRACKING_CODE))
                return Updated(res.RESULT);

            return new BadRequestResult();
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] Guid key)
        {
            var res = await base._mediator.Send(new CommandDeletePosition(key, base._GetCurrentUsername()), CancellationToken.None);
            return Ok(res);
        }
    }
}