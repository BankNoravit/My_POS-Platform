using AutoMapper;
using MediatR;
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

namespace POS.BackOffice.Application.v1.Employee.Commands
{
    public sealed record CommandDeleteEmployee : IRequest<VMBASE_RES<ORG_EMPLOYEE>>
    { 
        public Guid Key { get; set; }
        public string UserName { get; }

        public CommandDeleteEmployee(Guid key, string userName)
        {
            Key = key;
            UserName = userName;
        }
        internal sealed class CommandDeleteEmployeeHandler : IRequestHandler<CommandDeleteEmployee, VMBASE_RES<ORG_EMPLOYEE>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandDeleteEmployeeHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_EMPLOYEE>> Handle(CommandDeleteEmployee request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_EMPLOYEE>();
                try
                {
                    var employee = await this._uow.ORG_EMPLOYEE.GetAsync(f => f.EMPLOYEE_ID == request.Key && f.IS_DELETE == false);
                    if (employee != null)
                    {
                        var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                        // Set flag delete
                        employee.IS_DELETE = true;

                        // Timestamp & Ref ID
                        var now = DateTime.Now;
                        employee.LAST_UPDATED_BY_ID = userID;
                        employee.LAST_UPDATE_DATE = now;

                        this._uow.ORG_EMPLOYEE.Update(employee);
                        await this._uow.SaveAsync();

                        res.MESSAGE = VMBASE_CONST.DELETE_SUCCESS_MSG;
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
                    return await Task.FromResult(new VMBASE_RES<ORG_EMPLOYEE>() { TRACKING_CODE = trackingCode, MESSAGE = String.Format(VMBASE_CONST.SERVER_ERROR_MSG, trackingCode) });
                }
            }
        }
    }
}
