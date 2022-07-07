using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.EntityFrameworkCore;
using POS.Common;
using POS.Domain;
using POS.Domain.Models;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Zone.Commands
{
    public sealed record CommandPatchZone : IRequest<VMBASE_RES<ORG_ZONE>>
    {
        public Guid Key { get; set; }
        public Delta<ORG_ZONE> Args { get; set; }
        public string UserName { get; }
        public CommandPatchZone(Guid key, Delta<ORG_ZONE> args, string userName)
        {
            Key = key;
            UserName = userName;
            Args = args;
        }
        internal sealed class CommandPatchZoneHandler : IRequestHandler<CommandPatchZone, VMBASE_RES<ORG_ZONE>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandPatchZoneHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                _util = util;
                _nLog = nLog;
                _uow = uow;
                _mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_ZONE>> Handle(CommandPatchZone request, CancellationToken cancellationToken)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_ZONE>();
                try
                {
                    var zone = await this._uow.ORG_ZONE.GetAsync(f => f.ZONE_ID == request.Key && f.IS_DELETE == false);
                    if (zone != null)
                    {
                        request.Args.Patch(zone);

                        // Temp: Note company_id เดียวกัน ไม่สามารถมี code ซ้ำกันได้
                        var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                        // Timestamp & Ref ID
                        var now = DateTime.Now;
                        zone.LAST_UPDATED_BY_ID = userID;
                        zone.LAST_UPDATE_DATE = now;

                        this._uow.ORG_ZONE.Update(zone);
                        await this._uow.SaveAsync();

                        res.RESULT = zone;
                        res.MESSAGE = VMBASE_CONST.UPDATE_SUCCESS_MSG;
                    }
                    else
                    {
                        res.MESSAGE = VMBASE_CONST.DATA_NOT_FOUND_MSG;
                    }
                    return res;
                }
                catch (DbUpdateConcurrencyException ccex)
                {   // TODO: Concurrency Check
                    throw ccex;
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(new VMBASE_RES<ORG_ZONE>() { TRACKING_CODE = trackingCode, MESSAGE = String.Format(VMBASE_CONST.SERVER_ERROR_MSG, trackingCode) });
                }
            }
        }
    }
}
