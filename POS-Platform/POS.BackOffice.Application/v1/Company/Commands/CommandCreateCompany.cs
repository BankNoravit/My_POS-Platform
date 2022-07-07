using AutoMapper;
using MediatR;
using POS.BackOffice.Application.v1.Company.ViewModels;
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

namespace POS.BackOffice.Application.v1.Company.Commands
{
    public sealed record CommandCreateCompany : IRequest<VMBASE_RES<ORG_COMPANY>>
    {
        public VMPARAM_CREATE_ORG_COMPANY Args { get; set; }
        public string UserName { get; set; }
        public CommandCreateCompany(VMPARAM_CREATE_ORG_COMPANY args, string userName)
        {
            Args = args;
            UserName = userName;
        }
        internal sealed class CommandCreateCompanyHandler : IRequestHandler<CommandCreateCompany, VMBASE_RES<ORG_COMPANY>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandCreateCompanyHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_COMPANY>> Handle(CommandCreateCompany request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_COMPANY>();
                try
                {
                    var company = this._mapper.Map<VMPARAM_CREATE_ORG_COMPANY, ORG_COMPANY>(request.Args);

                    var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                    // Timestamp & Ref ID
                    var now = DateTime.Now;
                    company.COMPANY_ID = Guid.NewGuid();                    
                    company.CREATED_BY_ID = userID;
                    company.CREATION_DATE = now;
                    company.LAST_UPDATED_BY_ID = userID;
                    company.LAST_UPDATE_DATE = now;
                    company.IS_DELETE = false;

                    this._uow.ORG_COMPANY.Add(company);
                    await this._uow.SaveAsync();

                    res.RESULT = company;
                    res.MESSAGE = VMBASE_CONST.CREATE_SUCCESS_MSG;
                    return res;
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(new VMBASE_RES<ORG_COMPANY>() { TRACKING_CODE = trackingCode, MESSAGE = String.Format(VMBASE_CONST.SERVER_ERROR_MSG, trackingCode) });
                }
            }
        }
    }
}
