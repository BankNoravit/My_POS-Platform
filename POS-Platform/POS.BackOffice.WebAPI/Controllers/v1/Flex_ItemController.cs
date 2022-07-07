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
using POS.Controllers.v1;
using POS.BackOffice.Application.v1.Branch.Queries;
using POS.BackOffice.Application.v1.Flex_Item.Queries;

namespace POS.BackOffice.WebAPI.Controllers.v1
{
    //[ApiVersion("1.0")]
    public class Flex_ItemController : BaseController
    {
        public Flex_ItemController(IOptions<APP_SETTINGS> appSettings, IMediator mediator) : base(appSettings, mediator) { }

        [EnableQuery]
        public async Task<IQueryable<SYS_FLEX_ITEM>> Get()
        {
            return await base._mediator.Send(new QueryFlex_Item(base._GetCurrentUsername()), CancellationToken.None);
        }
    }
}
