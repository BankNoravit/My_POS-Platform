using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_DISTRICTRepository : IRepositoryBase<SYS_DISTRICT> { }

    public class SYS_DISTRICTRepository : RepositoryBase<SYS_DISTRICT>, ISYS_DISTRICTRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_DISTRICTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

