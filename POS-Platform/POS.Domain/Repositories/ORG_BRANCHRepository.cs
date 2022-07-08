using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_BRANCHRepository : IRepositoryBase<ORG_BRANCH> { }

    public class ORG_BRANCHRepository : RepositoryBase<ORG_BRANCH>, IORG_BRANCHRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_BRANCHRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

