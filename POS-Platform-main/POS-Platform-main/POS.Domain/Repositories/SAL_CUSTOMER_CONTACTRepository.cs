using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISAL_CUSTOMER_CONTACTRepository : IRepositoryBase<SAL_CUSTOMER_CONTACT> { }

    public class SAL_CUSTOMER_CONTACTRepository : RepositoryBase<SAL_CUSTOMER_CONTACT>, ISAL_CUSTOMER_CONTACTRepository
    {
        private readonly IDBHelper _dbHelper;

        public SAL_CUSTOMER_CONTACTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

