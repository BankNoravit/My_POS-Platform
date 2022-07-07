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
using POS.BackOffice.Application.v1.Department.ViewModels;
using POS.BackOffice.Application.v1.Department.Commands;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Deltas;
using POS.BackOffice.Application.v1.Department.Queries;

namespace POS.Controllers.v1
{
    //[ApiVersion("1.0")]
    public class DepartmentController : BaseController
    {

        public DepartmentController(IOptions<APP_SETTINGS> appSettings, IMediator mediator) : base(appSettings, mediator) { }

        [EnableQuery]
        public async Task<IQueryable<ORG_DEPARTMENT>> Get()
        {
            return await base._mediator.Send(new QueryDepartment(base._GetCurrentUsername()), CancellationToken.None);
        }

        [EnableQuery]
        public async Task<SingleResult<ORG_DEPARTMENT>> Get([FromODataUri] Guid key)
        {
            return SingleResult.Create(await base._mediator.Send(new QueryDepartmentByKey(key, base._GetCurrentUsername()), CancellationToken.None));
        }

        [EnableQuery]
        [ModelStateValidation]
        public async Task<IActionResult> Post([FromBody] VMPARAM_CREATE_ORG_DEPARTMENT args)
        {
            var res = await base._mediator.Send(new CommandCreateDepartment(args, base._GetCurrentUsername()), CancellationToken.None);
            if (string.IsNullOrEmpty(res.TRACKING_CODE))
                return Created(res.RESULT);

            return new BadRequestResult();
        }

        [EnableQuery]
        [ModelStateValidation]
        public async Task<IActionResult> Patch([FromODataUri] Guid key, [FromBody] Delta<ORG_DEPARTMENT> args)
        {
            var res = await base._mediator.Send(new CommandPatchDepartment(key, args, base._GetCurrentUsername()), CancellationToken.None);
            if (string.IsNullOrEmpty(res.TRACKING_CODE))
                return Updated(res.RESULT);
            return new BadRequestResult();
        }

        [EnableQuery]
        public async Task<IActionResult> Delete([FromODataUri] Guid key)
        {
            var res = await base._mediator.Send(new CommandDeleteDepartment(key, base._GetCurrentUsername()), CancellationToken.None);
            return Ok(res);
        }
    }
}