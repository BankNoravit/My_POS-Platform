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

namespace POS.BackOffice.Application.v1.Flex_Item.Queries
{
    public sealed record QueryFlex_Item : IRequest<IQueryable<SYS_FLEX_ITEM>>
    {
        public string UserName { get; }
        public QueryFlex_Item(string userName)
        {
            UserName = userName;
        }
        internal sealed class QueryFlex_ItemHandler : IRequestHandler<QueryFlex_Item, IQueryable<SYS_FLEX_ITEM>>
        {
            private readonly IUtilityCommon _util;
            private readonly INLogCommon _nLog;
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public QueryFlex_ItemHandler(IUtilityCommon util, INLogCommon nLog, IUnitOfWork uow, IMapper mapper)
            {
                this._util = util;
                this._nLog = nLog;
                this._uow = uow;
                this._mapper = mapper;
            }
            public async Task<IQueryable<SYS_FLEX_ITEM>> Handle(QueryFlex_Item request, CancellationToken cancellationToken = default)
            {
                this._nLog.Trace(MethodBase.GetCurrentMethod().Name);
                try
                {
                    return await Task.FromResult(this._uow.SYS_FLEX_ITEM.Query());
                }
                catch (Exception ex)
                {
                    string trackingCode = string.Empty;
                    this._nLog.Error(exception: ex, trackingCode: out trackingCode);
                    return await Task.FromResult(Enumerable.Empty<SYS_FLEX_ITEM>().AsQueryable());
                }
            }
        }
    }
}
