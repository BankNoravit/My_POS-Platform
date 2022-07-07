using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_POSITIONRepository : IRepositoryBase<ORG_POSITION> { }

    public class ORG_POSITIONRepository : RepositoryBase<ORG_POSITION>, IORG_POSITIONRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_POSITIONRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

