using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_UOMRepository : IRepositoryBase<INV_UOM> { }

    public class INV_UOMRepository : RepositoryBase<INV_UOM>, IINV_UOMRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_UOMRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

