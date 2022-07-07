using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_WAREHOUSE_LOCATIONRepository : IRepositoryBase<INV_WAREHOUSE_LOCATION> { }

    public class INV_WAREHOUSE_LOCATIONRepository : RepositoryBase<INV_WAREHOUSE_LOCATION>, IINV_WAREHOUSE_LOCATIONRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_WAREHOUSE_LOCATIONRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

