using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_PRODDUCT_SELLING_POINTRepository : IRepositoryBase<INV_PRODDUCT_SELLING_POINT> { }

    public class INV_PRODDUCT_SELLING_POINTRepository : RepositoryBase<INV_PRODDUCT_SELLING_POINT>, IINV_PRODDUCT_SELLING_POINTRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_PRODDUCT_SELLING_POINTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

