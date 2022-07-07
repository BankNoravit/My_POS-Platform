using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_USER_ACCESS_LOGRepository : IRepositoryBase<SYS_USER_ACCESS_LOG> { }

    public class SYS_USER_ACCESS_LOGRepository : RepositoryBase<SYS_USER_ACCESS_LOG>, ISYS_USER_ACCESS_LOGRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_USER_ACCESS_LOGRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

