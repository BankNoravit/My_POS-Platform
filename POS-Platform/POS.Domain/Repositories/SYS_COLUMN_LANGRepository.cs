using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_COLUMN_LANGRepository : IRepositoryBase<SYS_COLUMN_LANG> { }

    public class SYS_COLUMN_LANGRepository : RepositoryBase<SYS_COLUMN_LANG>, ISYS_COLUMN_LANGRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_COLUMN_LANGRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

