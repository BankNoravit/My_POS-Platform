using AutoMapper;
using MediatR;
using POS.Common;
using POS.Domain;
using POS.Domain.Models;
using POS.ViewModels;
using System.Reflection;

namespace POS.Application.v1
{
    public sealed record QueryEmployee : IRequest<IQueryable<ORG_EMPLOYEE>>
    {
        public string UserName { get; }

        public QueryEmployee(string userName)
        {
            UserName = userName;
        }
        internal sealed class QueryEmployeeHandler : IRequestHandler<QueryEmployee, IQueryable<ORG_EMPLOYEE>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public QueryEmployeeHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<IQueryable<ORG_EMPLOYEE>> Handle(QueryEmployee request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                try
                {
                    return await Task.FromResult(this._uow.ORG_EMPLOYEE.Query());
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(Enumerable.Empty<ORG_EMPLOYEE>().AsQueryable());
                }
            }
        }
    }
}
