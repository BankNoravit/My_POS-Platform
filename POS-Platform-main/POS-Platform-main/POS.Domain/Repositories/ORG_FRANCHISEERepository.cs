using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_FRANCHISEERepository : IRepositoryBase<ORG_FRANCHISEE> { }

    public class ORG_FRANCHISEERepository : RepositoryBase<ORG_FRANCHISEE>, IORG_FRANCHISEERepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_FRANCHISEERepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

