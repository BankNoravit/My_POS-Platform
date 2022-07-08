using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_VENDOR_TYPERepository : IRepositoryBase<PUR_VENDOR_TYPE> { }

    public class PUR_VENDOR_TYPERepository : RepositoryBase<PUR_VENDOR_TYPE>, IPUR_VENDOR_TYPERepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_VENDOR_TYPERepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

