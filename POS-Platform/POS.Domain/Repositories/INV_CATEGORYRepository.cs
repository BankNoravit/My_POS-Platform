using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_CATEGORYRepository : IRepositoryBase<INV_CATEGORY> { }

    public class INV_CATEGORYRepository : RepositoryBase<INV_CATEGORY>, IINV_CATEGORYRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_CATEGORYRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

