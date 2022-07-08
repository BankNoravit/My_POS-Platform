using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_OBJECTRepository : IRepositoryBase<SYS_OBJECT> { }

    public class SYS_OBJECTRepository : RepositoryBase<SYS_OBJECT>, ISYS_OBJECTRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_OBJECTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

