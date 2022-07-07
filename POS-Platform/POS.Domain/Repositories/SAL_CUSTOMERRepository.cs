using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISAL_CUSTOMERRepository : IRepositoryBase<SAL_CUSTOMER> { }

    public class SAL_CUSTOMERRepository : RepositoryBase<SAL_CUSTOMER>, ISAL_CUSTOMERRepository
    {
        private readonly IDBHelper _dbHelper;

        public SAL_CUSTOMERRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

