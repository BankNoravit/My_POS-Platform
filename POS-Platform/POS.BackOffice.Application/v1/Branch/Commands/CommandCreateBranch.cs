using AutoMapper;
using MediatR;
using POS.BackOffice.Application.v1.Branch.ViewModels;
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

namespace POS.BackOffice.Application.v1.Branch.Commands
{
    public sealed record CommandCreateBranch : IRequest<VMBASE_RES<ORG_BRANCH>>
    {
        public VMPARAM_CREATE_ORG_BRANCH Args { get; set; }
        public string UserName { get; }
        public CommandCreateBranch(VMPARAM_CREATE_ORG_BRANCH args, string userName)
        {
            Args = args;
            UserName = userName;
        }
        internal sealed class CommandCreateBranchHandler : IRequestHandler<CommandCreateBranch, VMBASE_RES<ORG_BRANCH>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandCreateBranchHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_BRANCH>> Handle(CommandCreateBranch request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_BRANCH>();
                try
                {
                    var branch = this._mapper.Map<VMPARAM_CREATE_ORG_BRANCH, ORG_BRANCH>(request.Args);

                    // Temp: Note company_id เดียวกัน ไม่สามารถมี code ซ้ำกันได้
                    var companyID = new Guid("1b794efa-b6b5-4e57-926f-c79d47db613f");           // Com7   : from login => SYS_USER
                    var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                    // Timestamp & Ref ID
                    var now = DateTime.Now;
                    branch.BRANCH_ID = Guid.NewGuid();
                    branch.COMPANY_ID = companyID;
                    branch.CREATED_BY_ID = userID;
                    branch.CREATION_DATE = now;
                    branch.LAST_UPDATED_BY_ID = userID;
                    branch.LAST_UPDATE_DATE = now;
                    branch.IS_DELETE = false;

                    this._uow.ORG_BRANCH.Add(branch);
                    await this._uow.SaveAsync();

                    res.RESULT = branch;
                    res.MESSAGE = VMBASE_CONST.CREATE_SUCCESS_MSG;
                    return res;
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(new VMBASE_RES<ORG_BRANCH>() { TRACKING_CODE = trackingCode, MESSAGE = String.Format(VMBASE_CONST.SERVER_ERROR_MSG, trackingCode) });
                }
            }
        }
    }
}
