using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_STOCK_REQUISITIONRepository : IRepositoryBase<INV_STOCK_REQUISITION> { }

    public class INV_STOCK_REQUISITIONRepository : RepositoryBase<INV_STOCK_REQUISITION>, IINV_STOCK_REQUISITIONRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_STOCK_REQUISITIONRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

