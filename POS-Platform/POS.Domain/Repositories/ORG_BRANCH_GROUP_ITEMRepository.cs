using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_BRANCH_GROUP_ITEMRepository : IRepositoryBase<ORG_BRANCH_GROUP_ITEM> { }

    public class ORG_BRANCH_GROUP_ITEMRepository : RepositoryBase<ORG_BRANCH_GROUP_ITEM>, IORG_BRANCH_GROUP_ITEMRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_BRANCH_GROUP_ITEMRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

