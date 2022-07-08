using AutoMapper;
using MediatR;
using POS.Common;
using POS.Domain;
using POS.Domain.Models;
using POS.ViewModels;
using System.Reflection;

namespace POS.Application.v1
{
    public sealed record QueryPositionByKey : IRequest<IQueryable<ORG_POSITION>>
    {
        public Guid Key { get; }
        public string UserName { get; }
        public QueryPositionByKey(Guid key, string userName)
        {
            Key = key;
            UserName = userName;
        }
        internal sealed class QueryPositionByKeyHandler : IRequestHandler<QueryPositionByKey, IQueryable<ORG_POSITION>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public QueryPositionByKeyHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<IQueryable<ORG_POSITION>> Handle(QueryPositionByKey request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                try
                {
                    return await Task.FromResult(this._uow.ORG_POSITION.Query().Where(p => p.POSITION_ID == request.Key));
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(Enumerable.Empty<ORG_POSITION>().AsQueryable());
                }
            }
        }
    }
}
