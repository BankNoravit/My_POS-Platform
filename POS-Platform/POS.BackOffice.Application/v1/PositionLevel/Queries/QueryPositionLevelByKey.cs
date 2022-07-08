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

namespace POS.BackOffice.Application.v1.PositionLevel.Queries
{
    public sealed record QueryPositionLevelByKey : IRequest<IQueryable<ORG_POSITION_LEVEL>>
    {
        public Guid Key { get; set; }
        public string UserName { get; }

        public QueryPositionLevelByKey( Guid key , string userName)
        {
            Key = key;
            UserName = userName;
        }
        internal sealed class QueryPositionLevelByKeyHandler : IRequestHandler<QueryPositionLevelByKey , IQueryable<ORG_POSITION_LEVEL>>
        {
            private readonly IUtilityCommon _until;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public QueryPositionLevelByKeyHandler(IUtilityCommon until, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                _until = until;
                _nLog = nLog;
                _uow = uow;
                _mapper = mapper;
            }
            public async Task<IQueryable<ORG_POSITION_LEVEL>> Handle(QueryPositionLevelByKey request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                try
                {
                    return await Task.FromResult(this._uow.ORG_POSITION_LEVEL.Query().Where(p => p.POSITION_LEVEL_ID == request.Key));
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
