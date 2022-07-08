using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_BRANCH_ADDRESSRepository : IRepositoryBase<ORG_BRANCH_ADDRESS> { }

    public class ORG_BRANCH_ADDRESSRepository : RepositoryBase<ORG_BRANCH_ADDRESS>, IORG_BRANCH_ADDRESSRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_BRANCH_ADDRESSRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

