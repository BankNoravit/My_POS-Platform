using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_STOCK_REQUISITION_ITEMRepository : IRepositoryBase<INV_STOCK_REQUISITION_ITEM> { }

    public class INV_STOCK_REQUISITION_ITEMRepository : RepositoryBase<INV_STOCK_REQUISITION_ITEM>, IINV_STOCK_REQUISITION_ITEMRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_STOCK_REQUISITION_ITEMRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

