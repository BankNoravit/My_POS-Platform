using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Extensions.Options;
using POS.Application.v1;
using POS.Domain.Models;
using POS.AppSettings;
using POS.WebAPI;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Extensions;
using POS.ViewModels;
using POS.BackOffice.Application.v1.PositionLevel.ViewModels;
using POS.BackOffice.Application.v1.PositionLevel.Commands;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Deltas;
using POS.BackOffice.Application.v1.PositionLevel.Queries;

namespace POS.Controllers.v1
{
    //[ApiVersion("1.0")]
    public class PositionLevelController : BaseController
    {

        public PositionLevelController(IOptions<APP_SETTINGS> appSettings, IMediator mediator) : base(appSettings, mediator) { }

        [EnableQuery]
        public async Task<IQueryable<ORG_POSITION_LEVEL>> Get()
        {
            return await base._mediator.Send(new QueryPositionLevel(base._GetCurrentUsername()), CancellationToken.None);
        }

        [EnableQuery]
        public async Task<SingleResult<ORG_POSITION_LEVEL>> Get([FromODataUri] Guid key)
        {
            return SingleResult.Create(await base._mediator.Send(new QueryPositionLevelByKey(key, base._GetCurrentUsername()), CancellationToken.None));
        }

        [EnableQuery]
        [ModelStateValidation]
        public async Task<IActionResult> Post([FromBody] VMPARAM_CREATE_ORG_POSITION_LEVEL args)
        {
            var res = await base._mediator.Send(new CommandCreatePositionLevel(args, base._GetCurrentUsername()), CancellationToken.None);
            if (string.IsNullOrEmpty(res.TRACKING_CODE))
                return Created(res.RESULT);

            return new BadRequestResult();
        }

        [EnableQuery]
        [ModelStateValidation]
        public async Task<IActionResult> Patch([FromODataUri] Guid key, [FromBody] Delta<ORG_POSITION_LEVEL> args)
        {
            var res = await base._mediator.Send(new CommandPatchPositionLevel(key, args, base._GetCurrentUsername()), CancellationToken.None);
            if (string.IsNullOrEmpty(res.TRACKING_CODE))
                return Updated(res.RESULT);
            return new BadRequestResult();
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] Guid key)
        {
            var res = await base._mediator.Send(new CommandDeletePositionLevel(key, base._GetCurrentUsername()), CancellationToken.None);
            return Ok(res);
        }
    }
}