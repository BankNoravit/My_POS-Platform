using AutoMapper;
using MediatR;
using POS.BackOffice.Application.v1.Employee.ViewModels;
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

namespace POS.BackOffice.Application.v1.Employee.Commands
{
    public sealed record CommandCreateEmployee : IRequest<VMBASE_RES<ORG_EMPLOYEE>>
    {
        public VMPARAM_CREATE_ORG_EMPLOYEE Args { get; set; }
        public string UserName { get; }

        public CommandCreateEmployee(VMPARAM_CREATE_ORG_EMPLOYEE args , string userName)
        {
            Args = args;
            UserName = userName;
        }
        internal sealed class CommandCreateEmployeeHandler : IRequestHandler<CommandCreateEmployee , VMBASE_RES<ORG_EMPLOYEE>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandCreateEmployeeHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_EMPLOYEE>> Handle(CommandCreateEmployee request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_EMPLOYEE>();
                try
                {
                    var employee = this._mapper.Map<VMPARAM_CREATE_ORG_EMPLOYEE, ORG_EMPLOYEE>(request.Args);

                    // Temp: Note company_id เดียวกัน ไม่สามารถมี code ซ้ำกันได้
                    var companyID = new Guid("1b794efa-b6b5-4e57-926f-c79d47db613f");           // Com7   : from login => SYS_USER
                    var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                    // Timestamp & Ref ID
                    var now = DateTime.Now;
                    employee.EMPLOYEE_ID = Guid.NewGuid();
                    employee.COMPANY_ID = companyID;
                    employee.CREATED_BY_ID = userID;
                    employee.CREATION_DATE = now;
                    employee.LAST_UPDATED_BY_ID = userID;
                    employee.LAST_UPDATE_DATE = now;
                    employee.IS_DELETE = false;

                    this._uow.ORG_EMPLOYEE.Add(employee);
                    await this._uow.SaveAsync();

                    res.RESULT = employee;
                    res.MESSAGE = VMBASE_CONST.CREATE_SUCCESS_MSG;
                    return res;
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(new VMBASE_RES<ORG_EMPLOYEE>() { TRACKING_CODE = trackingCode, MESSAGE = String.Format(VMBASE_CONST.SERVER_ERROR_MSG, trackingCode) });
                }
            }

        }
    }
}
