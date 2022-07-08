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

namespace POS.BackOffice.Application.v1.Employee.Queries
{
    public sealed record QueryEmployeeByKey : IRequest<IQueryable<ORG_EMPLOYEE>>
    {
        public Guid Key { get; }
        public string UserName { get; }
        public QueryEmployeeByKey(Guid key, string userName)
        {
            Key = key;
            UserName = userName;
        }
        internal sealed class QueryEmployeeByKeyHandler : IRequestHandler<QueryEmployeeByKey, IQueryable<ORG_EMPLOYEE>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public QueryEmployeeByKeyHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<IQueryable<ORG_EMPLOYEE>> Handle(QueryEmployeeByKey request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                try
                {
                    return await Task.FromResult(this._uow.ORG_EMPLOYEE.Query().Where(p => p.EMPLOYEE_ID == request.Key));
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
