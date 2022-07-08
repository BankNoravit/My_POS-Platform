using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_VIEW_COLUMN_FILTERRepository : IRepositoryBase<SYS_VIEW_COLUMN_FILTER> { }

    public class SYS_VIEW_COLUMN_FILTERRepository : RepositoryBase<SYS_VIEW_COLUMN_FILTER>, ISYS_VIEW_COLUMN_FILTERRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_VIEW_COLUMN_FILTERRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

