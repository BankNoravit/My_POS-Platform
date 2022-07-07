using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISAL_CUSTOMER_GROUPRepository : IRepositoryBase<SAL_CUSTOMER_GROUP> { }

    public class SAL_CUSTOMER_GROUPRepository : RepositoryBase<SAL_CUSTOMER_GROUP>, ISAL_CUSTOMER_GROUPRepository
    {
        private readonly IDBHelper _dbHelper;

        public SAL_CUSTOMER_GROUPRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

