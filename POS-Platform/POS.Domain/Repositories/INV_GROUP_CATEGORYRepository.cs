using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_GROUP_CATEGORYRepository : IRepositoryBase<INV_GROUP_CATEGORY> { }

    public class INV_GROUP_CATEGORYRepository : RepositoryBase<INV_GROUP_CATEGORY>, IINV_GROUP_CATEGORYRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_GROUP_CATEGORYRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

