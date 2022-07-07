using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_PROVINCERepository : IRepositoryBase<SYS_PROVINCE> { }

    public class SYS_PROVINCERepository : RepositoryBase<SYS_PROVINCE>, ISYS_PROVINCERepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_PROVINCERepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

