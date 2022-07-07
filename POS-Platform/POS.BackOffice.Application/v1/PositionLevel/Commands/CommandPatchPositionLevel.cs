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

namespace POS.BackOffice.Application.v1.PositionLevel.Commands
{
    public sealed record CommandPatchPositionLevel : IRequest<VMBASE_RES<ORG_POSITION_LEVEL>>
    {
        public Guid Key { get; set; }
        public Delta<ORG_POSITION_LEVEL> Args { get; set; }
        public string UserName { get; }
        public CommandPatchPositionLevel(Guid key , Delta<ORG_POSITION_LEVEL> args, string userName)
        {
            Key = key;
            UserName = userName;
            Args = args;
        }
        internal sealed class CommandPatchPositionLevelHandler : IRequestHandler<CommandPatchPositionLevel , VMBASE_RES<ORG_POSITION_LEVEL>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandPatchPositionLevelHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                _util = util;
                _nLog = nLog;
                _uow = uow;
                _mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_POSITION_LEVEL>> Handle(CommandPatchPositionLevel request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_POSITION_LEVEL>();
                try
                {
                    var positionLevel = await this._uow.ORG_POSITION_LEVEL.GetAsync(f => f.POSITION_LEVEL_ID == request.Key && f.IS_DELETE == false);
                    if (positionLevel != null)
                    {
                        request.Args.Patch(positionLevel);

                        // Temp: Note company_id เดียวกัน ไม่สามารถมี code ซ้ำกันได้
                        var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                        // Timestamp & Ref ID
                        var now = DateTime.Now;
                        positionLevel.LAST_UPDATED_BY_ID = userID;
                        positionLevel.LAST_UPDATE_DATE = now;

                        this._uow.ORG_POSITION_LEVEL.Update(positionLevel);
                        await this._uow.SaveAsync();

                        res.RESULT = positionLevel;
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
                    return await Task.FromResult(new VMBASE_RES<ORG_POSITION_LEVEL>() { TRACKING_CODE = trackingCode, MESSAGE = String.Format(VMBASE_CONST.SERVER_ERROR_MSG, trackingCode) });
                }
            }
        }
    }
}
