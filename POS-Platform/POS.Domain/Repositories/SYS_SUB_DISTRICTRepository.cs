using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_SUB_DISTRICTRepository : IRepositoryBase<SYS_SUB_DISTRICT> { }

    public class SYS_SUB_DISTRICTRepository : RepositoryBase<SYS_SUB_DISTRICT>, ISYS_SUB_DISTRICTRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_SUB_DISTRICTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

