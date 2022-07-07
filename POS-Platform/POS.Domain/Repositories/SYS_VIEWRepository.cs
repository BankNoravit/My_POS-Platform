using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_VIEWRepository : IRepositoryBase<SYS_VIEW> { }

    public class SYS_VIEWRepository : RepositoryBase<SYS_VIEW>, ISYS_VIEWRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_VIEWRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

