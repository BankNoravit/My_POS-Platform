using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_COLUMNRepository : IRepositoryBase<SYS_COLUMN> { }

    public class SYS_COLUMNRepository : RepositoryBase<SYS_COLUMN>, ISYS_COLUMNRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_COLUMNRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

