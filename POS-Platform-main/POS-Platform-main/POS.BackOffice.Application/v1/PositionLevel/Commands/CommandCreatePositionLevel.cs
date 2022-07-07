using AutoMapper;
using MediatR;
using POS.BackOffice.Application.v1.PositionLevel.ViewModels;
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
    public sealed record CommandCreatePositionLevel : IRequest<VMBASE_RES<ORG_POSITION_LEVEL>>
    {
        public VMPARAM_CREATE_ORG_POSITION_LEVEL Args { get; set; }
        public string UserName { get; }
        public CommandCreatePositionLevel(VMPARAM_CREATE_ORG_POSITION_LEVEL args , string userName)
        {
            Args = args;
            UserName = userName;
        }
        internal sealed class CommandCreatePositionLevelHandler : IRequestHandler<CommandCreatePositionLevel , VMBASE_RES<ORG_POSITION_LEVEL>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandCreatePositionLevelHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                _util = util;
                _nLog = nLog;
                _uow = uow;
                _mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_POSITION_LEVEL>> Handle(CommandCreatePositionLevel request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_POSITION_LEVEL>();
                try
                {
                    var positionLevel = this._mapper.Map<VMPARAM_CREATE_ORG_POSITION_LEVEL, ORG_POSITION_LEVEL>(request.Args);

                    // Temp: Note company_id เดียวกัน ไม่สามารถมี code ซ้ำกันได้
                    var companyID = new Guid("1b794efa-b6b5-4e57-926f-c79d47db613f");           // Com7   : from login => SYS_USER
                    var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                    // Timestamp & Ref ID
                    var now = DateTime.Now;
                    positionLevel.POSITION_LEVEL_ID = Guid.NewGuid();
                    positionLevel.COMPANY_ID = companyID;
                    positionLevel.CREATED_BY_ID = userID;
                    positionLevel.CREATION_DATE = now;
                    positionLevel.LAST_UPDATED_BY_ID = userID;
                    positionLevel.LAST_UPDATE_DATE = now;
                    positionLevel.IS_DELETE = false;

                    this._uow.ORG_POSITION_LEVEL.Add(positionLevel);
                    await this._uow.SaveAsync();

                    res.RESULT = positionLevel;
                    res.MESSAGE = VMBASE_CONST.CREATE_SUCCESS_MSG;
                    return res;
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
