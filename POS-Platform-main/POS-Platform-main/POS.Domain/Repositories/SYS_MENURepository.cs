using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_MENURepository : IRepositoryBase<SYS_MENU> { }

    public class SYS_MENURepository : RepositoryBase<SYS_MENU>, ISYS_MENURepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_MENURepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

