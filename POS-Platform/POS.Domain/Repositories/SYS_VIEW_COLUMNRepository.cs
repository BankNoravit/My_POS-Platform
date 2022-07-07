using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_VIEW_COLUMNRepository : IRepositoryBase<SYS_VIEW_COLUMN> { }

    public class SYS_VIEW_COLUMNRepository : RepositoryBase<SYS_VIEW_COLUMN>, ISYS_VIEW_COLUMNRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_VIEW_COLUMNRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

