﻿using AutoMapper;
using MediatR;
using POS.Common;
using POS.Domain;
using POS.Domain.Models;
using POS.ViewModels;
using System.Reflection;

namespace POS.Application.v1
{
    public sealed record QueryPositionLevel : IRequest<IQueryable<ORG_POSITION_LEVEL>>
    {
        public string UserName { get; }
        public QueryPositionLevel(string userName)
        {
            UserName = userName;
        }
        internal sealed class QueryPositionLevelHandler : IRequestHandler<QueryPositionLevel, IQueryable<ORG_POSITION_LEVEL>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public QueryPositionLevelHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<IQueryable<ORG_POSITION_LEVEL>> Handle(QueryPositionLevel request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                try
                {
                    return await Task.FromResult(this._uow.ORG_POSITION_LEVEL.Query());
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(Enumerable.Empty<ORG_POSITION_LEVEL>().AsQueryable());
                }
            }
        }
    }
}
