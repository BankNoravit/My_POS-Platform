using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_BUSINESS_UNITRepository : IRepositoryBase<ORG_BUSINESS_UNIT> { }

    public class ORG_BUSINESS_UNITRepository : RepositoryBase<ORG_BUSINESS_UNIT>, IORG_BUSINESS_UNITRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_BUSINESS_UNITRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

