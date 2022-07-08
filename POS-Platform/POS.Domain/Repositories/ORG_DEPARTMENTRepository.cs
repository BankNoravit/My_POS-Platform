using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_DEPARTMENTRepository : IRepositoryBase<ORG_DEPARTMENT> { }

    public class ORG_DEPARTMENTRepository : RepositoryBase<ORG_DEPARTMENT>, IORG_DEPARTMENTRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_DEPARTMENTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

