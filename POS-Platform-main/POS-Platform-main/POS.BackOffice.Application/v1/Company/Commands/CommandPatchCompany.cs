﻿using AutoMapper;
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

namespace POS.BackOffice.Application.v1.Company.Commands
{
    public sealed record CommandPatchCompany : IRequest<VMBASE_RES<ORG_COMPANY>>
    {
        public Guid Key { get; set; }
        public Delta<ORG_COMPANY> Args { get; set; }
        public string UserName { get; }
        public CommandPatchCompany(Guid key, Delta<ORG_COMPANY> args, string userName)
        {
            Key = key;
            Args = args;
            UserName = userName;
        }
        internal sealed class CommandPatchCompanyHandler : IRequestHandler<CommandPatchCompany, VMBASE_RES<ORG_COMPANY>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public CommandPatchCompanyHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                _util = util;
                _nLog = nLog;
                _uow = uow;
                _mapper = mapper;
            }
            public async Task<VMBASE_RES<ORG_COMPANY>> Handle(CommandPatchCompany request, CancellationToken cancellationToken)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                var res = new VMBASE_RES<ORG_COMPANY>();
                try
                {
                    var company = await this._uow.ORG_COMPANY.GetAsync(f => f.COMPANY_ID == request.Key && f.IS_DELETE == false);
                    if (company != null)
                    {
                        request.Args.Patch(company);

                        var userID = new Guid("00000000-0000-0000-0000-000000000000");              // Admin  : from login => SYS_USER

                        // Timestamp & Ref ID
                        var now = DateTime.Now;
                        company.LAST_UPDATED_BY_ID = userID;
                        company.LAST_UPDATE_DATE = now;

                        this._uow.ORG_COMPANY.Update(company);
                        await this._uow.SaveAsync();

                        res.RESULT = company;
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
                    return await Task.FromResult(new VMBASE_RES<ORG_COMPANY>() { TRACKING_CODE = trackingCode, MESSAGE = String.Format(VMBASE_CONST.SERVER_ERROR_MSG, trackingCode) });
                }
            }
        }
    }
}

