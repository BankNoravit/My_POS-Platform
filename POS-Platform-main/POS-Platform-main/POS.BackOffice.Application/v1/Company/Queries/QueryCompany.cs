using AutoMapper;
using MediatR;
using POS.Common;
using POS.Domain;
using POS.Domain.Models;
using POS.ViewModels;
using System.Reflection;

namespace POS.Application.v1
{
    public sealed record QueryCompany : IRequest<IQueryable<ORG_COMPANY>>
    {
        public string UserName { get; }
        public QueryCompany(string userName)
        {
            UserName = userName;
        }
        internal sealed class QueryCompanyHandler : IRequestHandler<QueryCompany, IQueryable<ORG_COMPANY>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public QueryCompanyHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<IQueryable<ORG_COMPANY>> Handle(QueryCompany request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                try
                {
                    return await Task.FromResult(this._uow.ORG_COMPANY.Query());
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(Enumerable.Empty<ORG_COMPANY>().AsQueryable());
                }
            }
        }
    }
}
