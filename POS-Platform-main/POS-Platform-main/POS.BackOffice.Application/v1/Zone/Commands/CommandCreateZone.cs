using AutoMapper;
using MediatR;
using POS.BackOffice.Application.v1.Zone.ViewModels;
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
    public sealed record CommandCreateZone : IRequest<VMBASE_RES<ORG_ZONE>>
    {
        public VMPARAM_CREATE_ORG_ZONE Args { get; set; }
        public string UserName { get; }
        public CommandCreateZone(VMPARAM_CREATE_ORG_ZONE args, string userName)
        {
            Args = args;
            UserName = userName;
        }
        internal sealed class CommandCreateZoneHandler : IRequestHandler<CommandCreateZone, VMBASE_RES<ORG_ZONE>>
           {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandCreateZoneHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_ZONE>> Handle(CommandCreateZone request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_ZONE>();
                try
                {
                    var zone = this._mapper.Map<VMPARAM_CREATE_ORG_ZONE, ORG_ZONE>(request.Args);

                    // Temp: Note company_id เดียวกัน ไม่สามารถมี code ซ้ำกันได้
                    var companyID = new Guid("0413623a-e243-4c68-95c2-e16870542184");           // Com7   : from login => SYS_USER
                    var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                    // Timestamp & Ref ID
                    var now = DateTime.Now;
                    zone.ZONE_ID = Guid.NewGuid();
                    zone.COMPANY_ID = companyID;
                    zone.CREATED_BY_ID = userID;
                    zone.CREATION_DATE = now;
                    zone.LAST_UPDATED_BY_ID = userID;
                    zone.LAST_UPDATE_DATE = now;
                    zone.IS_DELETE = false;

                    this._uow.ORG_ZONE.Add(zone);
                    await this._uow.SaveAsync();

                    res.RESULT = zone;
                    res.MESSAGE = VMBASE_CONST.CREATE_SUCCESS_MSG;
                    return res;
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
