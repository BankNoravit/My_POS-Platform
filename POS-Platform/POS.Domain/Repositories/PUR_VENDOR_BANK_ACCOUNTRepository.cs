using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_VENDOR_BANK_ACCOUNTRepository : IRepositoryBase<PUR_VENDOR_BANK_ACCOUNT> { }

    public class PUR_VENDOR_BANK_ACCOUNTRepository : RepositoryBase<PUR_VENDOR_BANK_ACCOUNT>, IPUR_VENDOR_BANK_ACCOUNTRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_VENDOR_BANK_ACCOUNTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

