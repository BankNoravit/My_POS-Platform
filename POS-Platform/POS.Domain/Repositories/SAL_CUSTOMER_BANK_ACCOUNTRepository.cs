using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISAL_CUSTOMER_BANK_ACCOUNTRepository : IRepositoryBase<SAL_CUSTOMER_BANK_ACCOUNT> { }

    public class SAL_CUSTOMER_BANK_ACCOUNTRepository : RepositoryBase<SAL_CUSTOMER_BANK_ACCOUNT>, ISAL_CUSTOMER_BANK_ACCOUNTRepository
    {
        private readonly IDBHelper _dbHelper;

        public SAL_CUSTOMER_BANK_ACCOUNTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

