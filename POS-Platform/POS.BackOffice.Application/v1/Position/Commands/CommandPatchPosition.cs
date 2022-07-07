using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.EntityFrameworkCore;
using POS.Common;
using POS.Domain;
using POS.Domain.Models;
using POS.ViewModels;
using System.Reflection;

namespace POS.Application.v1
{
    public sealed record CommandPatchPosition : IRequest<VMBASE_RES<ORG_POSITION>>
    {
        public Guid Key { get; set; }
        public Delta<ORG_POSITION> Args { get; set; }
        public string UserName { get; }
        public CommandPatchPosition(Guid key, Delta<ORG_POSITION> args, string userName)
        {
            Key = key;
            Args = args;
            UserName = userName;
        }
        internal sealed class CommandPatchPositionHandler : IRequestHandler<CommandPatchPosition, VMBASE_RES<ORG_POSITION>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandPatchPositionHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_POSITION>> Handle(CommandPatchPosition request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_POSITION>();
                try
                {
                    var position = await this._uow.ORG_POSITION.GetAsync(f => f.POSITION_ID == request.Key && f.IS_DELETE == false);
                    if (position != null)
                    {
                        request.Args.Patch(position);

                        // Temp: Note company_id เดียวกัน ไม่สามารถมี code ซ้ำกันได้
                        var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                        // Timestamp & Ref ID
                        var now = DateTime.Now;
                        position.LAST_UPDATED_BY_ID = userID;
                        position.LAST_UPDATE_DATE = now;

                        this._uow.ORG_POSITION.Update(position);
                        await this._uow.SaveAsync();

                        res.RESULT = position;
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
                    return await Task.FromResult(new VMBASE_RES<ORG_POSITION>() { TRACKING_CODE = trackingCode, MESSAGE = String.Format(VMBASE_CONST.SERVER_ERROR_MSG, trackingCode) });
                }
            }
        }
    }
}
