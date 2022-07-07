using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_WAREHOUSE_ADDRESSRepository : IRepositoryBase<INV_WAREHOUSE_ADDRESS> { }

    public class INV_WAREHOUSE_ADDRESSRepository : RepositoryBase<INV_WAREHOUSE_ADDRESS>, IINV_WAREHOUSE_ADDRESSRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_WAREHOUSE_ADDRESSRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

