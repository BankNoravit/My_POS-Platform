using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_USER_ACCESSRepository : IRepositoryBase<SYS_USER_ACCESS> { }

    public class SYS_USER_ACCESSRepository : RepositoryBase<SYS_USER_ACCESS>, ISYS_USER_ACCESSRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_USER_ACCESSRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

