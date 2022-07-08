using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_BRANCH_GROUPRepository : IRepositoryBase<ORG_BRANCH_GROUP> { }

    public class ORG_BRANCH_GROUPRepository : RepositoryBase<ORG_BRANCH_GROUP>, IORG_BRANCH_GROUPRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_BRANCH_GROUPRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

