using AutoMapper;
using MediatR;
using POS.Common;
using POS.Domain;
using POS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Zone.Queries
{
    public sealed record QueryZoneByKey : IRequest<IQueryable<ORG_ZONE>>
    {
        public Guid Key { get; set; }
        public string UserName { get; }
        public QueryZoneByKey(Guid key , string userName)
        {
            Key = key;
            UserName = userName;
        }
        internal sealed class QueryZoneByKeyHandler : IRequestHandler<QueryZoneByKey , IQueryable<ORG_ZONE>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public QueryZoneByKeyHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                _util = util;
                _nLog = nLog;
                _uow = uow;
                _mapper = mapper;   
            }
            public async Task<IQueryable<ORG_ZONE>> Handle(QueryZoneByKey request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                try
                {
                    return await Task.FromResult(this._uow.ORG_ZONE.Query().Where(p => p.ZONE_ID == request.Key));
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(Enumerable.Empty<ORG_ZONE>().AsQueryable());
                }
            }
        }
    }
}
