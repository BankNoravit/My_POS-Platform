using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_PRODUCTRepository : IRepositoryBase<INV_PRODUCT> { }

    public class INV_PRODUCTRepository : RepositoryBase<INV_PRODUCT>, IINV_PRODUCTRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_PRODUCTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

