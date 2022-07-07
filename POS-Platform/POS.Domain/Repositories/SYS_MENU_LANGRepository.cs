using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISYS_MENU_LANGRepository : IRepositoryBase<SYS_MENU_LANG> { }

    public class SYS_MENU_LANGRepository : RepositoryBase<SYS_MENU_LANG>, ISYS_MENU_LANGRepository
    {
        private readonly IDBHelper _dbHelper;

        public SYS_MENU_LANGRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

