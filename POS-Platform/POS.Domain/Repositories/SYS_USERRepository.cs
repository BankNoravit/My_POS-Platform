using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_USERRepository : IRepositoryBase<SYS_USER> { }

    public class SYS_USERRepository : RepositoryBase<SYS_USER>, ISYS_USERRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_USERRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

