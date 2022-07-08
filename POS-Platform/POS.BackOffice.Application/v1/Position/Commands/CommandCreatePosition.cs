using AutoMapper;
using MediatR;
using POS.Common;
using POS.Domain;
using POS.Domain.Models;
using POS.ViewModels;
using POS.ViewModels.v1;
using System.Reflection;

namespace POS.Application.v1
{
    public sealed record CommandCreatePosition : IRequest<VMBASE_RES<ORG_POSITION>>
    {
        public VMPARAM_CREATE_ORG_POSITION Args { get; set; }
        public string UserName { get; }
        public CommandCreatePosition(VMPARAM_CREATE_ORG_POSITION args, string userName)
        {
            Args = args;
            UserName = userName;
        }
        internal sealed class CommandCreatePositionHandler : IRequestHandler<CommandCreatePosition, VMBASE_RES<ORG_POSITION>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandCreatePositionHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_POSITION>> Handle(CommandCreatePosition request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_POSITION>();
                try
                {
                    var position = this._mapper.Map<VMPARAM_CREATE_ORG_POSITION, ORG_POSITION>(request.Args);

                    // Temp: Note company_id เดียวกัน ไม่สามารถมี code ซ้ำกันได้
                    var companyID = new Guid("1b794efa-b6b5-4e57-926f-c79d47db613f");           // Com7   : from login => SYS_USER
                    var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                    // Timestamp & Ref ID
                    var now = DateTime.Now;
                    position.POSITION_ID = Guid.NewGuid();
                    position.COMPANY_ID = companyID;
                    position.CREATED_BY_ID = userID;
                    position.CREATION_DATE = now;
                    position.LAST_UPDATED_BY_ID = userID;
                    position.LAST_UPDATE_DATE = now;
                    position.IS_DELETE = false;

                    this._uow.ORG_POSITION.Add(position);
                    await this._uow.SaveAsync();

                    res.RESULT = position;
                    res.MESSAGE = VMBASE_CONST.CREATE_SUCCESS_MSG;
                    return res;
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
