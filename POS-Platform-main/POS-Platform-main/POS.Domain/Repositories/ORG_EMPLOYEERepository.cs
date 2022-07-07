using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_EMPLOYEERepository : IRepositoryBase<ORG_EMPLOYEE> { }

    public class ORG_EMPLOYEERepository : RepositoryBase<ORG_EMPLOYEE>, IORG_EMPLOYEERepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_EMPLOYEERepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

