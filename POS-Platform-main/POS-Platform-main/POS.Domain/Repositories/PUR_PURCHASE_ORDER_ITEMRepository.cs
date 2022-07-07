using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_PURCHASE_ORDER_ITEMRepository : IRepositoryBase<PUR_PURCHASE_ORDER_ITEM> { }

    public class PUR_PURCHASE_ORDER_ITEMRepository : RepositoryBase<PUR_PURCHASE_ORDER_ITEM>, IPUR_PURCHASE_ORDER_ITEMRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_PURCHASE_ORDER_ITEMRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

