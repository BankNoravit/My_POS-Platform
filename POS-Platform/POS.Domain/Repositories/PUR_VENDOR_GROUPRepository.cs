using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_VENDOR_GROUPRepository : IRepositoryBase<PUR_VENDOR_GROUP> { }

    public class PUR_VENDOR_GROUPRepository : RepositoryBase<PUR_VENDOR_GROUP>, IPUR_VENDOR_GROUPRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_VENDOR_GROUPRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

