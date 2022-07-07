using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_FLEXRepository : IRepositoryBase<SYS_FLEX> { }

    public class SYS_FLEXRepository : RepositoryBase<SYS_FLEX>, ISYS_FLEXRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_FLEXRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

