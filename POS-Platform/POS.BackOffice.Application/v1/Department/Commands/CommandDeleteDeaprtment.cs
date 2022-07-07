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

namespace POS.BackOffice.Application.v1.Department.Commands
{
    public sealed record CommandDeleteDepartment : IRequest<VMBASE_RES<ORG_DEPARTMENT>>
    {
        public Guid Key { get; set; }
        public string UserName { get; set; }

        public CommandDeleteDepartment(Guid key, string username)
        {
            Key = key;
            UserName = username;   
        }
        internal sealed class CommandDeleteDepartmentHandler : IRequestHandler<CommandDeleteDepartment, VMBASE_RES<ORG_DEPARTMENT>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandDeleteDepartmentHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_DEPARTMENT>> Handle(CommandDeleteDepartment request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_DEPARTMENT>();
                try
                {
                    var department = await this._uow.ORG_DEPARTMENT.GetAsync(f => f.DEPARTMENT_ID == request.Key && f.IS_DELETE == false);
                    if (department != null)
                    {
                        var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                        // Set flag delete
                        department.IS_DELETE = true;

                        // Timestamp & Ref ID
                        var now = DateTime.Now;
                        department.LAST_UPDATED_BY_ID = userID;
                        department.LAST_UPDATE_DATE = now;

                        this._uow.ORG_DEPARTMENT.Update(department);
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
                    return await Task.FromResult(new VMBASE_RES<ORG_DEPARTMENT>() { TRACKING_CODE = trackingCode, MESSAGE = String.Format(VMBASE_CONST.SERVER_ERROR_MSG, trackingCode) });
                }
            }

        }
    }
}
