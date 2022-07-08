using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_BRANDRepository : IRepositoryBase<INV_BRAND> { }

    public class INV_BRANDRepository : RepositoryBase<INV_BRAND>, IINV_BRANDRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_BRANDRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

