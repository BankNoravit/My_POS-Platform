using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISAL_CUSTOMER_ADDRESSRepository : IRepositoryBase<SAL_CUSTOMER_ADDRESS> { }

    public class SAL_CUSTOMER_ADDRESSRepository : RepositoryBase<SAL_CUSTOMER_ADDRESS>, ISAL_CUSTOMER_ADDRESSRepository
    {
        private readonly IDBHelper _dbHelper;

        public SAL_CUSTOMER_ADDRESSRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

