using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_SUB_CATEGORYRepository : IRepositoryBase<INV_SUB_CATEGORY> { }

    public class INV_SUB_CATEGORYRepository : RepositoryBase<INV_SUB_CATEGORY>, IINV_SUB_CATEGORYRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_SUB_CATEGORYRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

