using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_FRANCHISEE_ADDRESSRepository : IRepositoryBase<ORG_FRANCHISEE_ADDRESS> { }

    public class ORG_FRANCHISEE_ADDRESSRepository : RepositoryBase<ORG_FRANCHISEE_ADDRESS>, IORG_FRANCHISEE_ADDRESSRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_FRANCHISEE_ADDRESSRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

