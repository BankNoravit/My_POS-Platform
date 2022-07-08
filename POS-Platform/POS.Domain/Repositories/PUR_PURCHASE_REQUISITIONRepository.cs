using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_PURCHASE_REQUISITIONRepository : IRepositoryBase<PUR_PURCHASE_REQUISITION> { }

    public class PUR_PURCHASE_REQUISITIONRepository : RepositoryBase<PUR_PURCHASE_REQUISITION>, IPUR_PURCHASE_REQUISITIONRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_PURCHASE_REQUISITIONRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

