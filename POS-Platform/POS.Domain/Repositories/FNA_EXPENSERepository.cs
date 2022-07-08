using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IFNA_EXPENSERepository : IRepositoryBase<FNA_EXPENSE> { }

    public class FNA_EXPENSERepository : RepositoryBase<FNA_EXPENSE>, IFNA_EXPENSERepository
    {
        private readonly IDBHelper _dbHelper;

        public FNA_EXPENSERepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

