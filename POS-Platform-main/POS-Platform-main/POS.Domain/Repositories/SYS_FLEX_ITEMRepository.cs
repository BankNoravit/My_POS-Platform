using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_FLEX_ITEMRepository : IRepositoryBase<SYS_FLEX_ITEM> { }

    public class SYS_FLEX_ITEMRepository : RepositoryBase<SYS_FLEX_ITEM>, ISYS_FLEX_ITEMRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_FLEX_ITEMRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

